using System.Numerics;

namespace Schackbräde_och_riskorn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger[,] matrix = new BigInteger[8, 8];

            BigInteger riskorn = 1;

            for (int i = 0; i < 64; i++)
            {
                int rad = i / 8;
                int kolumn = i % 8;
                matrix[rad, kolumn] = riskorn;
                riskorn = riskorn * 2;
            }

            int summa = 0;

            bool hittat10Miljoner = false;
            bool hittatGoogle = false;

            for (int rad = 0; rad < 8; rad++)
            {
                for (int kolumn = 0; kolumn < 8; kolumn++)
                {
                    Console.Write(matrix[rad, kolumn] + " ");

                    if (matrix[rad, kolumn] > 10000000 && hittat10Miljoner == false)
                    {
                        Console.WriteLine("Index: " + rad + " " + kolumn + ", Riskorn: " + matrix[rad, kolumn]);

                        summa = summa + rad + kolumn;

                        hittat10Miljoner = true;
                    }

                    if (matrix[rad, kolumn] > 1340000000000 && hittatGoogle == false)
                    {
                        Console.WriteLine("Index: " + rad + " " + kolumn + ", Riskorn: " + matrix[rad, kolumn]);

                        summa = summa + rad + kolumn;

                        hittatGoogle = true;
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("Över 10 miljoner: [3, 0]");
            Console.WriteLine("Över Googles värde: [5, 1]");
            Console.WriteLine("Summan av index: " + summa);
        }
    }
}