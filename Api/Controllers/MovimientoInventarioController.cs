using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Api.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers;

public class MovimientoInventarioController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public MovimientoInventarioController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<MovimientoInventarioDto>>> Get()
    {
        var entity = await _unitOfWork.MovimientosInventarios.GetAllAsync();
        return _mapper.Map<List<MovimientoInventarioDto>>(entity);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<MovimientoInventario>> Post(MovimientoInventarioDto entityDto)
    {
        var entity = _mapper.Map<MovimientoInventario>(entityDto);

        if (entity.FechaMovimiento == DateTime.MinValue)
        {
            entity.FechaMovimiento = DateTime.Now;
            entityDto.FechaMovimiento = DateTime.Now;
        }
        if (entity.FechaVencimiento == DateTime.MinValue)
        {
            entity.FechaVencimiento = DateTime.Now;
            entityDto.FechaVencimiento = DateTime.Now;
        }

        _unitOfWork.MovimientosInventarios.Add(entity);

        await _unitOfWork.SaveAsync();
        if (entity == null)
        {
            return BadRequest();
        }
        entityDto.Id = entity.Id;
        return CreatedAtAction(nameof(Post), new { id = entityDto.Id }, entityDto);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<MovimientoInventarioDto>> Get(string id)
    {
        var entity = await _unitOfWork.MovimientosInventarios.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        return _mapper.Map<MovimientoInventarioDto>(entity);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<MovimientoInventarioDto>> Put(string id, [FromBody] MovimientoInventarioDto entityDto)
    {
        var entity = _mapper.Map<MovimientoInventario>(entityDto);

        
        if (entity.Id == "")
        {
            entity.Id = id;
        }
        if (entity.Id != id)
        {
            return BadRequest();
        }
        if (entity == null)
        {
            return NotFound();
        } 
       

        if (entity.FechaMovimiento == DateTime.MinValue)
        {
            entity.FechaMovimiento = DateTime.Now;
            entityDto.FechaMovimiento = DateTime.Now;
        }
        if (entity.FechaVencimiento == DateTime.MinValue)
        {
            entity.FechaVencimiento = DateTime.Now;
            entityDto.FechaVencimiento = DateTime.Now;
        }

        entityDto.Id = entity.Id;
        _unitOfWork.MovimientosInventarios.Update(entity);
        await _unitOfWork.SaveAsync();
        return entityDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string id)
    {
        var entity = await _unitOfWork.MovimientosInventarios.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        _unitOfWork.MovimientosInventarios.Remove(entity);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
