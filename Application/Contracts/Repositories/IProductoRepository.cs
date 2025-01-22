using Application.Models;
using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repositories
{
    public interface IProductoRepository
    {
        Task<List<Producto>> ListarId(int Id);
        Task<List<Producto>> Listar();
        Task<bool> Actualizar(ProductoDTO productoDTO);
        Task<bool> Delete(int Id);



    }
}
