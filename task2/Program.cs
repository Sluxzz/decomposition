class Program
{
    static int Max3(int a, int b, int c)
    {
        return a>b && a>c?a:b>a && b>c?b:c; //ультра про сеньер версия ужатия через операции а не операторы иф елс
    }
    static void Main(string[] agrs)
    {
        System.Console.WriteLine(Max3(1,2,3));
        System.Console.WriteLine(Max3(3,2,1));
        System.Console.WriteLine(Max3(1,3,2));
    }
}