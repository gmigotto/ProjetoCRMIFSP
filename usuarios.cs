using CRMIFSP.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pratico
{
    internal class usuarios
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public usuarios()
        {   
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Usuario usuario) 
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Vendedores (@Cod_vendedor, @Nome_vendedor, @Dt_Nascimento, @Tel_vendedor, @CPF_vendedor, @End_vendedor) +
                                VALUES (@Nome_vendedor, @Dt_Nascimento, @Tel_vendedor, @CPF_vendedor, @End_vendedor)";



        }


    }
}
