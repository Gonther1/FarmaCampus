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
public class TipoDocumentoController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public TipoDocumentoController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TipoDocumentoDto>>> Get()
    {
        var entity = await _unitOfWork.TiposDocumentos.GetAllAsync();
        return _mapper.Map<List<TipoDocumentoDto>>(entity);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TipoDocumento>> Post(TipoDocumentoDto entityDto)
    {
        var entity = _mapper.Map<TipoDocumento>(entityDto);
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
        _unitOfWork.TiposDocumentos.Add(entity);
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
    public async Task<ActionResult<TipoDocumentoDto>> Get(int id)
    {
        var entity = await _unitOfWork.TiposDocumentos.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        return _mapper.Map<TipoDocumentoDto>(entity);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TipoDocumentoDto>> Put(int id, [FromBody] TipoDocumentoDto entityDto)
    {
        var entity = _mapper.Map<TipoDocumento>(entityDto);
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
        _unitOfWork.TiposDocumentos.Update(entity);
        await _unitOfWork.SaveAsync();
        return entityDto;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(int id)
    {
        var entity = await _unitOfWork.TiposDocumentos.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        _unitOfWork.TiposDocumentos.Remove(entity);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
