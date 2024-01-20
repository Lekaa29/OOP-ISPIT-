namespace ISPIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //AV1 PRIMJER KLASE
            Dog rex = new Dog();
            string rexDescription = "";
            // rexDescription += rex.name + Environment.NewLine; // Can’t access private members!
            // rexDescription += rex.breed + Environment.NewLine; // Can’t access protected members!
            rexDescription += rex.colour;
            // na ispitu je navodno sve private znaci moramo napravit getter i setter
            rex.Bark(); //poziv funkcije
            rex.SetName("Kevin"); //setter (PRISTUPNA METODA)
            string name = rex.GetName(); //getter (PRISTUPNA METODA)


        }
    }
}