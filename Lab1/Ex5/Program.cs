class Ex5
{
    static void Main(string[] args)
    {
        Console.Write("Input factorial: ");
        int n = int.Parse(Console.ReadLine());
        if(n < 0)
        {
            Console.WriteLine("Factorial of a negative number doesn't exist.");
        }
        else
        {
            long l = 1;
            for(int i = 1; i < n; i++)
            {
                l = l * i;
            }
            Console.WriteLine("Factorial of " + n + " = " + l);
        }
    }
}