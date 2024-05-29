using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directions
{
    class Direct4
    {
        private const int n= 4;
        private const int m= 4;
        public void Dir(int [,]a)
        {
            int sx = int.Parse(Console.ReadLine());
            int sy = int.Parse(Console.ReadLine());
            int dx = int.Parse(Console.ReadLine());
            int dy = int.Parse(Console.ReadLine());
            Console.WriteLine(Fun(a, sx, sy, dx, dy));
        }
        public bool Fun(int[,]a,int sx,int sy,int dx,int dy)
        {
            bool[,] vis= new bool[n, m];
            Res(a, sx, sy, vis);
            if (!vis[dx, dy])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #region N
        public static void Res(int[,] a,int sx,int sy,bool[,]vis)
        {
            int i = sx, j = sy;
            if(i<0 || j<0 || i>=n || j>=n || vis[i,j] || a[i,j]==1)
            {
                return;
            }
            else
            {
                vis[i, j] = true;
                Res(a, i + 1, j, vis);
                Res(a, i - 1, j, vis);
                Res(a, i, j+1, vis);
                Res(a, i, j-1, vis);
            }
        }
        #endregion
    }
}
