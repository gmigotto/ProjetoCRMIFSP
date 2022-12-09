using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace projeto_pratico
{
    public partial class TelaProposta : Form
    {
        int Id = -1;
        public TelaProposta()
        {
            InitializeComponent();
        }

        public void AtualizarListView()
        {
            //listView1.Items.Clear();
            PropostaDAO usuarioDao = new PropostaDAO();

            List<Proposta> usuarios = usuarioDao.ListarPropostas();
            if (usuarios.Count > 0)
            {
                foreach (var proposta in usuarios)
                {
                    ListViewItem lv = new ListViewItem(proposta.Id.ToString());
                  
                    //lv.SubItems.Add(proposta.Vendedores.ToString());
                    //lv.SubItems.Add(proposta.Clientes.ToString());
                    lv.SubItems.Add(proposta.Qtde.ToString());
                    //lv.SubItems.Add(proposta.Descricao.ToString());
                    lv.SubItems.Add(proposta.Valor_Uni.ToString());
                    //lv.SubItems.Add(proposta.Status_proposta.ToString());
                    

                  //  listView1.Items.Add(lv);
                }
            }
        }


        public void CADASTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                Proposta proposta = new Proposta(VendedorBox.TabIndex, ClienteBox.TabIndex, qtdeBox.Text, descBox.TabIndex,
                valorBox.Text, statusBox.TabIndex) ;

                PropostaDAO propostainserir = new PropostaDAO();

                propostainserir.Inserir(proposta);
                MessageBox.Show("Proposta cadastrado com sucesso!");

               // AtualizarListView();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaVendedor vendedorscreen = new TelaVendedor();
            this.Visible = false;
            vendedorscreen.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

          public void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cRMIFSPDataSet5.Posicao'. Você pode movê-la ou removê-la conforme necessário.
            this.posicaoTableAdapter.Fill(this.cRMIFSPDataSet5.Posicao);
            // TODO: esta linha de código carrega dados na tabela 'cRMIFSPDataSet4.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.cRMIFSPDataSet4.Produtos);
            // TODO: esta linha de código carrega dados na tabela 'cRMIFSPDataSet3.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.cRMIFSPDataSet3.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'cRMIFSPDataSet2.Propostas'. Você pode movê-la ou removê-la conforme necessário.
           // this.propostasTableAdapter.Fill(this.cRMIFSPDataSet2.Propostas);
            // TODO: esta linha de código carrega dados na tabela 'cRMIFSPDataSet.Vendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.vendedorTableAdapter.Fill(this.cRMIFSPDataSet.Vendedor);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void editarbutton_Click(object sender, EventArgs e)
        {

            try
            {
                Proposta proposta = new Proposta(VendedorBox.TabIndex, ClienteBox.TabIndex, qtdeBox.Text, descBox.TabIndex,
               valorBox.Text, statusBox.TabIndex);

                PropostaDAO propostainserir = new PropostaDAO();

                propostainserir.Atualizar(proposta);
                MessageBox.Show("Proposta cadastrado com sucesso!");

              
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

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
                        new PropostaDAO().Excluir(Id);
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

        private void descBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            Form2 homescreen = new Form2();
            this.Visible = false;
            homescreen.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1  clientescreen = new Form1();
            this.Visible = false;
            clientescreen.ShowDialog();
        }
    }
    
}
