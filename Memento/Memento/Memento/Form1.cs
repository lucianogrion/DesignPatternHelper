using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Memento
{
    public partial class Form1 : Form
    {
        GuardianMemoria g;
        public Form1()
        {
            InitializeComponent();
            g = new GuardianMemoria();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            ProspectoVentas pv = new ProspectoVentas();
            pv.Nombre = txtName.Text;
            pv.Telefono = txtPhone.Text;
            int budget=0;
            if (!int.TryParse(txtBudget.Text,out budget)){
                budget = 0;
            }

            pv.Gasto = budget;
            g.Mement = pv.GuardarMemento();
        }

        private void cmdRestaurar_Click(object sender, EventArgs e)
        {
            ProspectoVentas pv = new ProspectoVentas();
            pv.RetornarEstado(g.Mement);

            txtName.Text =pv.Nombre ;
            txtPhone.Text = pv.Telefono;
            txtBudget.Text = pv.Gasto.ToString();
        }
    }
}