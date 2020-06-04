using System;

namespace Atividade_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           MensalRelatório relatorioMensal = new MensalRelatório();
           System.Console.WriteLine("RelatórioMensal:");
           relatorioMensal.MostrarRelatório();

           AnualRelatório relatorioAnual = new AnualRelatório();
           System.Console.WriteLine("Mostrando relatório anual:");
           relatorioAnual.MostrarRelatório();
           
        }
    }
}
