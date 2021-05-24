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
    public partial class Form2 : Form
    {

        Label lb1 = new Label();


        public Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load);
        }

        private void Form2_Load(object sender,EventArgs e)
        {
            this.Controls.Add(lb1);

            double x, ksi=0;

             for(int i=0; i<50; i++)
            {
            //---------------------------------------------------------------------
            /*----СЮДА----*/
            x = ksi * ksi * ksi - 2 * ksi * ksi + 3 * ksi - 5;
                //---------------------------------------------------------------------
               ksi = x;
            }
            lb1.Location = new Point(30, 30);
            lb1.Width = 500;
            lb1.Text = "Якщо функція збіжна то корінь дорівнює = ksi[50] " + ksi;

        }





    }
}
