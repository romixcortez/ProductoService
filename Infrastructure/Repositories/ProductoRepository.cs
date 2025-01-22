using Application.Contracts.Repositories;
using Application.Models;
using Domian.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ProductoDbContext _productocontext;
        public ProductoRepository(ProductoDbContext productocontext)
        {
            _productocontext = productocontext;
        }

        public async Task<bool> Actualizar(ProductoDTO productoDTO)
        {
            var producto = await _productocontext.Productos.FindAsync(productoDTO!.IdProducto);

            if (producto == null)
            {
                throw new Exception("No se encontró ningún registro de producto.");
            }

            producto.Name = productoDTO.Name;
            producto.Price = productoDTO.Price;
            producto.Quantity = productoDTO.Quantity;
            producto.CreatedAt = productoDTO.CreatedAt;

            _productocontext.Productos.Update(producto);
            await _productocontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int Idproducto)
        {
            var producto = await _productocontext.Productos.FirstOrDefaultAsync(x => x.IdProducto == Idproducto);
            if (producto == null)
            {
                return false;
            }
            else
            {
                producto.Estado = "Eliminado";
                await _productocontext.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<Producto>> Listar()
        {
            return await _productocontext.Productos.ToListAsync();
        }

        public async Task<List<Producto>> ListarId(int Id)
        {
            return await _productocontext.Productos.Where(x => x.IdProducto == Id).ToListAsync();

        }
    }
}
