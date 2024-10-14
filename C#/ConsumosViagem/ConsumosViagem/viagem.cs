using System;

class viagem
{
    //Variáveis de instante
    int KmInicio, KmFim;
    double LInicio, LFim;

    static void Main(string[] args)
    {
        viagem calc = new viagem();
        //leitura dos valores
        Console.Write("Valor de KM no início da viagem: ");
        calc.KmInicio = Convert.ToInt32(Console.ReadLine());

        Console.Write("Valor de KM no final da viagem: ");
        calc.KmFim = Convert.ToInt32(Console.ReadLine());

        Console.Write("Quantidade de litros no início da viagem: ");
        calc.LInicio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantidade de litros no final da viagem: ");
        calc.LFim = Convert.ToDouble(Console.ReadLine());

        double consumoMedio = calc.CalcularConsumoMedioPor100Km();

        Console.WriteLine("O consumo médio do carro foi de: {0:N2} L/100KM", consumoMedio);
        Console.ReadKey();
    }

    //métodos para calcular
    public double CalcularConsumoMedioPor100Km()
    {
        double distanciaPercorrida = KmFim - KmInicio;
        double litrosConsumidos = LInicio - LFim;
        double distanciaPor100Km = distanciaPercorrida / 100;
        double litrosPor100Km = litrosConsumidos / distanciaPor100Km;
        double consumoMedio = litrosPor100Km;

        return consumoMedio;
    }
}
