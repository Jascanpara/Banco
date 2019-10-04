using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasBancoFluentBuilder.Modelo
{
    public class UsuarioModel
    {
        public int NumeroCuenta { get; set; }
        public string Propietario { get; set; }
        public int Tasa { get; set; }
        public int SaldoInicial { get; set; }

        public CuentaEnum TipoCuenta { get; set; }

    }
}
