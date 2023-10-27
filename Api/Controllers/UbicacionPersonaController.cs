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
public class UbicacionPersonaController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public UbicacionPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<UbicacionPersonaDto>>> Get()
    {
        var entity = await _unitOfWork.UbicacionesPersonas.GetAllAsync();
        return _mapper.Map<List<UbicacionPersonaDto>>(entity);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<UbicacionPersona>> Post(UbicacionPersonaDto entityDto)
    {
        var entity = _mapper.Map<UbicacionPersona>(entityDto);
    /*
        if (entity.FechaCreacion == DateTime.MinValue)
        {
            entity.FechaCreacion = DateTime.Now;
            entityDto.FechaCreacion = DateTime.Now;
        }
        if (entity.FechaModificacion == DateTime.MinValue)
        {
            entity.FechaModificacion = DateTime.Now;
            entityDto.FechaModificacion = DateTime.Now;
        }
    */
        _unitOfWork.UbicacionesPersonas.Add(entity);
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
    public async Task<ActionResult<UbicacionPersonaDto>> Get(int id)
    {
        var entity = await _unitOfWork.UbicacionesPersonas.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        return _mapper.Map<UbicacionPersonaDto>(entity);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<UbicacionPersonaDto>> Put(int id, [FromBody] UbicacionPersonaDto entityDto)
    {
        var entity = _mapper.Map<UbicacionPersona>(entityDto);
        if (entity.Id == 0)
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
    /*
        if (entity.FechaCreacion == DateTime.MinValue)
        {
            entity.FechaCreacion = DateTime.Now;
            entityDto.FechaCreacion = DateTime.Now;
        }
        if (entity.FechaModificacion == DateTime.MinValue)
        {
            entity.FechaModificacion = DateTime.Now;
            entityDto.FechaModificacion = DateTime.Now;
        }
    */
        entityDto.Id = entity.Id;
        _unitOfWork.UbicacionesPersonas.Update(entity);
        await _unitOfWork.SaveAsync();
        return entityDto;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(int id)
    {
        var entity = await _unitOfWork.UbicacionesPersonas.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        _unitOfWork.UbicacionesPersonas.Remove(entity);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
