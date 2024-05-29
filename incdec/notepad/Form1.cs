using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace notepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();

        }
        private string filepath,undo,cut;
        private bool isUndo;

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            filepath = null;
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad notepad = new Notepad();
            notepad.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    filepath = open.FileName;
                    richTextBox1.Text = File.ReadAllText(filepath);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(filepath))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                File.WriteAllText(filepath, richTextBox1.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    filepath = save.FileName;
                    File.WriteAllText(filepath, richTextBox1.Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Selection = richTextBox1.SelectionStart;
            richTextBox1.Text = richTextBox1.Text.Insert(Selection, Clipboard.GetText());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string delete = richTextBox1.SelectedText;
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = true;
            hScrollBar1.Visible = false;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor += 1;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor -= 1;
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control )
            {
                if (e.KeyCode == Keys.Add || e.KeyCode==Keys.Oemplus)
                {
                    richTextBox1.ZoomFactor += 1;
                }
                if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
                {
                    richTextBox1.ZoomFactor -= 1;
                }
            }
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bing.com/search?q=get+help+with+notepad+in+windows&filters=guid:%224466414-en-dia%22%20lang:%22en%22&form=T00032&ocid=HelpPane-BingIA");
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("feedback-hub:");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{
        //    vScrollBar1.Maximum += richTextBox1.Text.Length-1;
        //  //  vScrollBar1.Value = richTextBox1.FirstVisibleLine;
        //}

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cut = richTextBox1.SelectedText;
            Clipboard.SetText(cut);  
            richTextBox1.Text=richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
           
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!isUndo)
            {
                undo = richTextBox1.Text;
                richTextBox1.Text = "";
                isUndo = true;
            }
            else
            {
                string k = richTextBox1.Text;
                richTextBox1.Text = undo;
                undo = richTextBox1.Text;
            }
        }
    }
}
