namespace Atividade_Polimorfismo
{
    public class AnualRelatório : Relatório
    {
        public override void MostrarRelatório(){
            base.MostrarRelatório();
            System.Console.WriteLine("O Relatório anual está ok. :)");
        }
        
    }
}