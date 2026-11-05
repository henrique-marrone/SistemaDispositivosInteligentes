public class ArCondicionado : Dispositivo
{
    private float temperatura;

    public float Temperatura
    {
        get { return temperatura; }
        set { temperatura = value; }
    }

    public ArCondicionado(string nome, float temperatura)
        : base(nome)
    {
        Temperatura = temperatura;
    }

    public override void Ligar()
    {
        Console.WriteLine($"O ar-condicionado {Nome} foi ligado.");
    }

    public override void Desligar()
    {
        Console.WriteLine($"O ar-condicionado {Nome} foi desligado.");
    }

    public void AjustarTemperatura(float novaTemperatura)
    {
        Temperatura = novaTemperatura;
        Console.WriteLine($"Temperatura do ar-condicionado {Nome} ajustada para {Temperatura}°C.");
    }
}