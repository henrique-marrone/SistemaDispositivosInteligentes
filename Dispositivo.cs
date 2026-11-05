public class Dispositivo
{
    private string nome;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public Dispositivo(string nome)
    {
        this.nome = nome;
    }

    public virtual void Ligar()
    {
        Console.WriteLine("O dispositivo está sendo ligado.");
    }

    public virtual void Desligar()
    {
        Console.WriteLine("O dispositivo foi desligado.");
    }
}