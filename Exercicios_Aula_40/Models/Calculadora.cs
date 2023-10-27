namespace Exercicios_Aula_40.Models
{
    internal class Calculadora
    {

        public int N1;
        public int N2;

        

        public void Calcular()
        {
            int resultado = N1 + N2;

            Console.WriteLine(resultado);
        }

        public void Subtrair()
        {
            int resultado = N1 - N2;

            Console.WriteLine(resultado);
        }

        public void Adicao()
        {
            int resultado = N1 + N2;
            Console.WriteLine(resultado);
        }

        public void Divisao()
        {
            int resultado = N1 / N2;
            Console.WriteLine(resultado);
        }

        public void Multiplicar()
        {
            int resultado = N1 * N2;
            Console.WriteLine(resultado);
        }
    }
}
