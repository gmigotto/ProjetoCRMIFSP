using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMIFSP.Utils;

namespace projeto_pratico
{
    internal class ClienteDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public ClienteDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }

        public void Inserir(Cliente cliente)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Clientes (Nome_cliente, CNPJ_cliente, End_cliente, UF_cliente, tel_cliente, Ramal_cliente) 
            VALUES (@Nome_cliente, @CNPJ_cliente, @End_cliente, @UF_cliente, @Tel_cliente, @Ramal_cliente)";


            Cmd.Parameters.AddWithValue("@Nome_cliente", cliente.Nome);
            Cmd.Parameters.AddWithValue("@CNPJ_cliente", cliente.CNPJ);
            Cmd.Parameters.AddWithValue("@End_cliente", cliente.Endereco);
            Cmd.Parameters.AddWithValue("@UF_cliente", cliente.UF);
            Cmd.Parameters.AddWithValue("@Tel_cliente", cliente.Telefone);
            Cmd.Parameters.AddWithValue("@Ramal_cliente", cliente.Ramal);

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

        public List<Cliente> ListarTodosClientes()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Clientes";

            List<Cliente> listaDeClientes = new List<Cliente>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Cliente cliente = new Cliente((int)rd["id_cliente"], (string)rd["Nome_cliente"], 
                        (string)rd["CNPJ_cliente"], (string)rd["End_cliente"], (string)rd["UF_cliente"], (string)rd["Tel_cliente"], (string)rd["Ramal_cliente"]);

                    listaDeClientes.Add(cliente);

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
            return listaDeClientes;

        }

        public void Atualizar(Cliente cliente)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Clientes SET Nome_cliente = @Nome, CNPJ_cliente = @CNPJ, End_cliente = @Endereco, 
            UF_cliente = @UF, tel_cliente = @Telefone, Ramal_cliente = @Ramal WHERE id_cliente = @Id";

            Cmd.Parameters.AddWithValue("@Id", cliente.Id);
            Cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            Cmd.Parameters.AddWithValue("@CNPJ", cliente.CNPJ);
            Cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            Cmd.Parameters.AddWithValue("@UF", cliente.UF);
            Cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            Cmd.Parameters.AddWithValue("@Ramal", cliente.Ramal);
         

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

        public void Excluir(int id_cliente)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Clientes WHERE id_cliente = @Id";
            Cmd.Parameters.AddWithValue("@Id", id_cliente);
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
