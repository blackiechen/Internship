using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    public class Login
    {
        string username;
        string nomeUser;
        int codigo;
        int acesso;
        int escalao;

        public Login(string username, string nomeUser, int codigo, int acesso, int escalao)
        {
            this.Username = username;
            this.NomeUser = nomeUser;
            this.Codigo = codigo;
            this.Acesso = acesso;
            this.Escalao = escalao;
        }

        public Login(string username, string nomeUser, int codigo)
        {
            this.Username = username;
            this.NomeUser = nomeUser;
            this.Codigo = codigo;
        }

        public string NomeUser { get => nomeUser; set => nomeUser = value; }
        public string Username { get => username; set => username = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Acesso { get => acesso; set => acesso = value; }
        public int Escalao { get => escalao; set => escalao = value; }

       
    }
}
