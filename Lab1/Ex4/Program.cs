class Ex4
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(n+" x "+i+" = "+(n*i));
        }
        

    }
}