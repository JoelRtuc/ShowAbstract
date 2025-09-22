namespace ShowAbstract
{
    internal class Program
    {

        static void Main(string[] args)
        {
            User admin = new Admin(), costumer = new Costumer();

            Console.WriteLine("Hello, World!");

            Console.WriteLine(admin.ShowMenu);
            Console.WriteLine(costumer.ShowMenu);

        }
    }
}
