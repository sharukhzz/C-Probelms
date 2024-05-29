using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @event
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor p = new Processor("P1");
            Processor p2 = new Processor("P2");
            p2.ItemProcessed += OnItemProcessed;
            p2.ItemProcessed += OnItemProcessed1;
            p.ItemProcessed += OnItemProcessed;
            p.Add(1, 2);
            p.Add(1, 2, 3);
            p.Add(1, 2, 3, 4);
            p.Add(1, 2, 3, 4, 5);   
            List<string> data = new List<string>();
            for (int i = 1; i <= 1000; i++)
            {
                data.Add("File" + i);
            }
            p2.ReadFiles(data);
            Console.ReadLine();
        }

        private static void OnItemProcessed(string id, float per)
        {
            Console.WriteLine($"{id}:{per}%");// id + ":" + per + "%"
        }

        private static void OnItemProcessed1(string id, float per)
        {
            Console.WriteLine($"{per}%");// id + ":" + per + "%"
        }
    }

    public class Processor : BaseProcessor
    {
        public Processor(string id)
        {
            ID = id;
        }

        public string ID { get; }

        public delegate void ProgressionHandler(string id, float per);

        public event ProgressionHandler ItemProcessed;

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(params int[] values)
        {
            return 0;
        }

        public void ReadFiles(List<string> files)
        {
            int len = files.Count;
            for (int i = 1; i <= len; i++)
            {
                //Thread.Sleep(10);
                float per = Convert.ToSingle(Math.Round((float)i / len * 100, 2));
                if (ItemProcessed != null)
                    ItemProcessed.Invoke(ID, per);
                //TODO
            }
        }
    }

    public interface BaseProcessor
    {
        int Add(int a, int b);

        int Add(int a, int b, int c);

        int Add(params int[] values);
    }
}
