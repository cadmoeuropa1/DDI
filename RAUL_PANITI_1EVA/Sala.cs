using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAUL_PANITI_1EVA
{
    public class Sala
    {
        public String nombre;
        public String[] horas;
        public int capacidad;

        public Sala(String nombre, int capacidad)
        {
            this.nombre = nombre;
            this.capacidad = capacidad;
            String horas = Properties.Resources.Horas.ToString();
            this.horas = horas.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
    
}
