using System;

namespace Calculadora_C__Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a operação deseja realizar \n Soma,Subtração,Multiplicação,Divisão");

            string operacao =Console.ReadLine();

            Console.WriteLine("Digite o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            if(operacao == "Soma")
            {
                resultado = num1 + num2;
            }
            else if(operacao == "Subtracao" || operacao == "subtracao")
            {
                resultado = num1 / num2;
            }
            else if(operacao == "Multiplicação")
            {
                resultado = num1 * num2;
            }
            else if(operacao =="Divisão")
            {
                resultado = num1 /num2;
            }
            else
            {
                Console.WriteLine("Operacao invalida");
            }
            switch(operacao){

                case "Soma":
                    resultado = num1 + num2;
                    break;

                case "Multiplicação":
                    resultado = num1 - num2;
                    break;

                case "Divisão":
                    resultado = num1 / num2;
                    break;
                case "Subtracao":
                    resultado = num1 - num2;
                    break;
                default:
                    operacao = "Invalida";
                    Console.WriteLine("Operação invalida!");
                    break;

            }
            Console.WriteLine($"Calculo: {num1} com {num2} = {resultado}");
        }
    }
}
