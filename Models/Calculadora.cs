using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentos_.NET_e_C_.Models
{
    public class Calculadora
    {
        public void Soma(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtracao(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicacao(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }
        public void Divisao(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potenciacao(int x, int y)
        {
            double potencia = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {potencia}");
        }
        public void Seno(double angulo)
        {
           double radiano = angulo * Math.PI / 180;
           double seno = Math.Sin(radiano);
           Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }
        public void Cosseno(double angulo)
        {
           double radiano = angulo * Math.PI / 180;
           double cosseno = Math.Cos(radiano);
           Console.WriteLine($"Cosseno de {angulo} = {Math.Round(cosseno, 4)}");
        }
        public void Tangente(double angulo)
        {
           double radiano = angulo * Math.PI / 180;
           double tan = Math.Tan(radiano);
           Console.WriteLine($"Tangente de {angulo} = {Math.Round(tan, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    
    }
}