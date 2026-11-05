public class Controlador
{
    public void Ativar(Dispositivo dispositivo)
    {
        if (dispositivo == null)
        {
            Console.WriteLine("Dispositivo inválido.");
            return;
        }

        Console.WriteLine("Ativando 1 dispositivo...");
        dispositivo.Ligar();
    }

    public void Ativar(Dispositivo dispositivo1, Dispositivo dispositivo2)
    {
        if (dispositivo1 == null || dispositivo2 == null)
        {
            Console.WriteLine("Um dos dispositivos é inválido.");
            return;
        }

        Console.WriteLine("Ativando 2 dispositivos...");

        dispositivo1.Ligar();
        dispositivo2.Ligar();
    }

    public void Ativar(Dispositivo[] dispositivos)
    {
        if (dispositivos == null || dispositivos.Length == 0)
        {
            Console.WriteLine("Nenhum dispositivo disponível.");
            return;
        }

        Console.WriteLine($"Ativando {dispositivos.Length} dispositivos...");

        foreach (Dispositivo dispositivo in dispositivos)
        {
            if (dispositivo != null)
            {
                dispositivo.Ligar();
            }
        }
    }
}