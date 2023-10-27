namespace Exercicios_Aula_40.Models
{
    internal class Retangulo
    {
        public int Altura;
        public int Comprimento;

        public void Area()
        {
            int resultado = Altura * Comprimento;

            Console.WriteLine("O valor da área é de: " + $"{resultado}");
        }

        public void Perimetro()
        {
            int lados = Altura * 2;
            int comprimentos = Comprimento * 2;
            int perimetro = lados + comprimentos;

            Console.WriteLine("O valor do perimetro é de: "  + $"{perimetro}");

        }
    }
}
