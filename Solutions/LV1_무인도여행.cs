using System;
using System.Collections.Generic;

public class Lv1무인도여행
{
    public int[] Solution(string[] maps)
    {
        int rows = maps.Length;
        int cols = maps[0].Length;

        bool[,] visited = new bool[rows, cols];
        List<int> sums = new List<int>();

        int[] dr = new int[] { -1, 1, 0, 0 };
        int[] dc = new int[] { 0, 0, -1, 1 };

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (visited[r, c]) continue;
                if (maps[r][c] == 'X') continue;

                // BFS 시작
                int sum = 0;
                Queue<(int rr, int cc)> q = new Queue<(int, int)>();
                q.Enqueue((r, c));
                visited[r, c] = true;

                while (q.Count > 0)
                {
                    var (cr, cc) = q.Dequeue();
                    sum += maps[cr][cc] - '0'; // '1'~'9'를 int로

                    for (int i = 0; i < 4; i++)
                    {
                        int nr = cr + dr[i];
                        int nc = cc + dc[i];

                        if (nr < 0 || nr >= rows || nc < 0 || nc >= cols) continue;
                        if (visited[nr, nc]) continue;
                        if (maps[nr][nc] == 'X') continue;

                        visited[nr, nc] = true;
                        q.Enqueue((nr, nc));
                    }
                }

                sums.Add(sum);
            }
        }

        if (sums.Count == 0) return new int[] { -1 };

        sums.Sort();
        
        
        int[] a = sums.ToArray();
        Console.Write(string.Join(",", a));
        return sums.ToArray();
    }
}
