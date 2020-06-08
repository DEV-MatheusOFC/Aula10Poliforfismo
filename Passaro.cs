namespace Aula_10___Polimorfismo
{
    public class Passaro
    {
        public virtual void Voar(){
            System.Console.WriteLine("Voando");
        }

        public virtual void Correr(){
            System.Console.WriteLine("Correndo");
        }

    }
}