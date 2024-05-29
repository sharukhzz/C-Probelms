using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Evaluation3
{
    public partial class PanelUserControl1 : Panel
    {
        public PanelUserControl1()
        {
            InitializeComponent();
            ControlAdded += PanelUserControl1_ControlAdded;
            ControlRemoved += PanelUserControl1_ControlRemoved;
            LocationChanged += PanelUserControl1_LocationChanged;
        }

        protected override void OnAutoSizeChanged(EventArgs e)
        {
            PanelUserControl1_ControlAdded(this, null);
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            PanelUserControl1_ControlAdded(this, null);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            PanelUserControl1_ControlAdded(this, null);
        }

        private void PanelUserControl1_LocationChanged(object sender, EventArgs e)
        {
            PanelUserControl1_ControlAdded(sender, null);
        }

        private static int w=400, h=400;

        public string RowDefinition
        {
            get; set;
        }

        public string ColoumnDefinition
        {
            get; set;
        }

        public int RowMargin
        {
            get; set;
        }
        public int ColoumnMargin
        {
            get; set;
        }
        public int RowPadding
        {
            get; set;
        }
        public int ColoumnPadding
        {
            get; set;
        }
        bool b;
        private int rowvalue, columnvalue;
        List<double> Originalrow = new List<double>();
        List<double> Originalcolumn = new List<double>();
       
        List<int> finalrow = new List<int>();
        private static int index, index2;
        List<int> finalcolumn = new List<int>();

        
        public  void PanelUserControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            if (RowDefinition == null) return;
            if (!b )
            {
                string[] row = RowDefinition.Split(',');
                for (int i = 0; i < row.Length; i++)
                {
                    if (row[i] == "*")
                    {
                        finalrow.Add(1);
                    }
                    else if(row[i].Contains("*"))
                    {
                        string s = row[i].Replace("*", "");
                        finalrow.Add(Convert.ToInt32(s));
                    }
                    else
                    {
                        Width = Width - Convert.ToInt32(row[i]);
                    }
                }
                string[] coloumn = ColoumnDefinition.Split(',');
                for (int i = 0; i < coloumn.Length; i++)
                {
                    if (coloumn[i] == "*")
                    {
                        finalcolumn.Add(1);
                    }
                    else if(coloumn[i].Contains("*"))
                    {
                        string s = coloumn[i].Replace("*", "");
                        finalcolumn.Add(Convert.ToInt32(s));
                    }
                    else
                    {
                        Height = Height - Convert.ToInt32(coloumn[i]);
                    }
                }
                foreach (var item in finalrow)
                {
                    rowvalue += item;
                }
                foreach (var item in finalcolumn)
                {
                    columnvalue += item;
                }

                foreach (var item in finalrow)
                {
                    double d = (w - (RowPadding * (finalrow.Count - 1) + RowMargin*2)) * item / (rowvalue);
                    Originalrow.Add(d);
                }
                foreach (var item in finalcolumn)
                {
                    double d = (h - (ColoumnPadding * (finalcolumn.Count - 1) + ColoumnMargin * 2)) * item / (columnvalue);
                    Originalcolumn.Add(d);
                }
            }
            index = 0;
            Padding padding = new Padding(RowMargin, ColoumnMargin, RowPadding, ColoumnPadding);
            Padding = padding;
            //Margins margin = new Margins(RowMargin, RowMargin, ColoumnMargin, ColoumnMargin);
            // Margin = padding;
            //sender.Padding = Padding;
            //TextBox t = sender as TextBox;
            ////if (t!=null)
            ////{
            //    t.Width = Convert.ToInt32(Originalrow[index]);
            //    t.Height = Convert.ToInt32(Originalcolumn[index]);
            //}
            //ControlCollection collection = sender as ControlCollection();
            // collection.Count();
            int a=Controls.Count;
            int lx = padding.Left;
            int ly = padding.Top;
            int cx = 0;
            index2 = 0;
            foreach(Control c in Controls)
            {
                if (lx <= w)
                {
                    PanelUserControl1_LocationChanged(c,EventArgs.Empty);
                    lx += cx+RowPadding;
                    c.Width = Convert.ToInt32(Originalrow[index]);
                    c.Height = Convert.ToInt32(Originalcolumn[index2]);
                    c.Location = new Point(lx, ly);
                    c.Padding = padding;
                    cx = c.Width;
                    index++;
                }
                else
                {
                    PanelUserControl1_LocationChanged(c, EventArgs.Empty);
                    index2++;
                    cx = 0;
                    lx = cx + RowPadding;
                    c.Width = Convert.ToInt32(Originalrow[index]);
                    c.Height = Convert.ToInt32(Originalcolumn[index2]);
                    c.Location = new Point(lx, ly);
                    cx = c.Width;
                   
                }
            }
            b = true;
        }

        private void PanelUserControl1_ControlRemoved(object sender, ControlEventArgs e)
        {
            Controls.Remove(this);
        }


    }
}
