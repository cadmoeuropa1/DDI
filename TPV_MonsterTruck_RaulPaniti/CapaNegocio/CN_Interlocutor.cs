using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            throw new NotImplementedException();
        }
    }
}
