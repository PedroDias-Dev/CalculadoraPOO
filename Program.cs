using System;

namespace ProjetoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes operacao = new Operacoes();

            Numeros num1 = new Numeros();
            Numeros num2 = new Numeros();


            Console.WriteLine("Digite sua operação:");
            Console.WriteLine("(1) Adicao");
            Console.WriteLine("(2) Subtracao");
            Console.WriteLine("(3) Divisao");
            Console.WriteLine("(4) Multiplicaçao");
            Console.WriteLine("(5) Media");
            string answer = Console.ReadLine();

            if (answer == "1"){
                operacao.Adicionar();
            
            }

            if (answer == "2"){
                operacao.Subtrair();
                
            }

            if (answer == "3"){
                operacao.Dividir();
              
            }

            if (answer == "4"){
                operacao.Multiplicar();
                
            }

            if (answer == "5"){


                //Console.WriteLine("Digite os valores");

                //var valores = Console.ReadLine();
                

                //var itemValores = valores.Split(new string[] { ";" }, // lista de separadores complexos
                          //StringSplitOptions.RemoveEmptyEntries);

                //int soma = valores[0] + valores[1];
                //int media = soma / valores.Length;

               // foreach (var item in itemValores)
                //{
                    //item tem o valor de cada item da lista itemValores 
                    //Console.WriteLine($"<{itemValores}>");         
                //}

                //Console.WriteLine(media);
                
                operacao.Media();

            }
            
        }
    }
}
