namespace Solutions;

public class LV0_덧셈식출력하기
{
    public void Solve()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        if (a < 1 || b > 100)
        {
            Console.Write("잘못된 입력");
            return;
        }

        Console.WriteLine("{0} + {1} = {2}", a,b,a+b );
    }
}