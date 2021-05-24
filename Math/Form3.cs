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
    public partial class Form3 : Form
    {
        RadioButton rb1 = new RadioButton();
        RadioButton rb2 = new RadioButton();
        Label label1 = new Label();
        Label f = new Label();
        Label f1 = new Label();
        Label f2 = new Label();
        Label fx = new Label();
        Button buton1 = new Button();
        

        TextBox a = new TextBox();
        TextBox a1 = new TextBox();
        TextBox b = new TextBox();
        TextBox b1 = new TextBox();
        TextBox c = new TextBox();
        TextBox c1 = new TextBox();
        TextBox d = new TextBox();
        TextBox d1 = new TextBox();
        TextBox E = new TextBox();
        TextBox E1 = new TextBox();
        Label x1 = new Label();
        Label x2 = new Label();
        Label x3 = new Label();
        Label x4 = new Label();
        Label x5 = new Label();
        //-------------------------
        TextBox a_p1 = new TextBox();
        TextBox a1_p1 = new TextBox();
        TextBox b_p1 = new TextBox();
        TextBox b1_p1 = new TextBox();
        TextBox c_p1 = new TextBox();
        TextBox c1_p1 = new TextBox();
        TextBox d_p1 = new TextBox();
        TextBox d1_p1 = new TextBox();
        TextBox E_p1 = new TextBox();
        TextBox E1_p1 = new TextBox();
        Label x1_p1 = new Label();
        Label x2_p1 = new Label();
        Label x3_p1 = new Label();
        Label x4_p1 = new Label();
        Label x5_p1 = new Label();
        //---------------------------
        TextBox a_p2 = new TextBox();
        TextBox a1_p2 = new TextBox();
        TextBox b_p2 = new TextBox();
        TextBox b1_p2 = new TextBox();
        TextBox c_p2 = new TextBox();
        TextBox c1_p2 = new TextBox();
        TextBox d_p2 = new TextBox();
        TextBox d1_p2 = new TextBox();
        TextBox E_p2 = new TextBox();
        TextBox E1_p2 = new TextBox();
        Label x1_p2 = new Label();
        Label x2_p2 = new Label();
        Label x3_p2 = new Label();
        Label x4_p2 = new Label();
        Label x5_p2 = new Label();


        public Form3()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form3_Load);
            buton1.Click += new EventHandler(buton1_click);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Controls.Add(rb1);
            this.Controls.Add(rb2);
            this.Controls.Add(label1);
            this.Controls.Add(f);
            this.Controls.Add(f1);
            this.Controls.Add(f2);
            this.Controls.Add(fx);
            this.Controls.Add(buton1);

            this.Controls.Add(a);
            this.Controls.Add(a1);
            this.Controls.Add(b);
            this.Controls.Add(b1);
            this.Controls.Add(c);
            this.Controls.Add(c1);
            this.Controls.Add(d);
            this.Controls.Add(d1);
            this.Controls.Add(E);
            this.Controls.Add(E1);
            this.Controls.Add(x1);
            this.Controls.Add(x2);
            this.Controls.Add(x3);
            this.Controls.Add(x4);
            this.Controls.Add(x5);
            //---------------------
            this.Controls.Add(a_p1);
            this.Controls.Add(a1_p1);
            this.Controls.Add(b_p1);
            this.Controls.Add(b1_p1);
            this.Controls.Add(c_p1);
            this.Controls.Add(c1_p1);
            this.Controls.Add(d_p1);
            this.Controls.Add(d1_p1);
            this.Controls.Add(E_p1);
            this.Controls.Add(E1_p1);
            this.Controls.Add(x1_p1);
            this.Controls.Add(x2_p1);
            this.Controls.Add(x3_p1);
            this.Controls.Add(x4_p1);
            this.Controls.Add(x5_p1);
            //-----------------------
            this.Controls.Add(a_p2);
            this.Controls.Add(a1_p2);
            this.Controls.Add(b_p2);
            this.Controls.Add(b1_p2);
            this.Controls.Add(c_p2);
            this.Controls.Add(c1_p2);
            this.Controls.Add(d_p2);
            this.Controls.Add(d1_p2);
            this.Controls.Add(E_p2);
            this.Controls.Add(E1_p2);
            this.Controls.Add(x1_p2);
            this.Controls.Add(x2_p2);
            this.Controls.Add(x3_p2);
            this.Controls.Add(x4_p2);
            this.Controls.Add(x5_p2);



            rb1.Location = new Point(20, 20);
            rb1.Text = "x > 0";
            rb1.Width = 50;

            rb2.Location = new Point(70, 20);
            rb2.Text = "x < 0";
            rb2.Width = 50;

            label1.Location = new Point(15,5);
            label1.Width = 200;
            label1.Text = "Корінь повинен бути:";

            fx.Location = new Point(20, 300);
            fx.Text = "f(x) = ";
            fx.Width = 500;


            f.Location = new Point(20,52);
            f.Text = "f(x) = ";
            f.Width = 30;

            a.Location = new Point(50,50);
            a.Width = 30;

            a1.Location = new Point(93,42);
            a1.Width = 15;
            a1.Height = 12;

            b.Location = new Point(120,50);
            b.Width = 30;

            b1.Location = new Point(163,42);
            b1.Width = 15;
            b1.Height = 12;

            c.Location = new Point(190,50);
            c.Width = 30;

            c1.Location = new Point(233,42);
            c1.Width = 15;
            c1.Height = 12;

            d.Location = new Point(260,50);
            d.Width = 50;

            d1.Location = new Point(323,42);
            d1.Width = 15;
            b1.Height = 12;

            E.Location = new Point(350,50);
            E.Width = 50;

            E1.Location = new Point(413,42);
            E1.Width = 15;
            E1.Height = 12;

            x1.Location = new Point(80,53);
            x1.Text = "X       +";
            x1.Width = 50;

            x2.Location = new Point(150,53);
            x2.Text = "X       +";
            x2.Width = 50;

            x3.Location = new Point(220,53);
            x3.Text = "X       +";
            x3.Width = 50;

            x4.Location = new Point(310,53);
            x4.Text = "X       +";
            x4.Width = 50;

            x5.Location = new Point(400,53);
            x5.Text = "X       = 0";
            x5.Width = 50;
            //----------------------
            f1.Location = new Point(15, 102);
            f1.Text = "f(x)' = ";
            f1.Width = 35;

            a_p1.Location = new Point(50, 100);
            a_p1.Width = 30;

            a1_p1.Location = new Point(93, 92);
            a1_p1.Width = 15;
            a1_p1.Height = 12;

            b_p1.Location = new Point(120, 100);
            b_p1.Width = 30;

            b1_p1.Location = new Point(163, 92);
            b1_p1.Width = 15;
            b1_p1.Height = 12;

            c_p1.Location = new Point(190, 100);
            c_p1.Width = 30;

            c1_p1.Location = new Point(233, 92);
            c1_p1.Width = 15;
            c1_p1.Height = 12;

            d_p1.Location = new Point(260, 100);
            d_p1.Width = 50;

            d1_p1.Location = new Point(323, 92);
            d1_p1.Width = 15;
            b1_p1.Height = 12;

            E_p1.Location = new Point(350, 100);
            E_p1.Width = 50;

            E1_p1.Location = new Point(413, 92);
            E1_p1.Width = 15;
            E1_p1.Height = 12;

            x1_p1.Location = new Point(80, 103);
            x1_p1.Text = "X       +";
            x1_p1.Width = 50;

            x2_p1.Location = new Point(150, 103);
            x2_p1.Text = "X       +";
            x2_p1.Width = 50;

            x3_p1.Location = new Point(220, 103);
            x3_p1.Text = "X       +";
            x3_p1.Width = 50;

            x4_p1.Location = new Point(310, 103);
            x4_p1.Text = "X       +";
            x4_p1.Width = 50;

            x5_p1.Location = new Point(400, 103);
            x5_p1.Text = "X       = 0";
            x5_p1.Width = 50;
            //-------------------------
            f2.Location = new Point(14, 152);
            f2.Text = "f(x)'' = ";
            f2.Width = 35;

            a_p2.Location = new Point(50, 150);
            a_p2.Width = 30;

            a1_p2.Location = new Point(93, 142);
            a1_p2.Width = 15;
            a1_p2.Height = 12;

            b_p2.Location = new Point(120, 150);
            b_p2.Width = 30;

            b1_p2.Location = new Point(163, 142);
            b1_p2.Width = 15;
            b1_p2.Height = 12;

            c_p2.Location = new Point(190, 150);
            c_p2.Width = 30;

            c1_p2.Location = new Point(233, 142);
            c1_p2.Width = 15;
            c1_p2.Height = 12;

            d_p2.Location = new Point(260, 150);
            d_p2.Width = 50;

            d1_p2.Location = new Point(323, 142);
            d1_p2.Width = 15;
            b1_p2.Height = 12;

            E_p2.Location = new Point(350, 150);
            E_p2.Width = 50;

            E1_p2.Location = new Point(413, 142);
            E1_p2.Width = 15;
            E1_p2.Height = 12;

            x1_p2.Location = new Point(80, 153);
            x1_p2.Text = "X       +";
            x1_p2.Width = 50;

            x2_p2.Location = new Point(150, 153);
            x2_p2.Text = "X       +";
            x2_p2.Width = 50;

            x3_p2.Location = new Point(220, 153);
            x3_p2.Text = "X       +";
            x3_p2.Width = 50;

            x4_p2.Location = new Point(310, 153);
            x4_p2.Text = "X       +";
            x4_p2.Width = 50;

            x5_p2.Location = new Point(400, 153);
            x5_p2.Text = "X       = 0";
            x5_p2.Width = 50;

            buton1.Location = new Point(480, 100-(buton1.Height/2));
            buton1.Width = 100;
            buton1.Height = 50;
            buton1.Text = "START";

        }

        

        private void buton1_click(object sender, EventArgs e)
        {
            double F, F1, GA=0, GB=0, Formul=0,lich=0,si1;
            if (rb1.Checked== true)
            {
                double A = -2, B = -1;
                try
                {
                    do
                    {
                        A = B; B ++;
                        F = Convert.ToDouble(a.Text) * System.Math.Pow(A, Convert.ToDouble(a1.Text)) + Convert.ToDouble(b.Text) * System.Math.Pow(A, Convert.ToDouble(b1.Text)) + Convert.ToDouble(c.Text) * System.Math.Pow(A, Convert.ToDouble(c1.Text)) + Convert.ToDouble(d.Text) * System.Math.Pow(A, Convert.ToDouble(d1.Text)) + Convert.ToDouble(E.Text) * System.Math.Pow(A, Convert.ToDouble(E1.Text));
                        F1 = Convert.ToDouble(a.Text) * System.Math.Pow(B, Convert.ToDouble(a1.Text)) + Convert.ToDouble(b.Text) * System.Math.Pow(B, Convert.ToDouble(b1.Text)) + Convert.ToDouble(c.Text) * System.Math.Pow(B, Convert.ToDouble(c1.Text)) + Convert.ToDouble(d.Text) * System.Math.Pow(B, Convert.ToDouble(d1.Text)) + Convert.ToDouble(E.Text) * System.Math.Pow(B, Convert.ToDouble(E1.Text));
                        GA = A; GB = B;
                        lich++;
                        if (lich >= 20) {
                            fx.Text = "В цій області коренів не існує.";
                            goto exit;
                        }
                    } while ((F > 0 && F1 > 0) || (F < 0 && F1 < 0)|| (lich>=20));
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
           else if(rb2.Checked==true)
            {
                double B = 2, A = 1;
                do
                {

                    A = B; B --;
                    F = Convert.ToDouble(a.Text) * System.Math.Pow(B, Convert.ToDouble(a1.Text)) + Convert.ToDouble(b.Text) * System.Math.Pow(B, Convert.ToDouble(b1.Text)) + Convert.ToDouble(c.Text) * System.Math.Pow(B, Convert.ToDouble(c1.Text)) + Convert.ToDouble(d.Text) * System.Math.Pow(B, Convert.ToDouble(d1.Text)) + Convert.ToDouble(E.Text) * System.Math.Pow(B, Convert.ToDouble(E1.Text));
                    F1 = Convert.ToDouble(a.Text) * System.Math.Pow(A, Convert.ToDouble(a1.Text)) + Convert.ToDouble(b.Text) * System.Math.Pow(A, Convert.ToDouble(b1.Text)) + Convert.ToDouble(c.Text) * System.Math.Pow(A, Convert.ToDouble(c1.Text)) + Convert.ToDouble(d.Text) * System.Math.Pow(A, Convert.ToDouble(d1.Text)) + Convert.ToDouble(E.Text) * System.Math.Pow(A, Convert.ToDouble(E1.Text));
                    GA = A; GB = B;
                    lich++;
                    if (lich >= 20)
                    {
                        fx.Text = "В цій області коренів не існує.";
                        goto exit;
                    }
                } while ((F > 0 && F1 > 0) || (F < 0 && F1 < 0) || (lich >= 20)); ;
            }
            F= Convert.ToDouble(a_p1.Text) * System.Math.Pow(GA, Convert.ToDouble(a1_p1.Text)) + Convert.ToDouble(b_p1.Text) * System.Math.Pow(GA, Convert.ToDouble(b1_p1.Text)) + Convert.ToDouble(c_p1.Text) * System.Math.Pow(GA, Convert.ToDouble(c1_p1.Text)) + Convert.ToDouble(d_p1.Text) * System.Math.Pow(GA, Convert.ToDouble(d1_p1.Text)) + Convert.ToDouble(E_p1.Text) * System.Math.Pow(GA, Convert.ToDouble(E1_p1.Text));
            F1= Convert.ToDouble(a_p2.Text) * System.Math.Pow(GA, Convert.ToDouble(a1_p2.Text)) + Convert.ToDouble(b_p2.Text) * System.Math.Pow(GA, Convert.ToDouble(b1_p2.Text)) + Convert.ToDouble(c_p2.Text) * System.Math.Pow(GA, Convert.ToDouble(c1_p2.Text)) + Convert.ToDouble(d_p2.Text) * System.Math.Pow(GA, Convert.ToDouble(d1_p2.Text)) + Convert.ToDouble(E_p2.Text) * System.Math.Pow(GA, Convert.ToDouble(E1_p2.Text));
            if ((F > 0 && F1 > 0) || (F < 0 && F1 < 0))
            {
                Formul = 1;
                for (int i = 0; i < 20; i++)
                {
                    si1 = GB - (Convert.ToDouble(a.Text) * System.Math.Pow(GB, Convert.ToDouble(a1.Text)) + Convert.ToDouble(b.Text) * System.Math.Pow(GB, Convert.ToDouble(b1.Text)) + Convert.ToDouble(c.Text) * System.Math.Pow(GB, Convert.ToDouble(c1.Text)) + Convert.ToDouble(d.Text) * System.Math.Pow(GB, Convert.ToDouble(d1.Text)) + Convert.ToDouble(E.Text) * System.Math.Pow(GB, Convert.ToDouble(E1.Text))) / (Convert.ToDouble(a_p1.Text) * System.Math.Pow(GB, Convert.ToDouble(a1_p1.Text)) + Convert.ToDouble(b_p1.Text) * System.Math.Pow(GB, Convert.ToDouble(b1_p1.Text)) + Convert.ToDouble(c_p1.Text) * System.Math.Pow(GB, Convert.ToDouble(c1_p1.Text)) + Convert.ToDouble(d_p1.Text) * System.Math.Pow(GB, Convert.ToDouble(d1_p1.Text)) + Convert.ToDouble(E_p1.Text) * System.Math.Pow(GB, Convert.ToDouble(E1_p1.Text)));
                    GB = si1;


                }
            }
            else
            {
                Formul = 2;
                for (int i = 0; i < 20; i++)
                {
                    si1 = GA - (Convert.ToDouble(a.Text) * System.Math.Pow(GA, Convert.ToDouble(a1.Text)) + Convert.ToDouble(b.Text) * System.Math.Pow(GA, Convert.ToDouble(b1.Text)) + Convert.ToDouble(c.Text) * System.Math.Pow(GA, Convert.ToDouble(c1.Text)) + Convert.ToDouble(d.Text) * System.Math.Pow(GA, Convert.ToDouble(d1.Text)) + Convert.ToDouble(E.Text) * System.Math.Pow(GA, Convert.ToDouble(E1.Text))) / (Convert.ToDouble(a_p1.Text) * System.Math.Pow(GA, Convert.ToDouble(a1_p1.Text)) + Convert.ToDouble(b_p1.Text) * System.Math.Pow(GA, Convert.ToDouble(b1_p1.Text)) + Convert.ToDouble(c_p1.Text) * System.Math.Pow(GA, Convert.ToDouble(c1_p1.Text)) + Convert.ToDouble(d_p1.Text) * System.Math.Pow(GA, Convert.ToDouble(d1_p1.Text)) + Convert.ToDouble(E_p1.Text) * System.Math.Pow(GA, Convert.ToDouble(E1_p1.Text)));
                    GA = si1;

                }
            }
            /* if (Formul == 1)
             {
                 fx.Text += GB;
             }
             else if (Formul == 2)
             {
                 fx.Text += GA;
             }
             else fx.Text += "Error";*/
            fx.Text +="f' = "+F+"|  f'' =  "+F1+" | B = "+ GB+" | A = "+GA+ " | Formula "+Formul;
        exit:;
        }

    }
}
