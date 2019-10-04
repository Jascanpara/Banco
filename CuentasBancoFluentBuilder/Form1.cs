using CuentasBancoFluentBuilder.Builder;
using CuentasBancoFluentBuilder.Dato;
using CuentasBancoFluentBuilder.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasBancoFluentBuilder
{
    public partial class Form1 : Form
    {
        DataTable Tabla;
        Dato.Usuario Dato = new Dato.Usuario();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();
        }

        private void TextBoxNumeroCuenta_TextChanged(object sender, EventArgs e)
        {
            //Validar.SoloNumeros(e);
        }

        private void TextBoxPropietario_TextChanged(object sender, EventArgs e)
        {
            //Validar.SoloLetras(e);
        }

        private void TextBoxTasa_TextChanged(object sender, EventArgs e)
        {
            //Validar.SoloDecimal(e);
        }

        private void TextBoxSaldoInicial_TextChanged(object sender, EventArgs e)
        {
            //Validar.SoloNumeros(e);
        }

        private void ComboBoxtipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Iniciar()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("NumCuenta");
            Tabla.Columns.Add("Propietario");
            Tabla.Columns.Add("Tasa");
            Tabla.Columns.Add("SaldoInicial");
            Tabla.Columns.Add("TipoCuenta");
            //Tabla.Columns.Add("Eliminar");
            grilla.DataSource = Tabla;
        }

        private void Guardar()
        {
            /* Modelo.UsuarioModel modelo = new Modelo.UsuarioModel() {
                 NumeroCuenta = int.Parse(textBoxNumeroCuenta.Text),
                 Propietario = textBoxPropietario.Text,
                 Tasa = int.Parse(textBoxTasa.Text),
                 SaldoInicial = int.Parse(textBoxSaldoInicial.Text),
                // TipoCuenta = comboBoxtipoCuenta.Text
             };*/

            CuentaEnum tipo;
            Enum.TryParse<CuentaEnum>(comboBoxtipoCuenta.Text, out tipo);
            var modelo = CuentaBuilder.CrearCuenta(tipo).NumeroCuenta(int.Parse(textBoxNumeroCuenta.Text)).Propietario(textBoxPropietario.Text).Tasa(int.Parse(textBoxTasa.Text)).SaldoInicial(int.Parse(textBoxSaldoInicial.Text)).Crear();
            Dato.Guardar(modelo);
        }

        private void Consultar()
        {
            foreach (var item in Dato.Consultar())
            {
                DataRow fila = Tabla.NewRow();
                fila["NumCuenta"] = item.NumeroCuenta;
                fila["Propietario"] = item.Propietario;
                fila["Tasa"] = item.Tasa;
                fila["SaldoInicial"] = item.SaldoInicial;
                fila["TipoCuenta"] = item.TipoCuenta;
                Tabla.Rows.Add(fila);
            }
        }

        private void Limpiar()
        {
            textBoxNumeroCuenta.Text = "";
            textBoxPropietario.Text = "";
            textBoxTasa.Text = "";
            textBoxSaldoInicial.Text = "";
            comboBoxtipoCuenta.Text = "";
        }
    }
}
