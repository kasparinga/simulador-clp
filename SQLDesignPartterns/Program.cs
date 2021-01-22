using SQLDesignPartterns.modelo.carro;
using SQLDesignPartterns.modelo.carro.daoCarro;
using SQLDesignPartterns.modelo.daoPessoa;
using SQLDesignPartterns.modelo.pessoa;
using System;

namespace SQLDesignPartterns
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("joao",35);
            Carro ca = new Carro("fusca","branco",1970);
            DaoPessoa daoPessoa = new DaoPessoa(pessoa);
            DaoCarro daoCarro = new DaoCarro("carro",ca);
            Console.WriteLine(daoPessoa.query);
            Console.WriteLine(daoCarro.query);
            Console.WriteLine(daoPessoa.Adicionar(pessoa));
            Console.WriteLine(daoCarro.Adicionar(ca));
        }
    }
}
