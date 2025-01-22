using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Gateway
{
    public class ResponseOrdenesId
    {
        public int OrderId { get; set; }
        public int Total { get; set; }
        public DateTime FechaPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
    }
}
