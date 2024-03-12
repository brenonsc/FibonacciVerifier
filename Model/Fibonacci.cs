namespace FibonacciVerifier.Model;

public class Fibonacci
{
    public static bool Verificar(int num)
    {
        int a = 0, b = 1;
        
        if (num == a || num == b)
        {
            return true;
        }
        
        while (b <= num)
        {
            int temp = a + b;
            a = b;
            b = temp;
            
            if (b == num)
            {
                return true;
            }
        }
        
        return false;
    }
}