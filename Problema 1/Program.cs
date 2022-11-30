namespace Problema_1
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Check if an integer is the sum of four consecutive numbers!");
            Console.Write("Type the integer: ");

            while (true)
            {
                Metoda();
            }
        }

        private static void Metoda()
        {
            long integer = Convert.ToInt32(Console.ReadLine());

            long check = 0;

            for (int j = -1; j <= integer/2; j++)
            {
                if (4 * j + 6 == integer)
                {
                    Console.WriteLine(integer + " is the sum of four consecutive integers " + j + "+" + (j+1) + "+" + (j+2) + "+" + (j+3));

                    check = integer;
                }
            }

            if (check != integer)
            { 
                Console.WriteLine(integer + " is not the sum of four consecutive integers");
            }

            Console.Write("Type another integer: ");
        }

    }
}
