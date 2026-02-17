using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprofundamento.Models
{
    public class Pessoa
    {

        public Pessoa(string nome, string sobrenome) //método construtor (características): tem o mesmo nome da classe e não tem nenhum tipo de retorno -> tem o propóstio de inicializar os atributos da classe, alocar recursos e garantir um estado inicial válido.
        {
            Nome = nome; //a propriedade Nome recebe o parâmetro nome
            Sobrenome = sobrenome; //a propriedade Sobrenome recebe o parâmetro sobrenome
        }
        private string _nome; //private pois só será possível fazer alterações dentro da classe - _nome: campo para o nome
        /*
        encapsulamento: proteger um campo de alterações externas para fazer validações nele antes de qualquer atribuição -> private string _nome é um exemplo
        */
        private int _idade;
        public string Nome
        {
            get 
            {
                return _nome?.ToUpper(); //get => _nome.ToUpper(); é uma forma mais resumida de fazer a mesma coisa
            }

            set
            {
                if(value == "") //value é o valor q a propriedade nome está recebendo
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value; //se o nome não for vazio, coloca o valor dentro de _nome
            }
             
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); //propriedade só com get


        public int Idade { 

            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero.");
                }

                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}