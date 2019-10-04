namespace CuentasBancoFluentBuilder
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumCuenta = new System.Windows.Forms.Label();
            this.Propietario = new System.Windows.Forms.Label();
            this.Tasa = new System.Windows.Forms.Label();
            this.SaldoInicial = new System.Windows.Forms.Label();
            this.TipoCuenta = new System.Windows.Forms.Label();
            this.textBoxNumeroCuenta = new System.Windows.Forms.TextBox();
            this.textBoxPropietario = new System.Windows.Forms.TextBox();
            this.textBoxTasa = new System.Windows.Forms.TextBox();
            this.textBoxSaldoInicial = new System.Windows.Forms.TextBox();
            this.comboBoxtipoCuenta = new System.Windows.Forms.ComboBox();
            this.buttongenerarCuenta = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.labelListadoCuentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // NumCuenta
            // 
            this.NumCuenta.AutoSize = true;
            this.NumCuenta.Location = new System.Drawing.Point(41, 42);
            this.NumCuenta.Name = "NumCuenta";
            this.NumCuenta.Size = new System.Drawing.Size(125, 17);
            this.NumCuenta.TabIndex = 0;
            this.NumCuenta.Text = "Numero de cuenta";
            // 
            // Propietario
            // 
            this.Propietario.AutoSize = true;
            this.Propietario.Location = new System.Drawing.Point(41, 80);
            this.Propietario.Name = "Propietario";
            this.Propietario.Size = new System.Drawing.Size(77, 17);
            this.Propietario.TabIndex = 1;
            this.Propietario.Text = "Propietario";
            // 
            // Tasa
            // 
            this.Tasa.AutoSize = true;
            this.Tasa.Location = new System.Drawing.Point(41, 118);
            this.Tasa.Name = "Tasa";
            this.Tasa.Size = new System.Drawing.Size(40, 17);
            this.Tasa.TabIndex = 2;
            this.Tasa.Text = "Tasa";
            // 
            // SaldoInicial
            // 
            this.SaldoInicial.AutoSize = true;
            this.SaldoInicial.Location = new System.Drawing.Point(41, 158);
            this.SaldoInicial.Name = "SaldoInicial";
            this.SaldoInicial.Size = new System.Drawing.Size(83, 17);
            this.SaldoInicial.TabIndex = 3;
            this.SaldoInicial.Text = "Saldo inicial";
            // 
            // TipoCuenta
            // 
            this.TipoCuenta.AutoSize = true;
            this.TipoCuenta.Location = new System.Drawing.Point(41, 197);
            this.TipoCuenta.Name = "TipoCuenta";
            this.TipoCuenta.Size = new System.Drawing.Size(103, 17);
            this.TipoCuenta.TabIndex = 4;
            this.TipoCuenta.Text = "Tipo de cuenta";
            // 
            // textBoxNumeroCuenta
            // 
            this.textBoxNumeroCuenta.AcceptsReturn = true;
            this.textBoxNumeroCuenta.Location = new System.Drawing.Point(227, 36);
            this.textBoxNumeroCuenta.Name = "textBoxNumeroCuenta";
            this.textBoxNumeroCuenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNumeroCuenta.ShortcutsEnabled = false;
            this.textBoxNumeroCuenta.Size = new System.Drawing.Size(204, 22);
            this.textBoxNumeroCuenta.TabIndex = 5;
            this.textBoxNumeroCuenta.TextChanged += new System.EventHandler(this.TextBoxNumeroCuenta_TextChanged);
            // 
            // textBoxPropietario
            // 
            this.textBoxPropietario.Location = new System.Drawing.Point(227, 80);
            this.textBoxPropietario.Name = "textBoxPropietario";
            this.textBoxPropietario.Size = new System.Drawing.Size(204, 22);
            this.textBoxPropietario.TabIndex = 6;
            this.textBoxPropietario.TextChanged += new System.EventHandler(this.TextBoxPropietario_TextChanged);
            // 
            // textBoxTasa
            // 
            this.textBoxTasa.Location = new System.Drawing.Point(227, 118);
            this.textBoxTasa.Name = "textBoxTasa";
            this.textBoxTasa.Size = new System.Drawing.Size(204, 22);
            this.textBoxTasa.TabIndex = 7;
            this.textBoxTasa.TextChanged += new System.EventHandler(this.TextBoxTasa_TextChanged);
            // 
            // textBoxSaldoInicial
            // 
            this.textBoxSaldoInicial.Location = new System.Drawing.Point(227, 158);
            this.textBoxSaldoInicial.Name = "textBoxSaldoInicial";
            this.textBoxSaldoInicial.Size = new System.Drawing.Size(204, 22);
            this.textBoxSaldoInicial.TabIndex = 8;
            this.textBoxSaldoInicial.TextChanged += new System.EventHandler(this.TextBoxSaldoInicial_TextChanged);
            // 
            // comboBoxtipoCuenta
            // 
            this.comboBoxtipoCuenta.FormattingEnabled = true;
            this.comboBoxtipoCuenta.Items.AddRange(new object[] {
            "Platinium",
            "Basic",
            "Golden",
            "Black"});
            this.comboBoxtipoCuenta.Location = new System.Drawing.Point(227, 197);
            this.comboBoxtipoCuenta.Name = "comboBoxtipoCuenta";
            this.comboBoxtipoCuenta.Size = new System.Drawing.Size(204, 24);
            this.comboBoxtipoCuenta.TabIndex = 9;
            this.comboBoxtipoCuenta.SelectedIndexChanged += new System.EventHandler(this.ComboBoxtipoCuenta_SelectedIndexChanged);
            // 
            // buttongenerarCuenta
            // 
            this.buttongenerarCuenta.Location = new System.Drawing.Point(227, 252);
            this.buttongenerarCuenta.Name = "buttongenerarCuenta";
            this.buttongenerarCuenta.Size = new System.Drawing.Size(204, 23);
            this.buttongenerarCuenta.TabIndex = 10;
            this.buttongenerarCuenta.Text = "Generar Cuenta";
            this.buttongenerarCuenta.UseVisualStyleBackColor = true;
            this.buttongenerarCuenta.Click += new System.EventHandler(this.Button1_Click);
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(44, 334);
            this.grilla.Name = "grilla";
            this.grilla.RowTemplate.Height = 24;
            this.grilla.Size = new System.Drawing.Size(1050, 186);
            this.grilla.TabIndex = 11;
            this.grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // labelListadoCuentas
            // 
            this.labelListadoCuentas.AutoSize = true;
            this.labelListadoCuentas.Location = new System.Drawing.Point(44, 311);
            this.labelListadoCuentas.Name = "labelListadoCuentas";
            this.labelListadoCuentas.Size = new System.Drawing.Size(200, 17);
            this.labelListadoCuentas.TabIndex = 12;
            this.labelListadoCuentas.Text = "Listado de cuentas generadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 527);
            this.Controls.Add(this.labelListadoCuentas);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.buttongenerarCuenta);
            this.Controls.Add(this.comboBoxtipoCuenta);
            this.Controls.Add(this.textBoxSaldoInicial);
            this.Controls.Add(this.textBoxTasa);
            this.Controls.Add(this.textBoxPropietario);
            this.Controls.Add(this.textBoxNumeroCuenta);
            this.Controls.Add(this.TipoCuenta);
            this.Controls.Add(this.SaldoInicial);
            this.Controls.Add(this.Tasa);
            this.Controls.Add(this.Propietario);
            this.Controls.Add(this.NumCuenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumCuenta;
        private System.Windows.Forms.Label Propietario;
        private System.Windows.Forms.Label Tasa;
        private System.Windows.Forms.Label SaldoInicial;
        private System.Windows.Forms.Label TipoCuenta;
        private System.Windows.Forms.TextBox textBoxNumeroCuenta;
        private System.Windows.Forms.TextBox textBoxPropietario;
        private System.Windows.Forms.TextBox textBoxTasa;
        private System.Windows.Forms.TextBox textBoxSaldoInicial;
        private System.Windows.Forms.ComboBox comboBoxtipoCuenta;
        private System.Windows.Forms.Button buttongenerarCuenta;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Label labelListadoCuentas;
    }
}

