using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Clientes
    {


        private string cedula { get; set; }
        
        private string nombre { get; set; }
        private string primerApellido { get; set; }

        private string sexo { get; set; }
        private string fechaNacimiento { get; set; }


        public Clientes( string pIdentificacion, string pNombre, string pPrimerApellido, string pSexo, string pFechaNacimiento)
        {
            this.cedula = pIdentificacion;            
            this.nombre = pNombre;
            this.primerApellido = primerApellido;
            this.sexo = pSexo;
            this.fechaNacimiento  = pFechaNacimiento;

        }
        public Clientes() { }

        public string Cedula   // property
        {
            get { return cedula; }   // get method
            set { cedula = value; }  // set method
        }
        public string Nombre   // property
        {
            get { return nombre; }   // get method
            set { nombre = value; }  // set method
        }
        public string Apellido   // property
        {
            get { return primerApellido; }   // get method
            set { primerApellido = value; }  // set method
        }

        public string Sexo  // property
        {
            get { return sexo; }   // get method
            set { sexo = value; }  // set method
        }
        public string FechaNacimiento // property
        {
            get { return fechaNacimiento; }   // get method
            set { fechaNacimiento = value; }  // set method
        }
    }

}
