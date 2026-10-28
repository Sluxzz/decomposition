class Program
{
    static long Fact(int n)
    {
        if(n==0) return 1;
        else
            return Fact(n-1)*n;
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine(Fact(0)); //1
        System.Console.WriteLine(Fact(3)); //6
        System.Console.WriteLine(Fact(5)); //120
    }
}