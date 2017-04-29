using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pico_Placa
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            txtfecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txthora.Text = DateTime.Now.ToString("HH:mm");
            
        }
        
        private void cmddisponibilidad_Click(object sender, EventArgs e)
        {
            pico_placa pp = new pico_placa(txtplaca.Text, txtfecha.Text, txthora.Text);
            if (pp.verificarDatosPlaca())
            {
                if (pp.verificarFechaHora())
                {
                    if (pp.verificarRoad())
                    {
                        MessageBox.Show("El carro SI puede circular en la fecha y hora escogida", "Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);                        
                    }
                    else
                    {
                        MessageBox.Show("El carro NO puede circular en la fecha y hora escogida", "Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Error en fecha y/o hora ingresada", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error en placa ingresada", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void txtplaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtplaca.Text.Length > 2)
            {                
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);                
            }
            else
            {                
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);             
            }

        } 
    }
}
