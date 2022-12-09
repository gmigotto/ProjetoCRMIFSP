using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projeto_pratico
{
    internal class Proposta
    {
        private int _id;
        private int _vend;
        private int _cli;
        private int _quantidade;
        private int _descricao;
        private float _valor;
        private int _status;
        private int tabIndex1;
        private int tabIndex2;
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private int tabIndex3;
        private int tabIndex4;

        public Proposta(int vend, int cli, int quantidade, int descricao, float valor, int status)
        {

            Vendedores = vend;
            Clientes = cli;
            Qtde = quantidade;
            Descricao = descricao;
            Valor_Uni = valor;
            Status_proposta = status;
        }

        public Proposta(int tabIndex1, int tabIndex2, string text1, int tabIndex3, string text2, int tabIndex4)
        {
            this.tabIndex1 = tabIndex1;
            this.tabIndex2 = tabIndex2;
            this.text1 = text1;
            this.tabIndex3 = tabIndex3;
            this.text2 = text2;
            this.tabIndex4 = tabIndex4;
        }

        public Proposta(int id, int vend, int cli, int quantidade, int descricao, float valor, int status)
        {
            _id = id;
            Vendedores = vend;
            Clientes = cli;
            Qtde = quantidade;
            Descricao = descricao;
            Valor_Uni = valor;
            Status_proposta = status;
        }

        public int Id
        {
            get { return _id; }
        }

        public int Vendedores
        {
            get { return _vend; }

            set
            {
                                  
                _vend = value;
            }

        }

        public int Clientes
        {
            get { return _cli; }

            set
            {

                _cli = value;
            }

        }
        public int Qtde
        {
            get { return _quantidade; }

            set
            {

                _quantidade = value;
            }

        }

        public int Descricao
        {
            get { return _descricao; }
            set
            {
              
                _descricao = value;
            }
        }
        public float Valor_Uni
        {
            get { return _valor; }

            set
            {

                _valor = value;
            }

        }

        public int Status_proposta
        {
            get { return _status; }
            set
            {
                
                _status = value;
            }
        }

    }
}
