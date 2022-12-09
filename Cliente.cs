using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace projeto_pratico
{
    internal class Cliente
    {
        private int _id;
        private string _nome;
        private string _cnpj;
        private string _endereco;
        private string _uf;
        private string _telefone;
        private string _ramal;
      
        public Cliente(string nome, string cnpj, string endereco, string uf, string telefone, string ramal)
        {
            Nome = nome;
            CNPJ = cnpj;
            Endereco = endereco;
            UF = uf;
            Telefone = telefone;
            Ramal = ramal; 
        }

        public Cliente(int id, string nome, string cnpj, string endereco, string uf, string telefone, string ramal)
        {
            _id = id;
            Nome = nome;
            CNPJ = cnpj;
            Endereco = endereco;
            UF = uf;
            Telefone = telefone;
            Ramal = ramal;
        }

        public int Id
        {
            get { return _id; }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _nome = value;
            }
        }

        public string CNPJ
        {
            get { return _cnpj; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O numero informado não é um texto válido");
                _cnpj = value;
            }
        }

        public string Endereco
        {
            get { return _endereco; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O endereco informado não é um texto válido");
                _endereco = value;
            }
        }

        public string UF
        {
            get { return _uf; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A UF informada não é um texto válido");
                _uf = value;
            }
        }

     
        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O telefone informado não é um texto válido");
                _telefone = value;
            }
        }

        public string Ramal
        {
            get { return _ramal; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O telefone informado não é um texto válido");
                _ramal = value;
            }
        }

    }
}
