using MenuRelatorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuRelatorio.Controller
{
    public class UsuarioController
    {
        private VendasContext contextDV = new VendasContext();
        public UsuarioController()
        { }
        public List<Usuario> RetornaListaDeUsuario()
        {
            return contextDV.ListaDeUsuarios.ToList<Usuario>();
        }
        public bool LoginSistema(Usuario usuarios)
        {
            return RetornaListaDeUsuario()
                .Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);

        }


    }
}
