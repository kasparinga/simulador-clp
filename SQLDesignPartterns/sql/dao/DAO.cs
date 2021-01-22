using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDesignPartterns.sql.dao
{
    abstract class DAO
    {
        protected string nomeTabela;
        private List<string> nomeColuna;
        public string query{get; set;}
        public DAO(string nomeTabela, List<string> nomeColunas)
        {
            Tabela(nomeTabela, nomeColunas);
            this.nomeColuna = nomeColunas;
        }
        public void Tabela(string nomeTabela, List<string> nomesColunas)
        {
         
            string colunas=ColunasBuider(nomesColunas);
            query = "CREATE TABLE " + nomeTabela+ "( "+colunas+" )";
            this.nomeTabela = nomeTabela;
        }

        private string ColunasBuider(List<string> nomesColunas)
        {
            string colunas="ID INT PRIMARY KEY";
            foreach(string i in nomesColunas)
            {
                colunas = colunas + "," + i;
            }
            return colunas;
        }

        public string Adicionar(Object ob)
        {
            string colunas=null;
            string colunasValores=null;
            string sss;
            foreach (string s in nomeColuna)
            {
                char[] ss = s.ToCharArray();
                sss = null;
                for (int i=0; i< ss.Length; i++)
                {
                    sss = sss + ss[i];
                    if (ss[i].Equals(' '))
                        break;
                }
                
                colunas = colunas + sss + ",";
                colunasValores = colunasValores + "@" + sss + ",";
            }
            string sql = "INSERT INTO " + nomeTabela + "(" + colunas + ")" + " VALUES" + "(" + colunasValores + ")";
            return sql;
        }
        public void Deletar(Object ob)
        {
            
        }
        public Object Selecionar()
        {
            return new Object();
        }
        public List<Object> Query()
        {
            return new List<object>();
        }
    }
}
