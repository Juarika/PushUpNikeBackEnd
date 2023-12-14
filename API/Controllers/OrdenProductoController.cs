using API.Dtos;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using AutoMapper;
using Domain.Entities;
using API.Helpers;

namespace API.Controllers;
[ApiVersion("1.0")]
[ApiVersion("1.1")]
[ApiVersion("1.2")]
public class OrdenProductoController : ApiBaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

   public OrdenProductoController(IUnitOfWork uniOfWork,IMapper mapper)
    {
        _unitOfWork = uniOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<OrdenProductoDto>>> Get()
    {
        var entities = await _unitOfWork.OrdenProductos.GetAllAsync();
        return _mapper.Map<List<OrdenProductoDto>>(entities);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<OrdenProductoDto>> Post(OrdenProductoDto modelDto)
    {
        var entity = _mapper.Map<OrdenProducto>(modelDto);
        _unitOfWork.OrdenProductos.Add(entity);
        await _unitOfWork.SaveAsync();
        if (entity == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), modelDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<OrdenProductoDto>> Put(int id, [FromBody] OrdenProductoDto modelDto)
    {
        if (modelDto == null) return NotFound();
        var entity = _mapper.Map<OrdenProducto>(modelDto);
        _unitOfWork.OrdenProductos.Update(entity);
        await _unitOfWork.SaveAsync();
        return modelDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _unitOfWork.OrdenProductos.GetByIdAsync(id);
        if (entity == null) return NotFound();
        _unitOfWork.OrdenProductos.Remove(entity);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
