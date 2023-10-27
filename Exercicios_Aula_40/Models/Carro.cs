namespace Exercicios_Aula_40;
 class Carro
{
    public string Modelo;
    public string Marca;
    public string Cor;
    public string Placa;

    public void Display()
    {
        Console.WriteLine("Modelo: " + $"{this.Modelo}");
        Console.WriteLine("Marca :" + $"{this.Marca}");
        Console.WriteLine("Cor: " + $"{this.Cor}");
        Console.WriteLine("Placa: " + $"{this.Placa}");
    }
}
