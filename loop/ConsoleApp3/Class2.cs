using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class2
    {
        public Class2()
        {
            string s = "2-4A0r7-4k";
            s = s.ToUpper();
            int k = 4;
            string[] st = s.Split('-');
            //Array.Sort(st);
           
            string[] stt=st.OrderByDescending(st2 => st2 ).ToArray();
            for (int i = 0; i < st.Length; i++)
            {
                Console.WriteLine(i + "    " + stt[i]);
                st[i] = stt[i];
            }
            
            int k1 = st.Length;
            for(int i=0;i<k;i++)
            {
                if (st[i] != null)
                {
                    if (st[i].Length <= k)
                    {
                        int c = 0;
                        string su = "";
                        string suu = "";
                        int j = i;
                        while (su.Length <= k)
                        {
                            if (su.Length >= k)
                            {
                                break;
                            }
                            //if(suu.Length>=k)
                            //{
                            //    break;
                            //}
                            else
                            {
                                if (st[j].Length <= k)
                               {
                                    su = st[j] + su;
                                    st[j] = null;
                                    Console.WriteLine("su is"+su);
                                    c++;
                                    j++;
                                }
                                else
                                {
                                    suu = st[j];
                                    Console.WriteLine("suu is " + suu);
                                    j++;
                                }

                            }

                        }
                        k1 = st.Length - c;
                        st[i] = su;
                    }
                }
            }
            // Array.Sort(st);
         /*   int max = 0,p=0,flag=0;
            for (int i = 0; i < st.Length; i++)
            { 
                if (st[i] != null)
                {
                    
                    int co = 0;
                    String b = st[i].ToString();
                    bool ir = b.Any(char.IsDigit);
                    if (!ir)
                    {
                        for (int j = 0; j < b.Length; j++)
                        {
                            string r = b[i].ToString();
                            bool ip = r.Any(char.IsDigit);
                            if (ip)
                            {
                                co += b[i];
                                flag = 1;
                            }
                        }
                        if (max < co)
                        {
                            co = max;
                            p = i;
                        }
                    }
                }
            }
            if (flag == 1)
            {
                string h = st[0];
                st[0] = st[p];
                st[p] = h;
                Console.WriteLine("print");
            }*/
            //else
            //{
            //    string[] stt1 = st.OrderBy(st2 => st2).ToArray();
            //    for (int i = 0; i < st.Length; i++)
            //    {
            //        st[i] = stt1[i];
            //    }
            //}
            string ss ="";
            for(int i=st.Length-1;i>=0;i--)
            {
                if (st[i] != null)
                {

                    ss += st[i] + "-";
                }
            }
            Console.WriteLine(ss.Trim('-'));
        }
    }
}
