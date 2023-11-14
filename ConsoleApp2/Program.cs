

namespace ConsoleApp2
{
    internal class Program
    {
        int a = 5;

        //float desimalTall = 2.05F;
        //double desimalTall2 = 2.05;
        decimal b = 3.0M;

        //char bokstav = 'a';
        //string tekst = "hei";

        //bool santUsant = true;

        public void getNumber()
        {
            decimal sum = a + b;
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.getNumber();
        }
    }
}