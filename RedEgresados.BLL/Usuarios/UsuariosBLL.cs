using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedEgresados.DAL;

namespace RedEgresados.BLL
{
    public class UsuariosBLL
    {
        Usuarios usuarios = new Usuarios();
        UsuariosDAL usuarioDal = new UsuariosDAL();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuariosBo"></param>
        /// <returns></returns>
        public Usuarios ObtenerListaUsuario(UsuariosBO usuariosBo)
        {
            usuarios = usuarioDal.ObtenerListaUsuarios(usuariosBo);
            return usuarios;

        }
    }
}
