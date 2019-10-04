using CuentasBancoFluentBuilder.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasBancoFluentBuilder.Dato
{
    public class Usuario
    {
        List<UsuarioModel> lista = new List<UsuarioModel>();

        //Guardar los usuarios
        public void Guardar(UsuarioModel modelo)
        {
            lista.Add(modelo);
        }

        //Consulta todos los usuarios

        public List<UsuarioModel> Consultar()
        {
            return lista;
        }
    }
}
