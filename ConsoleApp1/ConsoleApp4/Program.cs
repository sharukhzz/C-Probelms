using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HelloWorld
{
    int count = -1;
    public void rotate(ref int[] arr, ref int n, ref int mini)
    {
        count++;
        if (mini != arr[0])
        {
            int temp = arr[0];
            for (int i = 0; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[n - 1] = temp;
            print(arr, n);
            check(ref arr, ref n);
        }
        else
            remove(ref arr, ref n, mini);
    }
    public void print(int[] arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    public void min(ref int[] arr, ref int n, ref int mini)
    {
        mini = arr[0];
        for (int i = 0; i < n; i++)
        {
            if (mini > arr[i])
            {
                mini = arr[i];
            }
        }

    }
    public void remove(ref int[] arr, ref int n, int mini)
    {
        int[] clone = new int[n - 1];
        int j = 0;
        for (int i = 1; i < n; i++)
        {
            clone[j] = arr[i];
            j++;
        }
        n = j;
        print(clone, n);

        while (n > 0)
        {

            check(ref clone, ref n);
        }

    }
    public void check(ref int[] arr, ref int n)
    {

        int mini = 0;
        min(ref arr, ref n, ref mini);

        rotate(ref arr, ref n, ref mini);

    }
    static void Main()
    {
        //Console.Write("Enter Array : ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int n = arr.Length;
        HelloWorld rot = new HelloWorld();

        rot.check(ref arr, ref n);
        Console.WriteLine("N6umber of Count" + " " + rot.count);

        Console.ReadLine();
    }
}
