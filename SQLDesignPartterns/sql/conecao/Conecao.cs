using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

namespace SQLDesignPartterns.sql.conecao
{
    class Conecao
    {
        private SqlConnection connection;
        private SqlCommand command;
        public Conecao(string servidor,string id, string senha)
        {

        }
        public void Fechar()
        {

        }
        public bool Abrir()
        {
            return false;
        }
        public void ExecQuery(string query)
        {

        }
        public void ExecQuery(string query, ArrayList lista)
        {
           foreach(var i in lista)
            {
                
            } 
        }
    }
}
