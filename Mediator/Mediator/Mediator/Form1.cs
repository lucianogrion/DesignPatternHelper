using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mediator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ConcreteMediator m;

        internal ConcreteMediator M
        {
            get { return m; }
            set { m = value; }
        }

        ConcreteColleague1 c1;
        ConcreteColleague2 c2;

        private void Form1_Load(object sender, EventArgs e)
        {
            M = new ConcreteMediator();
            c1 = new ConcreteColleague1(m);
            c2 = new ConcreteColleague2(m);

            M.Colleague1 = c1;
            M.Colleague2 = c2;
            

        }  

        private void cmdSend1_Click(object sender, EventArgs e)
        {
            txtMediator.Text = txtMediator.Text + M.Send(txtSend1.Text, c2) + "\r\n";
            //txtMediator.Text = txtMediator.Text + Mi.Colleague2.Send(txtSend1.Text) + "\f";
        }

        private void cmdSend2_Click(object sender, EventArgs e)
        {
            txtMediator.Text = txtMediator.Text + M.Send(txtSend2.Text, c1) + "\r\n";
            //txtMediator.Text = txtMediator.Text + Mi.Colleague1.Send(txtSend2.Text) + "\f";
        }
    }
}