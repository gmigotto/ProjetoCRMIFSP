using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto_pratico
{
    public partial class TelaVendedor : Form
    {
        private int Id = -1;
        public TelaVendedor()
        {
            InitializeComponent();
        }


       

        private void AtualizarListView()
        {
            listView1.Items.Clear();
            VendedorDAO usuarioDao = new VendedorDAO();

            List<Vendedor> usuarios = usuarioDao.ListarTodosVendedores();
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Nascimento);
                    lv.SubItems.Add(user.Telefone);
                    lv.SubItems.Add(user.CPF);
                    lv.SubItems.Add(user.Endereco);
                    lv.SubItems.Add(user.Email);
                    lv.SubItems.Add(user.Senha);
                    listView1.Items.Add(lv);
                }
            }
        }


        private void Limpartxb()
        {
            txbNome.Clear();
            dt_nascimento.Clear();
            cpf_vendedor.Clear();
            telefone_vendedor.Clear();
            tbxEnd.Clear();
            email_vendedor.Clear();
            senha.Clear();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Vendedor vendedor = new Vendedor(txbNome.Text, dt_nascimento.Text, telefone_vendedor.Text, cpf_vendedor.Text,
                tbxEnd.Text, email_vendedor.Text, senha.Text);

                VendedorDAO vendedorinserir = new VendedorDAO();

                vendedorinserir.Inserir(vendedor);
                MessageBox.Show("Vendedor: " + vendedor.Nome + " cadastrado com sucesso!");
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
            Limpartxb();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            Form4 homescreen = new Form4();
            this.Visible = false;
            homescreen.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txb_nomevendedor_TextChanged(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaProposta propostascreen = new TelaProposta();
            this.Visible = false;
            propostascreen.ShowDialog();
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
       

            try
            {
                Vendedor vendedor = new Vendedor
                (
                    Id = int.Parse(listView1.Items[index].SubItems[0].Text),
                    txbNome.Text = listView1.Items[index].SubItems[1].Text,
                    dt_nascimento.Text = listView1.Items[index].SubItems[2].Text,
                    telefone_vendedor.Text = listView1.Items[index].SubItems[3].Text,
                    cpf_vendedor.Text = listView1.Items[index].SubItems[4].Text,
                    tbxEnd.Text = listView1.Items[index].SubItems[5].Text,
                    email_vendedor.Text = listView1.Items[index].SubItems[6].Text,
                    senha.Text = listView1.Items[index].SubItems[7].Text

                );


                

            }
            catch (Exception erro)
            {
                MessageBox.Show("Selecione uma linha>" + Id.ToString() + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Id != -1)
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        new VendedorDAO().Excluir(Id);
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Vendedor vendedor = new Vendedor(Id ,txbNome.Text, dt_nascimento.Text, telefone_vendedor.Text, cpf_vendedor.Text,
                tbxEnd.Text, email_vendedor.Text, senha.Text);

                VendedorDAO vendedoratual = new VendedorDAO();

                vendedoratual.Atualizar(vendedor);
                MessageBox.Show("Vendedor: " + vendedor.Nome + " alterado com sucesso!");
                Limpartxb();
                AtualizarListView();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AtualizarListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 clientescreen = new Form1();
            this.Visible = false;
            clientescreen.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}



