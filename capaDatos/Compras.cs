using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Compras
    {


        private string idCliente { get; set; }

        private string idProducto { get; set; }
        private string fechaCompra { get; set; }



        public Compras(string pIdCliente, string pIdProducto,string pFechaCompra)
        {
            this.idCliente = pIdCliente;
            this.idProducto = pIdProducto;
            this.fechaCompra = pFechaCompra;
        }
        public Compras() { }

        public string Cliente   // property
        {
            get { return idCliente; }   // get method
            set { idCliente = value; }  // set method
        }
        public string Producto   // property
        {
            get { return idProducto; }   // get method
            set { idProducto = value; }  // set method
        }
        public string Fecha   // property
        {
            get { return fechaCompra; }   // get method
            set { fechaCompra = value; }  // set method
        }

    }

}

