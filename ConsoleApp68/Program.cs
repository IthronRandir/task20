class Programm
{
    static int CountLessNSimple(int n)
    {
        int Count = 1;
        bool b = true;
        for (int LessN = 2; LessN < n; LessN++)
        {
            for (int i = 2; i < LessN; i++)
            {
                if (LessN % i == 0)
                {
                    b = true;
                    break;
                }
                else b = false;
            }
            if (b == false) Count++;
        }
        return Count;
    }

    static void Main(string[] args)
    {
        int n = 10;
        Console.WriteLine(CountLessNSimple(n));
    }
}