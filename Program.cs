using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Dispositivo> dispositivos = new List<Dispositivo>();

        Controlador controlador = new Controlador();

        int opcao = 0;

        while (opcao != 7)
        {
            Console.WriteLine("\n==================================");
            Console.WriteLine(" SISTEMA DE DISPOSITIVOS INTELIGENTES");
            Console.WriteLine("==================================");
            Console.WriteLine("1 - Adicionar dispositivo");
            Console.WriteLine("2 - Listar dispositivos");
            Console.WriteLine("3 - Ativar dispositivos");
            Console.WriteLine("4 - Desativar dispositivos");
            Console.WriteLine("5 - Ajustar intensidade da luminária");
            Console.WriteLine("6 - Ajustar temperatura do ar-condicionado");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("==================================");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Digite uma opção válida.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    AdicionarDispositivo(dispositivos);
                    break;

                case 2:
                    ListarDispositivos(dispositivos);
                    break;

                case 3:
                    if (dispositivos.Count > 0)
                    {
                        controlador.Ativar(dispositivos.ToArray());
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dispositivo cadastrado.");
                    }
                    break;

                case 4:
                    if (dispositivos.Count > 0)
                    {
                        foreach (Dispositivo dispositivo in dispositivos)
                        {
                            dispositivo.Desligar();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dispositivo cadastrado.");
                    }
                    break;

                case 5:
                    AjustarIntensidade(dispositivos);
                    break;

                case 6:
                    AjustarTemperatura(dispositivos);
                    break;

                case 7:
                    Console.WriteLine("Encerrando o sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void AdicionarDispositivo(List<Dispositivo> dispositivos)
    {
        Console.WriteLine("\n--- ADICIONAR DISPOSITIVO ---");
        Console.WriteLine("1 - Luminária");
        Console.WriteLine("2 - Ar-condicionado");

        Console.Write("Escolha o tipo: ");

        if (!int.TryParse(Console.ReadLine(), out int tipo))
        {
            Console.WriteLine("Tipo inválido.");
            return;
        }

        Console.Write("Digite o nome do dispositivo: ");
        string nome = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("O nome não pode ficar vazio.");
            return;
        }

        if (tipo == 1)
        {
            Console.Write("Digite a intensidade da luz (0 a 100): ");

            if (!int.TryParse(Console.ReadLine(), out int intensidade) ||
                intensidade < 0 || intensidade > 100)
            {
                Console.WriteLine("Intensidade inválida.");
                return;
            }

            Luminaria luminaria = new Luminaria(nome, intensidade);

            dispositivos.Add(luminaria);

            Console.WriteLine("Luminária cadastrada com sucesso!");
        }
        else if (tipo == 2)
        {
            Console.Write("Digite a temperatura: ");

            if (!float.TryParse(Console.ReadLine(), out float temperatura))
            {
                Console.WriteLine("Temperatura inválida.");
                return;
            }

            ArCondicionado ar = new ArCondicionado(nome, temperatura);

            dispositivos.Add(ar);

            Console.WriteLine("Ar-condicionado cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Tipo de dispositivo inválido.");
        }
    }

    static void ListarDispositivos(List<Dispositivo> dispositivos)
    {
        Console.WriteLine("\n--- DISPOSITIVOS CADASTRADOS ---");

        if (dispositivos.Count == 0)
        {
            Console.WriteLine("Nenhum dispositivo cadastrado.");
            return;
        }

        for (int i = 0; i < dispositivos.Count; i++)
        {
            Dispositivo dispositivo = dispositivos[i];

            Console.WriteLine($"\nÍndice: {i + 1}");
            Console.WriteLine($"Nome: {dispositivo.Nome}");

            if (dispositivo is Luminaria luminaria)
            {
                Console.WriteLine("Tipo: Luminária");
                Console.WriteLine($"Intensidade: {luminaria.IntensidadeLuz}%");
            }
            else if (dispositivo is ArCondicionado ar)
            {
                Console.WriteLine("Tipo: Ar-condicionado");
                Console.WriteLine($"Temperatura: {ar.Temperatura}°C");
            }
        }
    }

    static void AjustarIntensidade(List<Dispositivo> dispositivos)
    {
        List<Luminaria> luminarias = dispositivos
            .OfType<Luminaria>()
            .ToList();

        if (luminarias.Count == 0)
        {
            Console.WriteLine("Nenhuma luminária cadastrada.");
            return;
        }

        Console.WriteLine("\n--- AJUSTAR INTENSIDADE ---");

        for (int i = 0; i < luminarias.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {luminarias[i].Nome}");
        }

        Console.Write("Escolha a luminária: ");

        if (!int.TryParse(Console.ReadLine(), out int indice) ||
            indice < 1 || indice > luminarias.Count)
        {
            Console.WriteLine("Índice inválido.");
            return;
        }

        Console.Write("Nova intensidade (0 a 100): ");

        if (!int.TryParse(Console.ReadLine(), out int intensidade) ||
            intensidade < 0 || intensidade > 100)
        {
            Console.WriteLine("Intensidade inválida.");
            return;
        }

        luminarias[indice - 1].AjustarIntensidade(intensidade);
    }

    static void AjustarTemperatura(List<Dispositivo> dispositivos)
    {
        List<ArCondicionado> aparelhos = dispositivos
            .OfType<ArCondicionado>()
            .ToList();

        if (aparelhos.Count == 0)
        {
            Console.WriteLine("Nenhum ar-condicionado cadastrado.");
            return;
        }

        Console.WriteLine("\n--- AJUSTAR TEMPERATURA ---");

        for (int i = 0; i < aparelhos.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {aparelhos[i].Nome}");
        }

        Console.Write("Escolha o ar-condicionado: ");

        if (!int.TryParse(Console.ReadLine(), out int indice) ||
            indice < 1 || indice > aparelhos.Count)
        {
            Console.WriteLine("Índice inválido.");
            return;
        }

        Console.Write("Digite a nova temperatura: ");

        if (!float.TryParse(Console.ReadLine(), out float temperatura))
        {
            Console.WriteLine("Temperatura inválida.");
            return;
        }

        aparelhos[indice - 1].AjustarTemperatura(temperatura);
    }
}