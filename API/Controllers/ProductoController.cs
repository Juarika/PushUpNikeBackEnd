using API.Dtos;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace API.Controllers;
[ApiVersion("1.0")]
[ApiVersion("1.1")]
[ApiVersion("1.2")]

public class ProductoController : ApiBaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

   public ProductoController(IUnitOfWork uniOfWork,IMapper mapper)
    {
        _unitOfWork = uniOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<ProductoDto>>> Get()
    {
        var entities = await _unitOfWork.Productos.GetAllAsync();
        return _mapper.Map<List<ProductoDto>>(entities);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProductoDto>> Post(ProductoDto modelDto)
    {
        var entity = _mapper.Map<Producto>(modelDto);
        _unitOfWork.Productos.Add(entity);
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
    public async Task<ActionResult<ProductoDto>> Put(int id, [FromBody] ProductoDto modelDto)
    {
        if (modelDto == null) return NotFound();
        var entity = _mapper.Map<Producto>(modelDto);
        _unitOfWork.Productos.Update(entity);
        await _unitOfWork.SaveAsync();
        return modelDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _unitOfWork.Productos.GetByIdAsync(id);
        if (entity == null) return NotFound();
        _unitOfWork.Productos.Remove(entity);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}