public class Luminaria : Dispositivo
{
    private int intensidadeLuz;

    public int IntensidadeLuz
    {
        get { return intensidadeLuz; }
        set { intensidadeLuz = value; }
    }

    public Luminaria(string nome, int intensidadeLuz)
        : base(nome)
    {
        IntensidadeLuz = intensidadeLuz;
    }

    public override void Ligar()
    {
        Console.WriteLine($"A luminária {Nome} foi ligada.");
    }

    public override void Desligar()
    {
        Console.WriteLine($"A luminária {Nome} foi desligada.");
    }

    public void AjustarIntensidade(int intensidade)
    {
        IntensidadeLuz = intensidade;
        Console.WriteLine($"Intensidade da luminária {Nome} ajustada para {IntensidadeLuz}%.");
    }
}