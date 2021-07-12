
namespace PrestamosPersonales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.lblMontPres = new System.Windows.Forms.Label();
            this.lblTipoPres = new System.Windows.Forms.Label();
            this.cbTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.lbltasaInteres = new System.Windows.Forms.Label();
            this.TxtTasaInteres = new System.Windows.Forms.TextBox();
            this.lblCantMeses = new System.Windows.Forms.Label();
            this.cbCantMeses = new System.Windows.Forms.ComboBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.lblMensajeAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtMontoPrestamo
            // 
            this.TxtMontoPrestamo.Location = new System.Drawing.Point(213, 82);
            this.TxtMontoPrestamo.Name = "TxtMontoPrestamo";
            this.TxtMontoPrestamo.Size = new System.Drawing.Size(229, 23);
            this.TxtMontoPrestamo.TabIndex = 0;
            this.TxtMontoPrestamo.TextChanged += new System.EventHandler(this.label1_Click);
            // 
            // lblMontPres
            // 
            this.lblMontPres.AutoSize = true;
            this.lblMontPres.Location = new System.Drawing.Point(89, 85);
            this.lblMontPres.Name = "lblMontPres";
            this.lblMontPres.Size = new System.Drawing.Size(118, 15);
            this.lblMontPres.TabIndex = 1;
            this.lblMontPres.Text = "Monto del prestamo:";
            // 
            // lblTipoPres
            // 
            this.lblTipoPres.AutoSize = true;
            this.lblTipoPres.Location = new System.Drawing.Point(105, 125);
            this.lblTipoPres.Name = "lblTipoPres";
            this.lblTipoPres.Size = new System.Drawing.Size(102, 15);
            this.lblTipoPres.TabIndex = 1;
            this.lblTipoPres.Text = "Tipo de prestamo:";
            // 
            // cbTipoPrestamo
            // 
            this.cbTipoPrestamo.FormattingEnabled = true;
            this.cbTipoPrestamo.Location = new System.Drawing.Point(213, 122);
            this.cbTipoPrestamo.Name = "cbTipoPrestamo";
            this.cbTipoPrestamo.Size = new System.Drawing.Size(229, 23);
            this.cbTipoPrestamo.TabIndex = 2;
            this.cbTipoPrestamo.SelectedValueChanged += new System.EventHandler(this.cbTipoPrestamo_SelectedValueChanged);
            // 
            // lbltasaInteres
            // 
            this.lbltasaInteres.AutoSize = true;
            this.lbltasaInteres.Location = new System.Drawing.Point(100, 164);
            this.lbltasaInteres.Name = "lbltasaInteres";
            this.lbltasaInteres.Size = new System.Drawing.Size(107, 15);
            this.lbltasaInteres.TabIndex = 1;
            this.lbltasaInteres.Text = "Tasa de interés (%):";
            this.lbltasaInteres.Click += new System.EventHandler(this.lbltasaInteres_Click);
            // 
            // TxtTasaInteres
            // 
            this.TxtTasaInteres.Location = new System.Drawing.Point(213, 161);
            this.TxtTasaInteres.Name = "TxtTasaInteres";
            this.TxtTasaInteres.ReadOnly = true;
            this.TxtTasaInteres.Size = new System.Drawing.Size(229, 23);
            this.TxtTasaInteres.TabIndex = 0;
            this.TxtTasaInteres.ReadOnlyChanged += new System.EventHandler(this.TxtTasaInteres_ReadOnlyChanged);
            // 
            // lblCantMeses
            // 
            this.lblCantMeses.AutoSize = true;
            this.lblCantMeses.Location = new System.Drawing.Point(105, 207);
            this.lblCantMeses.Name = "lblCantMeses";
            this.lblCantMeses.Size = new System.Drawing.Size(103, 15);
            this.lblCantMeses.TabIndex = 1;
            this.lblCantMeses.Text = "Cantida de meses:";
            this.lblCantMeses.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbCantMeses
            // 
            this.cbCantMeses.FormattingEnabled = true;
            this.cbCantMeses.Location = new System.Drawing.Point(213, 204);
            this.cbCantMeses.Name = "cbCantMeses";
            this.cbCantMeses.Size = new System.Drawing.Size(229, 23);
            this.cbCantMeses.TabIndex = 2;
            this.cbCantMeses.SelectedIndexChanged += new System.EventHandler(this.cbCantMeses_SelectedIndexChanged_1);
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTema.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTema.Location = new System.Drawing.Point(117, 9);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(325, 37);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Calculadora de prestamos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnCalcular.FlatAppearance.BorderSize = 3;
            this.btnCalcular.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(270, 244);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 35);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(69, 293);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(138, 17);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Su cuota mensual es:";
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(213, 290);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(229, 23);
            this.TxtResultado.TabIndex = 0;
            this.TxtResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMensajeAviso
            // 
            this.lblMensajeAviso.AutoSize = true;
            this.lblMensajeAviso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeAviso.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMensajeAviso.Location = new System.Drawing.Point(151, 46);
            this.lblMensajeAviso.Name = "lblMensajeAviso";
            this.lblMensajeAviso.Size = new System.Drawing.Size(260, 20);
            this.lblMensajeAviso.TabIndex = 4;
            this.lblMensajeAviso.Text = "Asegurese de llenar todos los campos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 378);
            this.Controls.Add(this.lblMensajeAviso);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbCantMeses);
            this.Controls.Add(this.cbTipoPrestamo);
            this.Controls.Add(this.lbltasaInteres);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblCantMeses);
            this.Controls.Add(this.lblTipoPres);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblMontPres);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtTasaInteres);
            this.Controls.Add(this.TxtMontoPrestamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CalculadoraDePrestamos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMontoPrestamo;
        private System.Windows.Forms.Label lblMontPres;
        private System.Windows.Forms.Label lblTipoPres;
        private System.Windows.Forms.ComboBox cbTipoPrestamo;
        private System.Windows.Forms.Label lbltasaInteres;
        private System.Windows.Forms.TextBox TxtTasaInteres;
        private System.Windows.Forms.Label lblCantMeses;
        private System.Windows.Forms.ComboBox cbCantMeses;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label lblMensajeAviso;
    }
}

