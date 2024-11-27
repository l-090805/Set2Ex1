namespace Set2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de elemente din secventa: ");
            int n = int.Parse(Console.ReadLine());

            int contorPar = 0;

            Console.WriteLine($"Introduceti cele {n} elemente");
            for( int i = 0; i < n; i++)
            {
                int numar = int.Parse(Console.ReadLine());
                if(numar % 2 == 0)
                {
                    contorPar++;
                }    
            } 
            Console.WriteLine($"In secventa exista {contorPar} numere pare");
        }
    }
}
    

