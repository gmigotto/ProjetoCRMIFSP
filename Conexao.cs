using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMIFSP.Utils
{
    internal class Conexao
    {
        private readonly SqlConnection Con;
        private readonly string DataBase = "CRMIFSP";
        public Conexao()
        {
            string stringConnection = @"Data Source=" + Environment.MachineName +
                @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security=true";

            Con = new SqlConnection(stringConnection);
            Con.Open();   //Abrir a conexão com o banco de dados
        }

        public void CloseConnection()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
        }

        public SqlConnection ReturnConnection()
        {
            return Con;
        }

        
    }
}
