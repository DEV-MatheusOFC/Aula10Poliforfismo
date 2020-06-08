namespace Aula_10___Polimorfismo
{
    public class Aguia : Passaro
    {
        public override void Voar(){

            base.Voar();
            System.Console.WriteLine("A águia está voando.");

        }
    }
}