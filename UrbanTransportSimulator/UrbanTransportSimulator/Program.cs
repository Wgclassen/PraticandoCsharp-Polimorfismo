using UrbanTransportSimulator;

List<Transporte> opcoes = new List<Transporte>
{
    new Onibus(),
    new Metro(),
    new Bicicleta()
};

int distancia = 10;

foreach (var transporte in opcoes)
{
    Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distancia)} min");
}