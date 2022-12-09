using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_pratico
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaVendedor vendedorscreen = new TelaVendedor();
            this.Visible = false;
            vendedorscreen.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaProposta propostascreen = new TelaProposta();
            this.Visible = false;
            propostascreen.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 clientescreen = new Form1();
            this.Visible = false;
            clientescreen.ShowDialog();
        }
    }
}
