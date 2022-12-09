using CRMIFSP.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace projeto_pratico
{
    internal class VendedorDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public VendedorDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }


        public void Inserir(Vendedor vendedor)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Vendedor (Nome_vendedor, Dt_Nascimento, Tel_vendedor, CPF_vendedor, End_vendedor, Email_vendedor, Senha_vendedor)  VALUES (@Nome_vendedor, @Dt_Nascimento, @Tel_vendedor, @CPF_vendedor, @End_vendedor, @Email_vendedor, @Senha_vendedor)";


            Cmd.Parameters.AddWithValue("@Nome_vendedor", vendedor.Nome);
            Cmd.Parameters.AddWithValue("@Dt_Nascimento", vendedor.Nascimento);
            Cmd.Parameters.AddWithValue("@Tel_vendedor", vendedor.Telefone);
            Cmd.Parameters.AddWithValue("@CPF_vendedor", vendedor.CPF);
            Cmd.Parameters.AddWithValue("@End_vendedor", vendedor.Endereco);
            Cmd.Parameters.AddWithValue("@Email_vendedor", vendedor.Email);
            Cmd.Parameters.AddWithValue("@Senha_vendedor", vendedor.Senha);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao inserir usuário no banco de dados!\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public List<Vendedor> ListarTodosVendedores()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Vendedor";

            List<Vendedor> listaDeVendedores = new List<Vendedor>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Vendedor vendedor = new Vendedor((int)rd["id_vendedor"], (string)rd["Nome_vendedor"], (string)rd["Dt_Nascimento"], (string)rd["Tel_vendedor"], (string)rd["CPF_vendedor"], (string)rd["End_vendedor"], (string)rd["Email_vendedor"], (string)rd["Senha_vendedor"]);

                    listaDeVendedores.Add(vendedor);

                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return listaDeVendedores;

        }
        public void Atualizar(Vendedor vendedor)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Vendedor SET Nome_vendedor = @Nome, Dt_Nascimento = @Nascimento, Tel_vendedor = @Telefone, CPF_vendedor = @CPF, 
            End_vendedor = @Endereco, Email_vendedor = @Email, Senha_vendedor = @Senha WHERE id_vendedor = @Id";

            Cmd.Parameters.AddWithValue("@Id", vendedor.Id);
            Cmd.Parameters.AddWithValue("@Nome", vendedor.Nome);
            Cmd.Parameters.AddWithValue("@Nascimento", vendedor.Nascimento);
            Cmd.Parameters.AddWithValue("@Telefone", vendedor.Telefone);
            Cmd.Parameters.AddWithValue("@CPF", vendedor.CPF);
            Cmd.Parameters.AddWithValue("@Endereco", vendedor.Endereco);
            Cmd.Parameters.AddWithValue("@Email", vendedor.Email);
            Cmd.Parameters.AddWithValue("@Senha", vendedor.Senha);

            try
            {
                //Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas na atualização do banco de dados usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Excluir(int id_vendedor)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Vendedor WHERE id_vendedor = @Id";
            Cmd.Parameters.AddWithValue("@Id", id_vendedor);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

        }

        
    }

    
}
