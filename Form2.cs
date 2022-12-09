using CRMIFSP.Utils;
using projeto_pratico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace projeto_pratico
{
    public partial class Form2 : Form

    {
        int ID = -1;
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }

        public Form2()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
            InitializeComponent();
        }

        
        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

  
private bool validaDados()
{
       
           // string stringConnection = @"Data Source=" + Environment.MachineName +
             //   @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security=true";
       
           
    Cmd.Connection = Con.ReturnConnection();
    Cmd.CommandText = @"SELECT Email_vendedor = @Email_vendedor, Senha_vendedor = @Senha_vendedor FROM VENDEDOR WHERE  id_vendedor = @ID ";
    Cmd.Parameters.Add("@Email_vendedor", SqlDbType.Text).Value = userBox.Text;
    Cmd.Parameters.Add("@Senha_vendedor", SqlDbType.Text).Value = senhaBox.Text;
  




            if (ID < 0)
                {
                   
                    MessageBox.Show("Usuario/Senha Invalido.");
                    userBox.Focus();
                }

          
                else
               {
                VendedorDAO vendedorautenticado = new VendedorDAO();
          
                 this.Close();
               }

                Con.CloseConnection();
                return true;
}
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 homescreen = new Form4();
            this.Visible = false;
            homescreen.ShowDialog();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
