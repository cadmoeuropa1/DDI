using System;

namespace DAM2_Raul_Paniti_Ejercicio_2
{
    partial class Bebida {
            String nombre;
            float precio;
            public Bebida(String nombre, float precio)
            {
                this.nombre = nombre;
                this.precio = precio;
            }
            public override string ToString()
            {
                String visualizar = nombre + "     " + precio + "€";
                return visualizar;
            }
        public String getNombre()
        {
            return nombre;
        }
        public float getPrecio()
        {
            return precio;
        }
        }
    } 

