namespace Set2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti dimensiunea sirului: ");
            int n = int.Parse(Console.ReadLine());
            int[] sir = new int[n];
            int numerePare = 0;
            Console.WriteLine($"Introduceti cele {n} elemente ale sirului: ");
            for (int i = 0; i < n; i++)
            {
                bool valid = false;
                Console.Write($"Elementul {i + 1}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int numar))
                {
                    sir[i] = numar;
                    valid = true;
                    if(numar % 2 == 0)
                    {
                        numerePare++;
                    }
                }
                else
                {
                    Console.WriteLine("Vă rog să introduceți un număr valid.");
                }

            }

            Console.WriteLine($"Sirul are {numerePare} numere pare");
        }
    }
}
    

