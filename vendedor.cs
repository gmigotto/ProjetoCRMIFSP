using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projeto_pratico
{
    internal class Vendedor
    {
        private int _id;
        private string _nome;

        private string _nascimento;
        private string _telefone;
        private string _CPF;
        private string _endereco;
        private string _email;
        private string _senha;

       

        public Vendedor(string nome, string nascimento, string telefone, string cpf, string endereco, string email, string senha)
        {
            Nome = nome;
            Nascimento = nascimento;
            Telefone = telefone;
            Endereco = endereco;
            CPF = cpf;
            Email = email;
            Senha = senha;
        }

        public Vendedor(int id, string nome, string nascimento, string telefone, string cpf, string endereco, string email, string senha)
        {
            _id = id;
            Nome = nome;
            Nascimento = nascimento;
            Telefone = telefone;
            Endereco = endereco;
            CPF = cpf;
            Email = email;
            Senha = senha;
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

        public string Nascimento
        {
            get { return _nascimento; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A data de nascimento informado não é um texto válido");
                _nascimento = value;
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
        public string CPF
        {
            get { return _CPF; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O CPF informado não é um texto válido");
                _CPF = value;
            }

        }

        public string Endereco
        {
            get { return _endereco; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O endereco informado não é um texto válido");
                _endereco= value;
            }

        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O emal informado não é um texto válido");
                _email= value;
            }

        }

        public string Senha
        {
            get { return _senha; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A senha informada não é um texto válido");
                _senha = value;
            }

        }
    }
    
}
