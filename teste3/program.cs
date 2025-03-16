using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json; // use o nuget para fazer o download do pacote do Newtonsoft.Json

public class Faturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string caminhoArquivo = "C:\Users\User\Desktop\victor\.NET\teste3\dados.json";

        string faturamentoJson = File.ReadAllText(caminhoArquivo);

        var faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(faturamentoJson);

        var valoresFaturamento = faturamentos.Where(f => f.Valor > 0).Select(f => f.Valor).ToList();

        double menorValor = valoresFaturamento.Min();

        double maiorValor = valoresFaturamento.Max();

        double mediaFaturamento = valoresFaturamento.Average();

        int diasAcimaDaMedia = valoresFaturamento.Count(valor => valor > mediaFaturamento);

        Console.WriteLine($"Menor valor de faturamento: {menorValor}");
        Console.WriteLine($"Maior valor de faturamento: {maiorValor}");
        Console.WriteLine($"Número de dias com faturamento superior à média: {diasAcimaDaMedia}");
    }
}
