using System;
namespace Atividade_Polimorfismo
{
    public class Relatório
    {
        public DateTime dataRelatorio;

        public virtual void MostrarRelatório(){
            System.Console.WriteLine("O relatório está sendo mostrado");
            
        }
    }
}