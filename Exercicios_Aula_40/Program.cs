
using Exercicios_Aula_40.Models;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Exercicios_Aula_40
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ModeloCarro();
           // Calcular();
            //Retangular();
            Mercado();

            Console.ReadKey();

            static void ModeloCarro()
            {
                //Criar a classe Carro com os seguintes atributos: placa, marca, modelo, cor, criar o método display;

                Carro m1 = new Carro();
                m1.Modelo = "Argo";
                m1.Marca = "Fiat";
                m1.Cor = "Branco";
                m1.Placa = "QIH7275";

                m1.Display();

                Carro m2 = new Carro();
                m2.Modelo = "Gol";
                m2.Marca = "Volkswagen";
                m2.Cor = "Preto";
                m2.Placa = "PLJ5898";

                m2.Display();
            }

            static void Calcular()
            {
                //Cria uma classe calculadora com dois atributos; criar os métodos de adição, subtração, multiplicação e divisão.

                Calculadora calc = new Calculadora();

                Console.WriteLine("Digite o primeiro numero: ");
                calc.N1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero: ");
                calc.N2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o sinal da operação que você deseja: ");
                string sinal = Console.ReadLine();

                
                switch (sinal)
                {
                    case "+": calc.Adicao();
                        break;

                    case "-": calc.Subtrair();
                        break;

                    case "/": calc.Divisao();
                        break;

                    case "*": calc.Multiplicar();
                        break;

                }
                
            }

            static void Retangular()
            {
                //Criar uma classe Retangulo, informando seus atributos e métodos para calcular a área e perímetro.

                Retangulo calc = new Retangulo();
                Console.WriteLine("Digite a Altura: ");
                calc.Altura = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o comprimento:");
                calc.Comprimento = Convert.ToInt32(Console.ReadLine());

                calc.Perimetro();

                calc.Area();
            }

            static void Mercado()
            {
                Produtos produto = new Produtos();

                Console.WriteLine("Digite o código do produto: ");
                produto.Codigo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o nome do produto: ");
                produto.Descricao = Console.ReadLine();

                Console.WriteLine("Digite a quantidade no estoque: ");
                produto.Estoque = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor do produto: ");
                produto.ValorUnitario = Convert.ToInt32(Console.ReadLine());

                produto.Acrescimo();

                produto.Desconto();


                

            }



        }
    }
}