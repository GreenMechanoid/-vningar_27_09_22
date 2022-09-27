namespace Övningar_27_09_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            string UserInput = "";
            Console.WriteLine("Please enter a number");
            Count = int.Parse(Console.ReadLine());
            Console.WriteLine("enter segments");
            string InputSegments = Console.ReadLine();
            int NumSegments = Int32.Parse(InputSegments);
            for (int segment = 1; segment <= NumSegments; segment++)
            {
                for (int row = segment * NumSegments - NumSegments; row <= Count; row++)
                {

                    for (int squiggly = 1; squiggly <= Count - row; squiggly++)
                    {
                        Console.Write(" ");
                    }
                    for (int collumn = 1; collumn <= (row * 2 ) -1; collumn++)
                    {
                        Console.Write("*");
                    }
                    for (int squiggly = 1; squiggly <= Count - row; squiggly++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            //while (count < 5)
            //{
            //    Console.WriteLine("*");
            //    count++;
            //}




        }
    }
}