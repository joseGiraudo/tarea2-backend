using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Activo {  get; set; }

        public Usuario(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
        public Usuario() { }
    }
}
