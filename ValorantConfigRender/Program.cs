using System;
using System.IO;

class Program
{
    static string filePath = @"C:\Users\Administrator\AppData\Local\VALORANT\Saved\Config\52828786-e71b-579b-9d1c-1fc134f632cb-br\Windows\GameUserSettings.ini";

    static void Main(string[] args)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Arquivo de configuração não encontrado.");
            return;
        }

        // Carregar o conteúdo do arquivo
        string[] lines = File.ReadAllLines(filePath);
        bool isUpdated = false;

        // Mostrar e alterar cada parâmetro
        foreach (var line in lines)
        {
            if (line.StartsWith("sg.ResolutionQuality"))
            {
                Console.WriteLine("Valor atual de sg.ResolutionQuality: " + GetCurrentValue(line));
                Console.Write("Digite o novo valor (ex: 90.000000): ");
                string newValue = Console.ReadLine();
                lines[Array.IndexOf(lines, line)] = "sg.ResolutionQuality=" + newValue;
                isUpdated = true;
            }
            else if (line.StartsWith("sg.ViewDistanceQuality"))
            {
                Console.WriteLine("Valor atual de sg.ViewDistanceQuality: " + GetCurrentValue(line));
                Console.Write("Digite o novo valor (ex: 3): ");
                string newValue = Console.ReadLine();
                lines[Array.IndexOf(lines, line)] = "sg.ViewDistanceQuality=" + newValue;
                isUpdated = true;
            }
            else if (line.StartsWith("sg.AntiAliasingQuality"))
            {
                Console.WriteLine("Valor atual de sg.AntiAliasingQuality: " + GetCurrentValue(line));
                Console.Write("Digite o novo valor (ex: 2): ");
                string newValue = Console.ReadLine();
                lines[Array.IndexOf(lines, line)] = "sg.AntiAliasingQuality=" + newValue;
                isUpdated = true;
            }
            else if (line.StartsWith("sg.ShadowQuality"))
            {
                Console.WriteLine("Valor atual de sg.ShadowQuality: " + GetCurrentValue(line));
                Console.Write("Digite o novo valor (ex: 0): ");
                string newValue = Console.ReadLine();
                lines[Array.IndexOf(lines, line)] = "sg.ShadowQuality=" + newValue;
                isUpdated = true;
            }
            else if (line.StartsWith("sg.PostProcessQuality"))
            {
                Console.WriteLine("Valor atual de sg.PostProcessQuality: " + GetCurrentValue(line));
                Console.Write("Digite o novo valor (ex: 0): ");
                string newValue = Console.ReadLine();
                lines[Array.IndexOf(lines, line)] = "sg.PostProcessQuality=" + newValue;
                isUpdated = true;
            }
            else if (line.StartsWith("sg.TextureQuality"))
            {
                Console.WriteLine("Valor atual de sg.TextureQuality: " + GetCurrentValue(line));
                Console.Write("Digite o novo valor (ex: 0): ");
                string newValue = Console.ReadLine();
                lines[Array.IndexOf(lines, line)] = "sg.TextureQuality=" + newValue;
                isUpdated = true;
            }
            else if (line.StartsWith("sg.EffectsQuality"))
            {
                Console.WriteLine("Valor atual de sg.EffectsQuality: " + GetCurrentValue(line));
                Console.Write("Digite o novo valor (ex: 0): ");
                string newValue = Console.ReadLine();
                lines[Array.IndexOf(lines, line)] = "sg.EffectsQuality=" + newValue;
                isUpdated = true;
            }
            else if (line.StartsWith("sg.FoliageQuality"))
            {
                Console.WriteLine("Valor atual de sg.FoliageQuality: " + GetCurrentValue(line));
                Console.Write("Digite o novo valor (ex: 0): ");
                string newValue = Console.ReadLine();
                lines[Array.IndexOf(lines, line)] = "sg.FoliageQuality=" + newValue;
                isUpdated = true;
            }
            else if (line.StartsWith("sg.ShadingQuality"))
            {
                Console.WriteLine("Valor atual de sg.ShadingQuality: " + GetCurrentValue(line));
                Console.Write("Digite o novo valor (ex: 0): ");
                string newValue = Console.ReadLine();
                lines[Array.IndexOf(lines, line)] = "sg.ShadingQuality=" + newValue;
                isUpdated = true;
            }
        }

        // Se houve alguma alteração, salvar as mudanças
        if (isUpdated)
        {
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("\nConfigurações atualizadas com sucesso!");
        }
        else
        {
            Console.WriteLine("\nNenhuma alteração foi realizada.");
        }
    }

    // Método para extrair o valor do parâmetro
    static string GetCurrentValue(string line)
    {
        var parts = line.Split('=');
        return parts.Length > 1 ? parts[1] : "Valor não encontrado";
    }
}
