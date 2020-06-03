using System;

namespace ProjetoCalculadora
{
    public class Operacoes : Numeros
    {
        public void Adicionar(){

            Console.WriteLine("Digite um número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            double num2 = double.Parse(Console.ReadLine());
            
           double resultado = num1 + num2;
            
            Console.WriteLine("Resultado: " +resultado);

        }
        public void Subtrair(){

            Console.WriteLine("Digite um número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            double num2 = double.Parse(Console.ReadLine());
            
            double resultado = num1 - num2;
            
            Console.WriteLine("Resultado: " +resultado);

        }

        public void Dividir(){

            Console.WriteLine("Digite um número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = num1 / num2;
            
            Console.WriteLine("Resultado: " +resultado);

        }

        public void Multiplicar(){

            Console.WriteLine("Digite um número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            double num2 = double.Parse(Console.ReadLine());
            
            double resultado = num1 * num2;
            
            Console.WriteLine("Resultado: " +resultado);

        }

        //

        private string[] valores {get; set;}
        private float soma {get; set;}
        private float resultado {get; set;}

        //public void Media(){

            public void Media(){
            Console.WriteLine("Digite os valores:");

            string txtConsole = Console.ReadLine();

            valores = txtConsole.Split(";");

            for(int i = 0; i < valores.Length; i++){

                soma += float.Parse(valores[i]);

            }

            resultado = soma / valores.Length;

            Console.WriteLine("Resultado: " +resultado);

            }
        //}
    }
}