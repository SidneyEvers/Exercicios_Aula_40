namespace Exercicios_Aula_40.Models
{
    internal class Produtos
    {
        public int Codigo;
        public string Descricao;
        public int Estoque;
        public int ValorUnitario;

        public void Acrescimo()
        {
            Console.WriteLine("Digite o valor da porcentagem de acréscimo: ");
            int acrescimo = Convert.ToInt32(Console.ReadLine());

            int porcentagem = ValorUnitario / 100 * acrescimo;

            int resultado = ValorUnitario + porcentagem;

            Console.WriteLine($"Seu produto teve um acréscimo de {acrescimo}, ficando com um valor final de R$ {resultado}");
        }

        public void Desconto()
        {
            Console.WriteLine("Digite o valor da porcentagem de desconto: ");
            int desconto = Convert.ToInt32(Console.ReadLine());

            int porcentagem = ValorUnitario / 100 * desconto;

            int resultado = ValorUnitario - porcentagem;

            Console.WriteLine($"Seu produto teve um desconto de {desconto}, ficando com um valor final de R$ {resultado}");
        }


    }
}
