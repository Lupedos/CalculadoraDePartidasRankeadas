using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRanqueada
{
    internal class Codigo
    {
        private string nome;
        private int saldoVitorias;
        private string nivel;
        void CalcularResultado(string n, int vitorias, int derrotas)
        {
            nome = n;
            saldoVitorias = vitorias - derrotas;

            if (saldoVitorias <= 10)
            {
                nivel = "Ferro";
            }
            else if (saldoVitorias >= 11 && saldoVitorias <= 20)
            {
                nivel = "Bronze";
            }
            else if (saldoVitorias >= 21 && saldoVitorias <= 50)
            {
                nivel = "Prata";
            }
            else if (saldoVitorias >= 51 && saldoVitorias <= 80)
            {
                nivel = "Ouro";
            }
            else if (saldoVitorias >= 81 && saldoVitorias <= 90)
            {
                nivel = "Diamante";
            }
            else if (saldoVitorias >= 91 && saldoVitorias <= 100)
            {
                nivel = "Lendário";
            }
            else if (saldoVitorias >= 101)
            {
                nivel = "Imortal";
            }
            Saida();
        }
        void Saida()
        {
            Console.WriteLine("O " + nome + " tem de saldo de " + saldoVitorias + " está no nível de " + nivel);

        }
        public void Entrada()
        {
            Console.WriteLine("Qual Nome da sua conta?");
            string n = Console.ReadLine();
            

            Console.WriteLine("Qual Numero de Vitorias?");
            string v = Console.ReadLine();
            

            Console.WriteLine("Qual Numero de Derrotas?");
            string d =  Console.ReadLine();
            

            int testeV, testeD;
            if (int.TryParse(v, out testeV) && int.TryParse(d, out testeD))
            {
                CalcularResultado(n, testeV, testeD);
            }
            else
            {
                Console.WriteLine("Numero de Vitorias ou Derrotas Nao valido. Informe um numero inteiro!");
                return;
            }

        }
    }
}
