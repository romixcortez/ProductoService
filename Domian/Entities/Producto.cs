using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Entities
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string? Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Estado { get; set; } = string.Empty;
    }
}
