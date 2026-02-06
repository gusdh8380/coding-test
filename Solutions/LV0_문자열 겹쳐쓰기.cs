namespace Solutions;

public class LV0_문자열_겹쳐쓰기
{
    public void Solve()
    {
        String s = Solve1("He11oWor1d", "lloWorl", 2);
        
        Console.WriteLine(s);
    }

    public string Solve1(string a, string b, int c)
    {
        String result = "";
        
        char[] chars1 = a.ToCharArray();
        char[] chars2 = b.ToCharArray();

        foreach (char c1 in chars1)
        {
            Console.WriteLine(c1);
        }
        
        
        for(int i = 0; i < a.Length; i++)
        {
            if (i >= c && i < b.Length + (c))
            {
                result += chars2[i-c];
            }
            else
            {
                result += chars1[i];
            }
        }
        
        return result;
    }
}