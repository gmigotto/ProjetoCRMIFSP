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
    public partial class TelaComprador : Form
    {
        public TelaComprador()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
       private void cadastro_vendedor_Click_2(object sender, EventArgs e)
       {
           TelaVendedor vendedorscreen = new TelaVendedor();
           this.Visible = false;
            vendedorscreen.ShowDialog();

        }

          private void cadastrar_comprador_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro Efetuado!");
          
        }

        private void Limpartxb()
        {
            nome_comprador.Clear();
            setor.Clear();
            cargo.Clear();
            ddd_comprador.Clear();
            telefone_comprador.Clear();
            ramal_comprador.Clear();
            email.Clear();


        }
        private void limpar_comprador_Click_2(object sender, EventArgs e)
        {
            Limpartxb();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
