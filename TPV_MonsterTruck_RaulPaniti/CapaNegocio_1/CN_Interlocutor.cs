using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Interlocutor
    {
        private CD_Interlocutor object_Interlocutor = new CD_Interlocutor();
        public List<Interlocutor> Listar()
        {
            return object_Interlocutor.Listar();
        }

        public List<Interlocutor> ListarDataGrid()
        {
            return object_Interlocutor.ListarDataGrid();
        }
        public bool Eliminar(Interlocutor obj)
        {
            return object_Interlocutor.Eliminar(obj);
        }

        public bool Editar(Interlocutor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Interlocutor\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesaria la direccion del Interlocutor\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Interlocutor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return object_Interlocutor.Editar(obj, out Mensaje);
            }
        }

        public int Registrar(Interlocutor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Interlocutor\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesaria la direccion del Interlocutor\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Interlocutor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return object_Interlocutor.Registrar(obj, out Mensaje);
            }
        }
    }
    }

