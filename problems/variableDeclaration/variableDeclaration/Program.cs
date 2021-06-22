using System;

namespace variableDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = -100;
            Console.WriteLine(numberA);

            int numberB = -128;
            Console.WriteLine(numberB);

            short numberC = 3540;
            Console.WriteLine(numberC);

            int numberD = 64876;
            Console.WriteLine(numberD);

            double numberE = 2147483648;
            Console.WriteLine(numberE);

            double numberF = -1141583228;
            Console.WriteLine(numberF);

            double numberG = -1223372036854770;
            Console.WriteLine(numberG);

            int numberH = 808;
            Console.WriteLine(numberH);

            int numberI = 2_000_000;
            Console.WriteLine(numberI);

            int numberJ = 0b_0001_1110_1000_0100_1000_0000;
            Console.WriteLine(numberJ);

            int numberk = 0X_001E_8480;
            Console.WriteLine(numberk);

            decimal numberL = 3.141592653589793238M;
            Console.WriteLine(numberL);

            decimal numberM = 1.60217657M;
            Console.WriteLine(numberM);

            decimal numberN = 7.8184261974584555216535342341M;
            Console.WriteLine(numberN);

        }
    }
}
