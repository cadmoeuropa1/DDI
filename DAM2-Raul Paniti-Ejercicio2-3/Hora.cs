using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_Raul_Paniti_Ejercicio2_3
{
    public class Hora
    {
        public String hora;
        public Boolean reservado;
        public Hora(String hora, Boolean reservado)
        {
            this.hora = hora;
            this.reservado = reservado;
        }
        public override string ToString()
        {
            if (this.reservado)
            {
                return this.hora + " " + "Reservado";
            }
            else
            {
                return this.hora + " " + "Disponible";
            }
        }
    }
}
