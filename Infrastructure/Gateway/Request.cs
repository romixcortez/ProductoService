using Domian.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Gateway
{
    public class Request
    {
        [Key]
        public int OrderId { get; set; }
        public int Total { get; set; }
        [Required]
        public DateTime FechaPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
    }
}
