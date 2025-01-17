class RandomNumbers
{
    static void Main(string[] args)
    {

        Random random = new Random();

        int num = random.Next(1, 78) + 100;//range 1-78
        double num2 = random.NextDouble();
        Console.WriteLine(num);
        Console.WriteLine(num2);


    }
}