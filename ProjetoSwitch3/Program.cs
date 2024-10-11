using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSwitch3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string escolheCor;

            Console.WriteLine("Escolha sua cor preferida: " + "A-Azul\n B-Branco\n C-Cinza\n V-Verde");
            escolheCor = Console.ReadLine();

            //Vamos converter a resposta do usuario em Maiusculo
            escolheCor = escolheCor.ToUpper();

            //Chamamos o switch para validar a opção escolhida

            switch (escolheCor)
            {
                case "A":
                    Console.WriteLine("Cor escolhida: Azul");
                    break;
                case "B":
                    Console.WriteLine("Cor escolhida: Branco");
                    break;
                case "C":
                    Console.WriteLine("Cor escolhida: Cinza");
                    break;
                case "V":
                    Console.WriteLine("Cor escolhida: Verde");
                    break;
                default:
                    Console.WriteLine("Opção Incorreta!");
                    break;
            }


            Console.ReadKey();
        }
    }
}
