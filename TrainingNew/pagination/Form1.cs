using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pagination
{
    public partial class Form1 : Form
    {
        //private const int PageSize = 5;
        //private List<string> data;
        //private int currentPage;
        //public Form1()
        //{
        //    InitializeComponent();
        //    data = new List<string>();
        //    for (int i = 1; i <= 50; i++)
        //    {
        //        data.Add($"Item {i}");
        //    }

        //    // Display first page
        //    currentPage = 1;
        //    DisplayPage(currentPage);
        //}
        //private void DisplayPage(int page)
        //{
        //    int startIndex = (page - 1) * PageSize;
        //    int endIndex = Math.Min(startIndex + PageSize - 1, data.Count - 1);

        //    // Display data for the current page
        //    listBox1.Items.Clear();
        //    for (int i = startIndex; i <= endIndex; i++)
        //    {
        //        listBox1.Items.Add(data[i]);
        //    }

        //    // Update label to show current page and total pages
        //    label1.Text = $"Page {page} of {TotalPages()}";
        //}

        //private int TotalPages()
        //{
        //    return (int)Math.Ceiling((double)data.Count / PageSize);
        //}

        //private void btnNext_Click(object sender, EventArgs e)
        //{
        //    if (currentPage < TotalPages())
        //    {
        //        currentPage++;
        //        DisplayPage(currentPage);
        //    }
        //}

        //private void btnPrev_Click(object sender, EventArgs e)
        //{
        //    if (currentPage > 1)
        //    {
        //        currentPage--;
        //        DisplayPage(currentPage);
        //    }
        //}
        public Form1()
        {
            InitializeComponents();
        }
        private NumericUpDown numericUpDown;
        private Button prevButton;
        private Button nextButton;
        private void InitializeComponents()
        {
        this.numericUpDown = new NumericUpDown();
        this.prevButton = new Button();
        this.nextButton = new Button();

        // Numeric Up Down
        this.numericUpDown.Location = new System.Drawing.Point(10, 10);
        this.numericUpDown.Size = new System.Drawing.Size(50, 20);
        this.numericUpDown.Minimum = 1;
        this.numericUpDown.Maximum = 10; // Assuming you have 10 pages
        this.numericUpDown.Value = 1;

        // Previous Button
        this.prevButton.Text = "Prev";
        this.prevButton.Location = new System.Drawing.Point(70, 10);
        this.prevButton.Click += (sender, e) =>
        {
            if (this.numericUpDown.Value > 1)
            {
            this.numericUpDown.Value--;
        }
        };

        // Next Button
        this.nextButton.Text = "Next";
        this.nextButton.Location = new System.Drawing.Point(130, 10);
        this.nextButton.Click += (sender, e) =>
        {
            if (this.numericUpDown.Value< 10) // Assuming you have 10 pages
            {
            this.numericUpDown.Value++;
        }
        };

        // Add controls to form
        this.Controls.Add(this.numericUpDown);
        this.Controls.Add(this.prevButton);
        this.Controls.Add(this.nextButton);

        this.Size = new System.Drawing.Size(200, 50);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Pagination Example";
    }

}
}
