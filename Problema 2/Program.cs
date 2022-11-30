namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turn an adjective into it's comparative or superlative form!");
            Console.Write("Write the adjective: ");

            while (true)
            {
                Metoda();
            }
        }

        public static void Metoda()
        {
            string adjective =Console.ReadLine();

            int location = adjective.Length-1;
            int location2 = adjective.Length - 2;

            string comparative = "";

            if (adjective[location]=='e')
            {
                comparative = adjective + "r";
            }
            else if (adjective[location2]=='e' && adjective[location]=='r')
            {
                 //string adj1= adjective.Replace(adjective[location+1], 't');
                 string adj1 = adjective.Substring(0,location2);
                 comparative = adj1 + "est";
            }
            else 
            {
                comparative = adjective + "er";           
            }

           // adjective[adjective.Length-1] = 'a';
            Console.WriteLine(comparative.ToLower());

            Console.Write("Write another adjective: ");
        }
    }
}