namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 9;
            Console.WriteLine(Add(firstNumber,secondNumber));
        }

        static int Add(int x, int y) 
        {
            return x+y;
        }
    }
}