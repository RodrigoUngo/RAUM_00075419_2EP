using System;

namespace Parcial02
{
    public class Usuario
    {
        private String username, password;

        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username => username;

        public string Password => password;
    }
}