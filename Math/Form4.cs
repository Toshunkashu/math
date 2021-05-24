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
    public partial class Form4 : Form
    {
        TextBox tb1 = new TextBox();
        RadioButton rb1 = new RadioButton();
        RadioButton rb2 = new RadioButton();
        Label fx = new Label();
        Button bt1 = new Button();


        public Form4()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form4_Load);
            bt1.Click += new EventHandler(bt1_click);
        }


        private double f(double x) //Початкова функція, змінити після у = 
        {
            double y = 0;
            y = 4 * x - 7 * System.Math.Sin(x);
            return y;
        }

        private double f_p1 (double x) //Пoхідна функція першого порядку, змінити після у = 
        {
            double y = 0;
            y = 4 - 7 * System.Math.Cos(x);
            return y;
        }

        private double f_p2(double x) //Пoхідна функція другого порядку, змінити після у = 
        {
            double y = 0;
            y = 7 * System.Math.Sin(x);
            return y;
        }




        private void Form4_Load(object sender,EventArgs e)
        {
            this.Controls.Add(bt1);
            this.Controls.Add(rb1);
            this.Controls.Add(rb2);
            this.Controls.Add(fx);

            rb1.Location = new Point(20, 20);
            rb1.Text = "x > 0";
            rb1.Width = 50;

            rb2.Location = new Point(70, 20);
            rb2.Text = "x < 0";
            rb2.Width = 50;

            fx.Location = new Point(20,100);
            fx.Text = "f(x) = ";
            fx.Width = 500;

            bt1.Location = new Point(20, 150);
            bt1.Text = "Run";



            
        }
        private void bt1_click(object sender, EventArgs e)
        {

            double F, F1, GA = 0, GB = 0, Formul = 0, lich = 0, si1;

            if (rb1.Checked == true)
            {
                double A = -2, B = -1;

                do
                {
                    A = B; B++;
                    F = f(A);
                    F1 = f(B);
                    GA = A; GB = B;
                    lich++;
                    if (lich >= 1000)
                    {
                        fx.Text = "В цій області коренів не існує. ";
                        goto exit;
                    }
                } while ((F > 0 && F1 > 0) || (F < 0 && F1 < 0) || (lich >= 1000));
            }
            else if (rb2.Checked == true)
            {
                double B = 2, A = 1;
                do
                {

                    A = B; B --;
                    F = f(A);
                    F1 = f(B);
                    GA = A; GB = B;
                    lich++;
                    if (lich >= 1000)
                    {
                        fx.Text = "В цій області коренів не існує. ";
                        goto exit;
                    }
                } while ((F > 0 && F1 > 0) || (F < 0 && F1 < 0) || (lich >= 1000)); ;
            }
            F = f_p1(GA);
            F1 = f_p2(GA);
            if ((F > 0 && F1 > 0) || (F < 0 && F1 < 0))
            {
                Formul = 1;
                for (int i = 0; i < 20; i++)
                {
                    si1 = GB - (f(GB)/f_p1(GB));
                    GB = si1;


                }
            }
            else
            {
                Formul = 2;
                for (int i = 0; i < 20; i++)
                {
                    si1 = GA - (f(GA)/f_p1(GA));
                    GA = si1;

                }
            }

            fx.Text += "f' = " + F + "|  f'' =  " + F1 + " | B = " + GB + " | A = " + GA + " | Formula " + Formul;



        exit:;


        }
    }
}
