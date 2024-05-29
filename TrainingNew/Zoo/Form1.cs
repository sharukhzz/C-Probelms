using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<IAnimal> list = new List<IAnimal>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Lion lion = new Lion("lion","21","Carnivore",11);
            list.Add(lion);
            richTextBox1.Text = lion.AnimalName + lion.Age + lion.Species +lion.Sizes+ lion.MakeSound();
            Elepant elepant = new Elepant("Elephanth", "22", "Herbivore", 200);
            list.Add(elepant);
            richTextBox2.Text = elepant.AnimalName + elepant.Age + elepant.Species + elepant.TuskLength + lion.MakeSound();
            foreach(var item in list)
            {
                richTextBox3.Text+=item.MakeSound();
            }
        }
    }
}
