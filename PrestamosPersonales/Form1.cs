using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer;

namespace PrestamosPersonales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltasaInteres_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxTipPres();
            LoadComboBoxCantMeses();
            
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularPestamo();
        }
       
        private void Tasa()
        {
            {
                ComboBoxItem SelecciondeTipo = cbTipoPrestamo.SelectedItem as ComboBoxItem;
                if (SelecciondeTipo.value == null ) return ;

                if ((int)enumTipPres.Personal ==(int) SelecciondeTipo.value)
                {

                    TxtTasaInteres.Text = "22%";
                }
                else if ((int)enumTipPres.Automóvil == (int)SelecciondeTipo.value)
                {
                    TxtTasaInteres.Text = "12%";
                }
                else if ((int)enumTipPres.Hipotecario == (int)SelecciondeTipo.value)
                {

                    TxtTasaInteres.Text = "8%";
                }
                else
                {
                    TxtTasaInteres.Text = "wawawa";
                }
            }
        }
        private void CalcularPestamo()
        {
            try
            {
                ComboBoxItem SelecciondeTipo = cbTipoPrestamo.SelectedItem as ComboBoxItem;
                ComboBoxItem SeleccionMeses = cbCantMeses.SelectedItem as ComboBoxItem;

                if (SelecciondeTipo.value == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de prestamo");
                }
                else if (SeleccionMeses.value == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de prestamo");
                }
                else if (string.IsNullOrEmpty(TxtMontoPrestamo.Text))
                {
                    MessageBox.Show("Debe agregar la cantidad de meses");
                }
                else
                {
                    CalcularTasa prestamo = new CalcularTasa();
                    int TipoDePrestamo = (int)SelecciondeTipo.value;
                    int TiempoEnMeses = (int)SeleccionMeses.value;
                    int cantidad = Convert.ToInt32(TxtMontoPrestamo.Text);
                    double resultado = prestamo.CalcularPres(TipoDePrestamo, TiempoEnMeses, cantidad);

                    TxtResultado.Text = resultado.ToString();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Agregue un valor numerico");
            }
        }
        public void LoadComboBoxTipPres()
        {
            ComboBoxItem opcionPorDefecto = new ComboBoxItem();
            opcionPorDefecto.text = "Seleccione una Opcion";
            opcionPorDefecto.value = null;

            ComboBoxItem TipPersonal = new ComboBoxItem();
            TipPersonal.text = "Personal";
            TipPersonal.value = 1;

            ComboBoxItem TipAutomóvil = new ComboBoxItem();
            TipAutomóvil.text = "Automóvil";
            TipAutomóvil.value = 2;

            ComboBoxItem TipHipotecario = new ComboBoxItem();
            TipHipotecario.text = "Hipotecario";
            TipHipotecario.value = 3;

            cbTipoPrestamo.Items.Add(opcionPorDefecto);
            cbTipoPrestamo.Items.Add(TipPersonal);
            cbTipoPrestamo.Items.Add(TipAutomóvil);
            cbTipoPrestamo.Items.Add(TipHipotecario);
            cbTipoPrestamo.SelectedItem = opcionPorDefecto;
        }
        public void LoadComboBoxCantMeses()
        {
            ComboBoxItem opcionPorDefecto = new ComboBoxItem();
            opcionPorDefecto.text = "Seleccione una Opcion";
            opcionPorDefecto.value = null;
            cbCantMeses.Items.Add(opcionPorDefecto);

            var i = 6;
            int b = 6;
            while (i <= 120)
            {
                ComboBoxItem Meses = new ComboBoxItem();

                Meses.text = $"{i} Meses";
                Meses.value = b;
                int Cat = b;

                i += 6;
                b += 6;
                cbCantMeses.Items.Add(Meses);
            }

            cbCantMeses.SelectedItem = opcionPorDefecto;

            ComboBoxItem ultimo = new ComboBoxItem();
            ultimo.text = $"120 Meses";
            ultimo.value = 120;
            cbCantMeses.Items.Add(ultimo);

        }

        private void cbCantMeses_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtTasaInteres_ReadOnlyChanged(object sender, EventArgs e)
        {
           
        }

        private void cbTipoPrestamo_SelectedValueChanged(object sender, EventArgs e)
        {
            Tasa();
        }
    }
}

