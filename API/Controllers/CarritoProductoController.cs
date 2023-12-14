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
public class CarritoProductoController : ApiBaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

   public CarritoProductoController(IUnitOfWork uniOfWork,IMapper mapper)
    {
        _unitOfWork = uniOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<CarritoProductoDto>>> Get()
    {
        var entities = await _unitOfWork.CarritoProductos.GetAllAsync();
        return _mapper.Map<List<CarritoProductoDto>>(entities);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CarritoProductoDto>> Post(CarritoProductoDto modelDto)
    {
        var entity = _mapper.Map<CarritoProducto>(modelDto);
        _unitOfWork.CarritoProductos.Add(entity);
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
    public async Task<ActionResult<CarritoProductoDto>> Put(int id, [FromBody] CarritoProductoDto modelDto)
    {
        if (modelDto == null) return NotFound();
        var entity = _mapper.Map<CarritoProducto>(modelDto);
        _unitOfWork.CarritoProductos.Update(entity);
        await _unitOfWork.SaveAsync();
        return modelDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _unitOfWork.CarritoProductos.GetByIdAsync(id);
        if (entity == null) return NotFound();
        _unitOfWork.CarritoProductos.Remove(entity);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
