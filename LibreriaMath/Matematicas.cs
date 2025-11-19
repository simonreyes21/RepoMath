public class Matematicas
{
    public static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    public static int MaximoComunDivisor(int a, int b)
    {
        if (b == 0) return a;
        else return MaximoComunDivisor(b,a%b);
    }
}

