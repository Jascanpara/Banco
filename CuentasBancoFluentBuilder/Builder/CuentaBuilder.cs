using CuentasBancoFluentBuilder.Dato;
using CuentasBancoFluentBuilder.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasBancoFluentBuilder.Builder
{
    public class CuentaBuilder
    {
        private readonly UsuarioModel _usuario;

        public static CuentaBuilder CrearCuenta(CuentaEnum tipoCuenta)
        {
            return new CuentaBuilder(tipoCuenta);
        }

        public CuentaBuilder NumeroCuenta(int numeroCuenta)
        {
            _usuario.NumeroCuenta = numeroCuenta;
            return this;
        }

        public CuentaBuilder Propietario(string propietario)
        {
            _usuario.Propietario = propietario;
            return this;
        }
        public CuentaBuilder Tasa(int tasa)
        {
            _usuario.Tasa = tasa;
            return this;
        }
        public CuentaBuilder SaldoInicial(int saldoInicial)
        {
            _usuario.SaldoInicial = saldoInicial;
            return this;
        }
        private CuentaBuilder(CuentaEnum tipoCuenta)
        {
            _usuario = new UsuarioModel { TipoCuenta = tipoCuenta };
        }

        public UsuarioModel Crear()
        {
            return _usuario;
        }
    }
}
