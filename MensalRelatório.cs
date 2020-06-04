namespace Atividade_Polimorfismo
{
    public class MensalRelatório : Relatório
    {
        public override void MostrarRelatório(){
            base.MostrarRelatório();
            
            System.Console.WriteLine("Este mês está ok :)");
        }
    }
}