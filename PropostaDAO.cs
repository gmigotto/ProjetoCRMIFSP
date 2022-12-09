using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CRMIFSP.Utils;

namespace projeto_pratico
{
    internal class PropostaDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public PropostaDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }

        public void Inserir(Proposta proposta)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Propostas( qtde,  valor_unit)  VALUES ( @qtde,  @valor_unit)";


            //Cmd.Parameters.AddWithValue("@id_vendedor", proposta.Vendedores);
           // Cmd.Parameters.AddWithValue("@id_cliente", proposta.Clientes);
            Cmd.Parameters.AddWithValue("@qtde", proposta.Qtde);
         //   Cmd.Parameters.AddWithValue("@id_produto", proposta.Descricao);
            Cmd.Parameters.AddWithValue("@valor_unit", proposta.Valor_Uni);
          //  Cmd.Parameters.AddWithValue("@id_stautus", proposta.Status_proposta);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao inserir proposta no banco de dados!\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<Proposta> ListarPropostas()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Propostas";

            List<Proposta> listaDePropostas = new List<Proposta>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Proposta proposta = new Proposta((int)rd["id_proposta"], (int)rd["id_vendedor"], (int)rd["id_cliente"], (int)rd["qtde"],
                        (int)rd["id_proposta"], (float)rd["valor_unit"], (int)rd["id_stautus"]);

                    listaDePropostas.Add(proposta);

                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura das propostas no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return listaDePropostas;

        }


        public void Atualizar(Proposta proposta)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Propostas SET id_vendedor = @Vendedores, id_cliente = @Clientes, qtde = @Qtde, des_produto = @Descricao, valor_unit = @Valor_Uni, id_stautus = @Status_proposta  
                                WHERE id_proposta = @Id";

            Cmd.Parameters.AddWithValue("@Id", proposta.Id);
            Cmd.Parameters.AddWithValue("@Vendedores", proposta.Vendedores);
            Cmd.Parameters.AddWithValue("@Clientes", proposta.Clientes);
            Cmd.Parameters.AddWithValue("@Qtde", proposta.Qtde);
            Cmd.Parameters.AddWithValue("@Descricao", proposta.Descricao);
            Cmd.Parameters.AddWithValue("@Valor_Uni", proposta.Valor_Uni);
            Cmd.Parameters.AddWithValue("@Status_proposta", proposta.Status_proposta);


            try
            {
                //Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas na atualização do banco de dados.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Excluir(int id_proposta)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Propostas WHERE id_proposta = @Id";
            Cmd.Parameters.AddWithValue("@Id", id_proposta);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir proposta no banco\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

        }
    }
}
