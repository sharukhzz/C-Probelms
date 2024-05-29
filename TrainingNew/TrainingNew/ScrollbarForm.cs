//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Drawing.Drawing2D;

//namespace TrainingNew
//{
//    public partial class ScrollbarForm : Form
//    {
//        public ScrollbarForm()
//        {
//            InitializeComponent();
//        }
//        private Graphics graphics;
//        Rectangle rectangle;
//        private void panel1_Paint(object sender, PaintEventArgs e)
//        {
//            graphics = e.Graphics;
//            graphics.SmoothingMode = SmoothingMode.AntiAlias;
//            rectangle=new Rectangle(panel1.Width-20,0,)
//            graphics.FillRectangle(Brushes.Gray, rectangle);

//            //graphics = e.Graphics;
//            //contentheight = Convert.ToInt32(graphics.MeasureString(richTextBox1.Text, richTextBox1.Font));
//            //graphics.SmoothingMode = SmoothingMode.AntiAlias;
//            //if (y < ClientSize.Height && y >= 0)
//            //{
//            //    rectangle = new Rectangle(0, y, panel1.Width, 80);
//            //}
//            //int scrollAmount = y - rectangle.X;
//            //foreach (Control c in Controls)
//            //{
//            //    if(c==richTextBox1)
//            //    c.Location = new Point(c.Location.X, c.Location.Y - scrollAmount );
//            //}
//            //graphics.FillRectangle(Brushes.Red, rectangle);

//        }

//        private int CalculateThumbHeight()
//        {
//            return Math.Max(20, panel1.Height * panel1.Height / contentheight);
//        }

//        protected override void OnMouseWheel(MouseEventArgs e)
//        {
//            base.OnMouseWheel(e);
//        }

//        bool isDrag;
//        private int sy,y=0,contentheight;

//        private void richTextBox1_TextChanged(object sender, EventArgs e)
//        {
//            richTextBox1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum commodo lectus eget tincidunt tincidunt. Integer et ullamcorper ex. Sed tempus, lorem in dapibus ultricies, quam justo efficitur risus, vel scelerisque ligula neque nec libero. Integer at nunc quis metus eleifend vulputate a at purus. Phasellus ac risus auctor, efficitur justo at, luctus felis. Vivamus nec congue magna. Proin congue orci sed purus vehicula, eget malesuada elit lobortis. Fusce malesuada tincidunt quam nec mattis. Ut ac velit nec odio vehicula fermentum sit amet at tellus. Sed id justo nec orci mollis tincidunt. Vivamus dictum neque vitae tempor ultrices. Duis at arcu nec justo tristique aliquet. Nullam rhoncus felis quis libero molestie, nec malesuada orci vestibulum. Donec eget risus ut odio eleifend accumsan. Vivamus pulvinar justo ut ex tincidunt, vel consequat quam fermentum. Sed in nisi a mi fringilla mattis. Integer consectetur sit amet lorem nec rhoncus. Aliquam mattis mi at ante vulputate interdum. Vivamus elementum tellus eu ipsum rutrum, vitae vulputate velit eleifend. Etiam luctus, elit nec lacinia sagittis, mauris eros vestibulum est, ac imperdiet purus nisi at libero. Integer sed nisi ac sapien commodo viverra. Sed elementum velit sit amet dui tincidunt, ac bibendum eros faucibus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis pharetra purus non mi placerat lobortis. Nullam efficitur nisl nec sapien aliquet, nec scelerisque lorem tristique. Curabitur euismod nibh vel lacus viverra, et vehicula leo fringilla. Mauris nec neque et purus suscipit efficitur. Nam vulputate odio vitae sapien posuere, ut bibendum odio rutrum. Suspendisse consectetur orci sed orci lacinia, sit amet egestas neque molestie. Integer in convallis libero. Phasellus vestibulum justo in ante sagittis, nec vehicula lacus interdum. Sed ultricies, mauris ac ultricies varius, leo metus suscipit ipsum, eu accumsan mauris nisi eu turpis. Sed et lacus ac lacus malesuada euismod. In hac habitasse platea dictumst. In ut dui sit amet nulla facilisis eleifend. Sed vehicula, erat ut rhoncus laoreet, elit mi tristique velit, non rutrum magna lorem eu nibh. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam ut efficitur odio. Phasellus at elit justo. Fusce vel velit eget neque blandit rhoncus ac sed sem. Phasellus in elit efficitur, lacinia nulla sed, suscipit tortor. Curabitur id lectus vel nunc tristique elementum vel sed neque. Nulla consectetur felis id bibendum sollicitudin. Fusce euismod pharetra tellus, sed sollicitudin velit euismod ac. In gravida dolor nec velit imperdiet, eget venenatis urna auctor. Proin viverra velit id est pellentesque, in efficitur nisi pharetra. Duis quis dui efficitur, fermentum lectus in, pulvinar velit. Nullam et magna id dui pretium vehicula nec eu leo. Sed non tincidunt justo. Cras sed tellus sed est malesuada condimentum in at tellus. Vestibulum auctor, enim ac convallis finibus, eros lectus imperdiet libero, eu egestas lorem lacus in nunc. Etiam non mi sed dolor dictum tincidunt a id mi. Suspendisse ultrices ut odio sed euismod. Donec et consectetur orci. Ut vel scelerisque sem, id laoreet purus. Sed pulvinar risus nec justo tristique, vitae placerat neque ullamcorper. Mauris varius nibh ut orci luctus, vel rhoncus enim molestie. Integer consequat fringilla purus, eu lobortis sapien lacinia sit amet. Nullam mattis magna a lectus efficitur, id convallis dui eleifend. Morbi vulputate scelerisque justo, vel luctus nisi. Vivamus ut lectus a odio malesuada tristique. Morbi id justo eget velit laoreet pulvinar vel nec arcu. Integer pretium metus nec nisi dictum, id tincidunt ligula interdum. Nullam id lectus nulla. Fusce ac lacus elementum, suscipit eros nec, malesuada sapien. Vivamus finibus eros a velit aliquet, vel lacinia ipsum euismod. Sed pretium lorem ut mauris lobortis, nec dictum mauris bibendum. Duis auctor eleifend sem, eu pharetra urna dictum at. Morbi interdum lobortis purus, nec pulvinar felis. In feugiat sem et nunc luctus aliquam. Aliquam euismod velit in tristique vestibulum. Sed efficitur vulputate arcu, non gravida felis mollis eget. Etiam convallis quam ut neque viverra, eget interdum odio aliquam. Curabitur convallis id magna id fringilla. Curabitur volutpat eu nunc eu pharetra. Vestibulum ac scelerisque erat. Nulla facilisi. Mauris ut lacus et felis tincidunt egestas a sed dui. Curabitur imperdiet lacinia ex, nec cursus metus luctus id. Duis non dictum nibh. Phasellus in commodo sapien. Proin gravida sem eu orci efficitur ultrices. Phasellus mattis posuere lorem sit amet venenatis. Nam mattis, nisi at ultricies consequat, tellus nulla suscipit tortor, vel tincidunt lacus arcu eget libero. Nullam id sapien eu odio blandit ultrices. In hac habitasse platea dictumst. Nam sed diam volutpat, pulvinar metus eu, vulputate dolor. Ut ut nisi ipsum. Vivamus ut fringilla justo. Donec eu urna nec urna aliquam bibendum non eu urna. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Ut placerat nisl ac dolor posuere, quis convallis turpis lobortis. Curabit";
//        }

//        private void panel1_MouseDown(object sender, MouseEventArgs e)
//        {
//            isDrag = true;
//            sy = e.Y;
//        }

//        private void ScrollbarForm_Load(object sender, EventArgs e)
//        {
//            rectangle.Height = CalculateThumbHeight();
//            rectangle = new Rectangle(panel1.Width - 10, 0, 20, rectangle.Height);
//        }

//        private void panel1_MouseUp(object sender, MouseEventArgs e)
//        {
//            y = e.Y;
//            isDrag = false;
//            panel1.Invalidate();

//        }

//        private void panel1_MouseMove(object sender, MouseEventArgs e)
//        {

//            if (!isDrag) return;
//            y = e.Y-sy;
//            y = Math.Max(0, Math.Min(panel1.Height - rectangle.Height, y));

//            panel1.Invalidate();

//        }
//    }
//}
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TrainingNew
{
    public partial class ScrollbarForm : Form
    {
        private Graphics graphics;
        private Rectangle thumbRectangle;
        private bool isDragging;
        private int initialMouseY;
        private int contentHeight = 20000; // Example content height, replace with your actual content height
        private int thumbHeight;

        public ScrollbarForm()
        {
            InitializeComponent();
            this.Load += ScrollbarForm_Load;
            this.panel1.Paint += panel1_Paint;
            this.panel1.MouseDown += panel1_MouseDown;
            this.panel1.MouseMove += panel1_MouseMove;
            this.panel1.MouseUp += panel1_MouseUp;
            this.richTextBox1.TextChanged += richTextBox1_TextChanged;
        }

        private void ScrollbarForm_Load(object sender, EventArgs e)
        {
            thumbHeight = CalculateThumbHeight();
            thumbRectangle = new Rectangle(panel1.Width - 20, 0, 20, thumbHeight);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.FillRectangle(Brushes.Gray, thumbRectangle);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (thumbRectangle.Contains(e.Location))
            {
                isDragging = true;
                initialMouseY = e.Y - thumbRectangle.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int newY = e.Y - initialMouseY;

                // Limit the thumb movement within the panel bounds
                newY = Math.Max(0, Math.Min(panel1.Height - thumbHeight, newY));
                thumbRectangle.Y = newY;

                // Calculate and update content position based on thumb position
                float scrollRatio = (float)thumbRectangle.Y / (panel1.Height - thumbHeight);
                int contentOffset = (int)(scrollRatio * (contentHeight - panel1.Height));
                richTextBox1.Location = new Point(richTextBox1.Location.X, -contentOffset);

                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private int CalculateThumbHeight()
        {
            return Math.Max(20, panel1.Height * panel1.Height / contentHeight);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum commodo lectus eget tincidunt tincidunt. Integer et ullamcorper ex. Sed tempus, lorem in dapibus ultricies, quam justo efficitur risus, vel scelerisque ligula neque nec libero. Integer at nunc quis metus eleifend vulputate a at purus. Phasellus ac risus auctor, efficitur justo at, luctus felis. Vivamus nec congue magna. Proin congue orci sed purus vehicula, eget malesuada elit lobortis. Fusce malesuada tincidunt quam nec mattis. Ut ac velit nec odio vehicula fermentum sit amet at tellus. Sed id justo nec orci mollis tincidunt. Vivamus dictum neque vitae tempor ultrices. Duis at arcu nec justo tristique aliquet. Nullam rhoncus felis quis libero molestie, nec malesuada orci vestibulum. Donec eget risus ut odio eleifend accumsan. Vivamus pulvinar justo ut ex tincidunt, vel consequat quam fermentum. Sed in nisi a mi fringilla mattis. Integer consectetur sit amet lorem nec rhoncus. Aliquam mattis mi at ante vulputate interdum. Vivamus elementum tellus eu ipsum rutrum, vitae vulputate velit eleifend. Etiam luctus, elit nec lacinia sagittis, mauris eros vestibulum est, ac imperdiet purus nisi at libero. Integer sed nisi ac sapien commodo viverra. Sed elementum velit sit amet dui tincidunt, ac bibendum eros faucibus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis pharetra purus non mi placerat lobortis. Nullam efficitur nisl nec sapien aliquet, nec scelerisque lorem tristique. Curabitur euismod nibh vel lacus viverra, et vehicula leo fringilla. Mauris nec neque et purus suscipit efficitur. Nam vulputate odio vitae sapien posuere, ut bibendum odio rutrum. Suspendisse consectetur orci sed orci lacinia, sit amet egestas neque molestie. Integer in convallis libero. Phasellus vestibulum justo in ante sagittis, nec vehicula lacus interdum. Sed ultricies, mauris ac ultricies varius, leo metus suscipit ipsum, eu accumsan mauris nisi eu turpis. Sed et lacus ac lacus malesuada euismod. In hac habitasse platea dictumst. In ut dui sit amet nulla facilisis eleifend. Sed vehicula, erat ut rhoncus laoreet, elit mi tristique velit, non rutrum magna lorem eu nibh. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam ut efficitur odio. Phasellus at elit justo. Fusce vel velit eget neque blandit rhoncus ac sed sem. Phasellus in elit efficitur, lacinia nulla sed, suscipit tortor. Curabitur id lectus vel nunc tristique elementum vel sed neque. Nulla consectetur felis id bibendum sollicitudin. Fusce euismod pharetra tellus, sed sollicitudin velit euismod ac. In gravida dolor nec velit imperdiet, eget venenatis urna auctor. Proin viverra velit id est pellentesque, in efficitur nisi pharetra. Duis quis dui efficitur, fermentum lectus in, pulvinar velit. Nullam et magna id dui pretium vehicula nec eu leo. Sed non tincidunt justo. Cras sed tellus sed est malesuada condimentum in at tellus. Vestibulum auctor, enim ac convallis finibus, eros lectus imperdiet libero, eu egestas lorem lacus in nunc. Etiam non mi sed dolor dictum tincidunt a id mi. Suspendisse ultrices ut odio sed euismod. Donec et consectetur orci. Ut vel scelerisque sem, id laoreet purus. Sed pulvinar risus nec justo tristique, vitae placerat neque ullamcorper. Mauris varius nibh ut orci luctus, vel rhoncus enim molestie. Integer consequat fringilla purus, eu lobortis sapien lacinia sit amet. Nullam mattis magna a lectus efficitur, id convallis dui eleifend. Morbi vulputate scelerisque justo, vel luctus nisi. Vivamus ut lectus a odio malesuada tristique. Morbi id justo eget velit laoreet pulvinar vel nec arcu. Integer pretium metus nec nisi dictum, id tincidunt ligula interdum. Nullam id lectus nulla. Fusce ac lacus elementum, suscipit eros nec, malesuada sapien. Vivamus finibus eros a velit aliquet, vel lacinia ipsum euismod. Sed pretium lorem ut mauris lobortis, nec dictum mauris bibendum. Duis auctor eleifend sem, eu pharetra urna dictum at. Morbi interdum lobortis purus, nec pulvinar felis. In feugiat sem et nunc luctus aliquam. Aliquam euismod velit in tristique vestibulum. Sed efficitur vulputate arcu, non gravida felis mollis eget. Etiam convallis quam ut neque viverra, eget interdum odio aliquam. Curabitur convallis id magna id fringilla. Curabitur volutpat eu nunc eu pharetra. Vestibulum ac scelerisque erat. Nulla facilisi. Mauris ut lacus et felis tincidunt egestas a sed dui. Curabitur imperdiet lacinia ex, nec cursus metus luctus id. Duis non dictum nibh. Phasellus in commodo sapien. Proin gravida sem eu orci efficitur ultrices. Phasellus mattis posuere lorem sit amet venenatis. Nam mattis, nisi at ultricies consequat, tellus nulla suscipit tortor, vel tincidunt lacus arcu eget libero. Nullam id sapien eu odio blandit ultrices. In hac habitasse platea dictumst. Nam sed diam volutpat, pulvinar metus eu, vulputate dolor. Ut ut nisi ipsum. Vivamus ut fringilla justo. Donec eu urna nec urna aliquam bibendum non eu urna. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Ut placerat nisl ac dolor posuere, quis convallis turpis lobortis. Curabit";
        }
    }
}
