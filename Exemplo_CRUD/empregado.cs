using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; // biblioteca de conexao com o MySql
using MySql.Data.MySqlClient;  // biblioteca de conexao com o MySql

namespace Exemplo_CRUD
{
    internal class empregado : conexao
    {
        private string nome;
        private string sobrenome;
        private string cpf;

        public void setNome (string nome)
        {
            this.nome = nome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getNome ()
        {
            return this.nome;
        }

        public string getSobrenome ()
        {
            return this.sobrenome;
        }

        public string getCpf ()
        {
            return this.cpf;
        }

        // Criar metodo inserir
        public void inserir()
        {
            string query = "insert into empregado(nome_empregado, sobrenome_empregado, cpf_empregado)VALUES('" + getNome() + "', + '" + getSobrenome() + "', + '" + getCpf() + "')";
            
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
