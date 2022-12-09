using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_pratico
{
    public partial class Form1 : Form
    {
        private int Id = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void AtualizarListView()
        {
            listView2.Items.Clear();
            ClienteDAO usuarioDao = new ClienteDAO();

            List<Cliente> usuarios = usuarioDao.ListarTodosClientes();
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.CNPJ);
                    lv.SubItems.Add(user.Endereco);
                    lv.SubItems.Add(user.UF);
                    lv.SubItems.Add(user.Telefone);
                    lv.SubItems.Add(user.Ramal);
                    listView2.Items.Add(lv);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaComprador compradorscreen = new TelaComprador();
            this.Visible = false;
            compradorscreen.ShowDialog();

        } 

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
     

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(Id, empresa.Text, cnpjbox.Text, endbox.Text, ufbox.Text, telbox.Text, ramalbox.Text);

                ClienteDAO clienteinserir = new ClienteDAO();

                clienteinserir.Inserir(cliente);
                MessageBox.Show("Cliente: " + cliente.Nome + " cadastrado com sucesso!");
                Limpartxb();
                AtualizarListView();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void Limpartxb()
        {
            empresa.Clear(); 
            cnpjbox.Clear();
            telbox.Clear();
            ramalbox.Clear();
            endbox.Clear();
            

        }
        private void button15_Click(object sender, EventArgs e)
        {
            Limpartxb();
        }

        private void Carregarpagina(object sender, EventArgs e)
        {
            try
            {
                AtualizarListView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
       
        
 

        private void button14_Click(object sender, EventArgs e)
        {
            TelaProposta propostascreen = new TelaProposta();
            this.Visible = false;
            propostascreen.ShowDialog();

        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (Id != -1)
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        new ClienteDAO().Excluir(Id);
                    }

                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Aviso de erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    AtualizarListView();
                }
            }
            else
            {
                MessageBox.Show("Erro! nada selecionado...");
            }
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView2.FocusedItem.Index;
            

            try
            {
                Cliente cliente = new Cliente
                (
                    Id = int.Parse(listView2.Items[index].SubItems[0].Text),
                    empresa.Text = listView2.Items[index].SubItems[1].Text,
                    cnpjbox.Text = listView2.Items[index].SubItems[2].Text,
                    endbox.Text = listView2.Items[index].SubItems[3].Text,
                    ufbox.Text = listView2.Items[index].SubItems[4].Text,
                    telbox.Text = listView2.Items[index].SubItems[5].Text,
                    ramalbox.Text = listView2.Items[index].SubItems[6].Text

                );




            }
            catch (Exception erro)
            {
                MessageBox.Show("Selecione uma linha>" + Id.ToString() + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(Id, empresa.Text, cnpjbox.Text, endbox.Text, ufbox.Text, telbox.Text, ramalbox.Text);

                ClienteDAO clienteatual = new ClienteDAO();

                clienteatual.Atualizar(cliente);
                MessageBox.Show("Cliente: " + cliente.Nome + " alterado com sucesso!");
                Limpartxb();
                AtualizarListView();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void limpar_vendedor_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            TelaVendedor vendedorscreen = new TelaVendedor();
            this.Visible = false;
            vendedorscreen.ShowDialog();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form2 homescreen = new Form2();
            this.Visible = false;
            homescreen.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
