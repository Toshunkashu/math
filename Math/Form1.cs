using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math
{
    public partial class Form1 : Form
    {
        Label label1 = new Label();
        Label label2 = new Label();
        Label label3 = new Label();

        Button buton1 = new Button();
        Button buton2 = new Button();
        Button buton3 = new Button();




        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            buton1.Click += new EventHandler(buton1_click);
            buton2.Click += new EventHandler(buton2_click);
            buton3.Click += new EventHandler(buton3_click);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);

            this.Controls.Add(buton1);
            this.Controls.Add(buton2);
            this.Controls.Add(buton3);


            label1.Location = new Point(20, 50);
            label1.Text = "Метод послідовних наближень";
            label1.Width = 180;

            label2.Location = new Point(20, 100);
            label2.Text = "Ітерація дотичними";
            label2.Width = 100;

            label3.Location = new Point(20, 150);
            label3.Text = "null";


            buton1.Width = 100;
            buton1.Height = 50;
            buton1.Location = new Point(200, 50 + (label1.Height / 3) - (buton1.Height / 2));
            buton1.Text = "Run";

            buton2.Width = 100;
            buton2.Height = 50;
            buton2.Location = new Point(200, 100 + (label2.Height / 3) - (buton2.Height / 2));
            buton2.Text = "Run";

            buton3.Width = 100;
            buton3.Height = 50;
            buton3.Location = new Point(200, 150 + (label3.Height / 3) - (buton3.Height / 2));
            buton3.Text = "Run";

            buton1.Enabled = false;
            buton1.Visible = false;
            label1.Visible = false;
            buton3.Enabled = false;
            buton3.Visible = false;
            label3.Visible = false;
        }


        private void buton1_click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void buton2_click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void buton3_click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

    }
}
