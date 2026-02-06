namespace Solutions;

public class LV0_홀짝구분하기
{
    public void Solve()
    {
        
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        
        int result = a % 2;
        
        if(result == 0)
        {
            Console.WriteLine("{0} is even",a);
        }
        else
        {
            Console.WriteLine("{0} is odd", a);
        }
    }
}