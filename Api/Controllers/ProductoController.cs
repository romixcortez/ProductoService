using Application.Contracts.Repositories;
using Application.Models;
using Domian.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;
        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        [HttpGet("Listar")]
        public async Task<ActionResult<List<Producto>>> Listar()
        {
            try
            {
                return await _productoRepository.Listar();

            }
            catch
            {
                return BadRequest("Error el registro de producto no existe");
            }
        }


        [HttpGet("ListarId")]
        public async Task<ActionResult<List<Producto>>> ListarId(int Id)
        {
            try
            {
                return await _productoRepository.ListarId(Id);

            }
            catch
            {
                return BadRequest("Error el registro de producto no existe");
            }
        }


        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar([FromForm] ProductoDTO productoDTO)
        {
            var result = await _productoRepository.Actualizar(productoDTO);
            return result ? Ok("Producto modificado exitosamente") : BadRequest("No se pudo modificar el producto");
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Delete(int Idproducto)
        {
            var respuesta = await _productoRepository.Delete(Idproducto);
            if (respuesta) { return Ok(); }
            else { return NotFound(); }
        }

    }
}
