using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {
            if (NombretextBox.Text == "")
            {
                errorProvider1.SetError(NombretextBox, "ingrese el Nombre del estudiante");
                return;
            }
            if (PrimerParcialtextBox.Text == "")
            {
                errorProvider1.SetError(PrimerParcialtextBox, "ingrese un valor");
                return;
            }
            if (SegundotextBox.Text == "")
            {
                errorProvider1.SetError(SegundotextBox, "ingrese un valor");
                return;
            }
            if (TercerotextBox.Text == "")
            {
                errorProvider1.SetError(TercerotextBox, "ingrese un valor");
                return;
            }
            if (CuartotextBox.Text == "")
            {
                errorProvider1.SetError(CuartotextBox, "ingrese un valor");
                return;
            }
            errorProvider1.Clear();
            decimal primer = Convert.ToDecimal(PrimerParcialtextBox.Text);
            decimal segundo = Convert.ToDecimal(SegundotextBox.Text);
            decimal tercer = Convert.ToDecimal(TercerotextBox.Text);
            decimal cuarto = Convert.ToDecimal(CuartotextBox.Text);

            decimal Total = await Calcula_PromedioAsync(primer, segundo, tercer, cuarto);

            MessageBox.Show("El promedio del alumno: "+ NombretextBox.Text +" es: "+ Math.Round(Total));
        }

        private async Task <decimal> Calcula_PromedioAsync ( decimal Nota1, decimal Nota2, decimal Nota3, decimal Nota4)
        {
            decimal Calculo = await Task.Run(() =>
            {
                return  (Nota1 + Nota2 + Nota3 +Nota4) / 4;
            });

            return Calculo;
           
        }

        private void PrimerParcialtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void SegundotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TercerotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void CuartotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
