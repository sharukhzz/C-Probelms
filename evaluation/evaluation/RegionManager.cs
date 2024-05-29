using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluation
{
    public  static class RegionManager
    {
        static Dictionary<string,IRegion> region = new Dictionary<string,IRegion>();
        static Rectangle rec = new Rectangle();       
        public static void AddRegion(string name, int r)
        {
                circle c = new circle();
                c.radius = r;
                c.Getarea();
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //c.Moveregion(x, y);
            region.Add(name, c);
            
      
        }
        public static void AddRegion(string name,int l,int b)
        {
                Rectangle rr = new Rectangle();
                rr.x1 = l;
                rr.x2 = b;
                rr.Getarea();
                region.Add(name, rr);
        }
        public static void AddRegion(string name, int l, int b, int h)
        {
            triangle t = new triangle();
            t.x1 = l;
            t.x2 = b;
            t.x3 = h;
            t.Getarea();
            region.Add(name, t);
        }
        public static void RemoveRegion()
        {

        }
        public static void GetAllRegion()
        {

        }
        public static void GetRegion()
        {

        }
        public static void Print()
        {
           foreach(var n in region)
            {
                Console.WriteLine(n);
            }
        }
    }
    interface  IRegion
    {
        int Name { get; set; }
        int Noofedge { get; set; }
        int Id { get; set; }
        void Getarea();
        void Moveregion();
        void Resize();
        void Intersect();
    }
    public class Rectangle : IRegion
    {
        public int Name { get; set; }
        public int Noofedge { get; set; }
        public int Id { get; set; }
        public int x1 { get; set; }
        public int x2 { get; set; }
        public  void Getarea()
        {
            Console.WriteLine(x1 * x2);
        }
        public void Moveregion()
        {

        }
        public void Resize()
        {

        }
        public void Intersect()
        {

        }
    }
    public class circle : IRegion
    {
        public int Name { get; set; }
        public int Noofedge { get; set; }
        public int Id { get; set; }
        public int radius { get; set; }
        public void  Getarea()
        {
            Console.WriteLine(radius * radius);
        }
        public void Moveregion()
        {

        }
        public void Resize()
        {

        }
        public void Intersect()
        {

        }
    }
    class triangle : IRegion
    {
        public int Name { get; set; }
        public int Noofedge { get; set; }
        public int Id { get; set; }
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int x3 { get; set; }
        public void Getarea()
        {
            Console.WriteLine(x1*x2 * x3);
        }
        public void Moveregion()
        {
            
        }
        public void Resize()
        {

        }
        public void Intersect()
        {

        }
        
    }
    
}
