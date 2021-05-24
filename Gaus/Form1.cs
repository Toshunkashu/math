using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaus
{
    public partial class Form1 : Form
    {
        int size_Matrica=0;

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            size_Matrica = Convert.ToInt32(comboBox1.Text);
            if (comboBox1.Text == null) MessageBox.Show("Поле не може бути пустим!", caption: "Зверніть увагу!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                switch (size_Matrica)
                {
                    case 1:
                        {
                            // textBox1.Visible = true;
                            // label2.Visible = true;
                        }; break;
                    case 2:
                        {
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox11.Visible = true;
                            textBox12.Visible = true;

                            label2.Visible = true;
                            label3.Visible = true;
                            label14.Visible = true;
                            label15.Visible = true;

                            textBox37.Location = textBox4.Location;
                            textBox38.Location = textBox10.Location;
                            label8.Location = label5.Location;
                            label9.Location = label13.Location;

                            textBox37.Visible = true;
                            textBox38.Visible = true;
                            label8.Visible = true;
                            label9.Visible = true;

                            label4.Visible = false;
                            label5.Visible = false;
                            label6.Visible = false;
                            label7.Visible = false;
                            label10.Visible = false;
                            label11.Visible = false;
                            label12.Visible = false;
                            label13.Visible = false;
                            label16.Visible = false;
                            label17.Visible = false;
                            label18.Visible = false;
                            label19.Visible = false;
                            label20.Visible = false;
                            label21.Visible = false;
                            label22.Visible = false;
                            label23.Visible = false;
                            label24.Visible = false;
                            label25.Visible = false;
                            label26.Visible = false;
                            label27.Visible = false;
                            label28.Visible = false;
                            label29.Visible = false;
                            label30.Visible = false;
                            label31.Visible = false;
                            label32.Visible = false;
                            label33.Visible = false;
                            label34.Visible = false;
                            label35.Visible = false;
                            label36.Visible = false;
                            label37.Visible = false;
                            label38.Visible = false;
                            label39.Visible = false;
                            label40.Visible = false;
                            label41.Visible = false;
                            label42.Visible = false;
                            label43.Visible = false;


                            textBox3.Visible = false;
                            textBox4.Visible = false;
                            textBox5.Visible = false;
                            textBox6.Visible = false;
                            textBox7.Visible = false;
                            textBox8.Visible = false;
                            textBox9.Visible = false;
                            textBox10.Visible = false;
                            textBox13.Visible = false;
                            textBox14.Visible = false;
                            textBox15.Visible = false;
                            textBox16.Visible = false;
                            textBox17.Visible = false;
                            textBox18.Visible = false;
                            textBox19.Visible = false;
                            textBox20.Visible = false;
                            textBox21.Visible = false;
                            textBox22.Visible = false;
                            textBox23.Visible = false;
                            textBox24.Visible = false;
                            textBox25.Visible = false;
                            textBox26.Visible = false;
                            textBox27.Visible = false;
                            textBox28.Visible = false;
                            textBox29.Visible = false;
                            textBox30.Visible = false;
                            textBox31.Visible = false;
                            textBox32.Visible = false;
                            textBox33.Visible = false;
                            textBox34.Visible = false;
                            textBox35.Visible = false;
                            textBox36.Visible = false;
                            textBox39.Visible = false;
                            textBox40.Visible = false;
                            textBox41.Visible = false;
                            textBox42.Visible = false;
                        }
                        break;
                    case 3:
                        {
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox4.Visible = true;
                            textBox10.Visible = true;
                            textBox11.Visible = true;
                            textBox12.Visible = true;
                            textBox22.Visible = true;
                            textBox23.Visible = true;
                            textBox24.Visible = true;

                            label2.Visible = true;
                            label3.Visible = true;
                            label5.Visible = true;
                            label13.Visible = true;
                            label14.Visible = true;
                            label15.Visible = true;
                            label27.Visible = true;
                            label28.Visible = true;
                            label29.Visible = true;

                            textBox37.Location = textBox3.Location;
                            textBox38.Location = textBox9.Location;
                            textBox39.Location = textBox21.Location;
                            label8.Location = label4.Location;
                            label9.Location = label12.Location;
                            label23.Location = label26.Location;

                            textBox37.Visible = true;
                            textBox38.Visible = true;
                            textBox39.Visible = true;
                            label8.Visible = true;
                            label9.Visible = true;
                            label23.Visible = true;


                            label6.Visible = false;
                            label7.Visible = false;
                            label10.Visible = false;
                            label11.Visible = false;
                            label16.Visible = false;
                            label17.Visible = false;
                            label18.Visible = false;
                            label19.Visible = false;
                            label20.Visible = false;
                            label21.Visible = false;
                            label22.Visible = false;
                            label24.Visible = false;
                            label25.Visible = false;
                            label26.Visible = false;
                            label30.Visible = false;
                            label31.Visible = false;
                            label32.Visible = false;
                            label33.Visible = false;
                            label34.Visible = false;
                            label35.Visible = false;
                            label36.Visible = false;
                            label37.Visible = false;
                            label38.Visible = false;
                            label39.Visible = false;
                            label40.Visible = false;
                            label41.Visible = false;
                            label42.Visible = false;
                            label43.Visible = false;

                            textBox3.Visible = false;
                            textBox5.Visible = false;
                            textBox6.Visible = false;
                            textBox7.Visible = false;
                            textBox8.Visible = false;
                            textBox9.Visible = false;
                            textBox13.Visible = false;
                            textBox14.Visible = false;
                            textBox15.Visible = false;
                            textBox16.Visible = false;
                            textBox17.Visible = false;
                            textBox18.Visible = false;
                            textBox19.Visible = false;
                            textBox20.Visible = false;
                            textBox21.Visible = false;
                            textBox25.Visible = false;
                            textBox26.Visible = false;
                            textBox27.Visible = false;
                            textBox28.Visible = false;
                            textBox29.Visible = false;
                            textBox30.Visible = false;
                            textBox31.Visible = false;
                            textBox32.Visible = false;
                            textBox33.Visible = false;
                            textBox34.Visible = false;
                            textBox35.Visible = false;
                            textBox36.Visible = false;
                            textBox40.Visible = false;
                            textBox41.Visible = false;
                            textBox42.Visible = false;
                        }
                        break;
                    case 4:
                        {
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;
                            textBox4.Visible = true;
                            textBox9.Visible = true;
                            textBox10.Visible = true;
                            textBox11.Visible = true;
                            textBox12.Visible = true;
                            textBox15.Visible = true;
                            textBox16.Visible = true;
                            textBox17.Visible = true;
                            textBox18.Visible = true;
                            textBox21.Visible = true;
                            textBox22.Visible = true;
                            textBox23.Visible = true;
                            textBox24.Visible = true;

                            label2.Visible = true;
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = true;
                            label12.Visible = true;
                            label13.Visible = true;
                            label14.Visible = true;
                            label15.Visible = true;
                            label19.Visible = true;
                            label20.Visible = true;
                            label21.Visible = true;
                            label22.Visible = true;
                            label26.Visible = true;
                            label27.Visible = true;
                            label28.Visible = true;
                            label29.Visible = true;

                            textBox37.Location = textBox6.Location;
                            textBox38.Location = textBox8.Location;
                            textBox39.Location = textBox20.Location;
                            textBox40.Location = textBox14.Location;
                            label8.Location = label7.Location;
                            label9.Location = label11.Location;
                            label16.Location = label18.Location;
                            label23.Location = label25.Location;

                            textBox37.Visible = true;
                            textBox38.Visible = true;
                            textBox39.Visible = true;
                            textBox40.Visible = true;
                            label8.Visible = true;
                            label9.Visible = true;
                            label16.Visible = true;
                            label23.Visible = true;


                            label6.Visible = false;
                            label7.Visible = false;
                            label10.Visible = false;
                            label11.Visible = false;
                            label17.Visible = false;
                            label18.Visible = false;
                            label24.Visible = false;
                            label25.Visible = false;
                            label30.Visible = false;
                            label31.Visible = false;
                            label32.Visible = false;
                            label33.Visible = false;
                            label34.Visible = false;
                            label35.Visible = false;
                            label36.Visible = false;
                            label37.Visible = false;
                            label38.Visible = false;
                            label39.Visible = false;
                            label40.Visible = false;
                            label41.Visible = false;
                            label42.Visible = false;
                            label43.Visible = false;

                            textBox5.Visible = false;
                            textBox6.Visible = false;
                            textBox7.Visible = false;
                            textBox8.Visible = false;
                            textBox13.Visible = false;
                            textBox14.Visible = false;
                            textBox19.Visible = false;
                            textBox20.Visible = false;
                            textBox25.Visible = false;
                            textBox26.Visible = false;
                            textBox27.Visible = false;
                            textBox28.Visible = false;
                            textBox29.Visible = false;
                            textBox30.Visible = false;
                            textBox31.Visible = false;
                            textBox32.Visible = false;
                            textBox33.Visible = false;
                            textBox34.Visible = false;
                            textBox35.Visible = false;
                            textBox36.Visible = false;
                            textBox41.Visible = false;
                            textBox42.Visible = false;
                        }
                        break;
                    case 5:
                        {
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;
                            textBox4.Visible = true;
                            textBox6.Visible = true;
                            textBox8.Visible = true;
                            textBox9.Visible = true;
                            textBox10.Visible = true;
                            textBox11.Visible = true;
                            textBox12.Visible = true;
                            textBox14.Visible = true;
                            textBox15.Visible = true;
                            textBox16.Visible = true;
                            textBox17.Visible = true;
                            textBox18.Visible = true;
                            textBox20.Visible = true;
                            textBox21.Visible = true;
                            textBox22.Visible = true;
                            textBox23.Visible = true;
                            textBox24.Visible = true;
                            textBox32.Visible = true;
                            textBox33.Visible = true;
                            textBox34.Visible = true;
                            textBox35.Visible = true;
                            textBox36.Visible = true;

                            label2.Visible = true;
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = true;
                            label7.Visible = true;
                            label11.Visible = true;
                            label12.Visible = true;
                            label13.Visible = true;
                            label14.Visible = true;
                            label15.Visible = true;
                            label18.Visible = true;
                            label19.Visible = true;
                            label20.Visible = true;
                            label21.Visible = true;
                            label22.Visible = true;
                            label25.Visible = true;
                            label26.Visible = true;
                            label27.Visible = true;
                            label28.Visible = true;
                            label29.Visible = true;
                            label39.Visible = true;
                            label40.Visible = true;
                            label41.Visible = true;
                            label42.Visible = true;
                            label43.Visible = true;

                            textBox37.Location = textBox5.Location;
                            textBox38.Location = textBox7.Location;
                            textBox39.Location = textBox19.Location;
                            textBox40.Location = textBox13.Location;
                            textBox41.Location = textBox31.Location;
                            label8.Location = label6.Location;
                            label9.Location = label10.Location;
                            label16.Location = label17.Location;
                            label23.Location = label24.Location;
                            label37.Location = label38.Location;

                            textBox37.Visible = true;
                            textBox38.Visible = true;
                            textBox39.Visible = true;
                            textBox40.Visible = true;
                            textBox41.Visible = true;
                            label8.Visible = true;
                            label9.Visible = true;
                            label16.Visible = true;
                            label23.Visible = true;
                            label37.Visible = true;


                            label6.Visible = false;
                            label10.Visible = false;
                            label17.Visible = false;
                            label24.Visible = false;
                            label30.Visible = false;
                            label31.Visible = false;
                            label32.Visible = false;
                            label33.Visible = false;
                            label34.Visible = false;
                            label35.Visible = false;
                            label36.Visible = false;
                            label38.Visible = false;

                            textBox5.Visible = false;
                            textBox7.Visible = false;
                            textBox13.Visible = false;
                            textBox19.Visible = false;
                            textBox25.Visible = false;
                            textBox26.Visible = false;
                            textBox27.Visible = false;
                            textBox28.Visible = false;
                            textBox29.Visible = false;
                            textBox30.Visible = false;
                            textBox31.Visible = false;
                            textBox42.Visible = false;
                        }
                        break;
                    case 6:
                        {
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;
                            textBox4.Visible = true;
                            textBox5.Visible = true;
                            textBox6.Visible = true;
                            textBox7.Visible = true;
                            textBox8.Visible = true;
                            textBox9.Visible = true;
                            textBox10.Visible = true;
                            textBox11.Visible = true;
                            textBox12.Visible = true;
                            textBox13.Visible = true;
                            textBox14.Visible = true;
                            textBox15.Visible = true;
                            textBox16.Visible = true;
                            textBox17.Visible = true;
                            textBox18.Visible = true;
                            textBox19.Visible = true;
                            textBox20.Visible = true;
                            textBox21.Visible = true;
                            textBox22.Visible = true;
                            textBox23.Visible = true;
                            textBox24.Visible = true;
                            textBox25.Visible = true;
                            textBox26.Visible = true;
                            textBox27.Visible = true;
                            textBox28.Visible = true;
                            textBox29.Visible = true;
                            textBox30.Visible = true;
                            textBox31.Visible = true;
                            textBox32.Visible = true;
                            textBox33.Visible = true;
                            textBox34.Visible = true;
                            textBox35.Visible = true;
                            textBox36.Visible = true;
                            textBox37.Visible = true;
                            textBox38.Visible = true;
                            textBox39.Visible = true;
                            textBox40.Visible = true;
                            textBox41.Visible = true;
                            textBox42.Visible = true;

                            label2.Visible = true;
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = true;
                            label6.Visible = true;
                            label7.Visible = true;
                            label8.Visible = true;
                            label9.Visible = true;
                            label10.Visible = true;
                            label11.Visible = true;
                            label12.Visible = true;
                            label13.Visible = true;
                            label14.Visible = true;
                            label15.Visible = true;
                            label16.Visible = true;
                            label17.Visible = true;
                            label18.Visible = true;
                            label19.Visible = true;
                            label20.Visible = true;
                            label21.Visible = true;
                            label22.Visible = true;
                            label23.Visible = true;
                            label24.Visible = true;
                            label25.Visible = true;
                            label26.Visible = true;
                            label27.Visible = true;
                            label28.Visible = true;
                            label29.Visible = true;
                            label30.Visible = true;
                            label31.Visible = true;
                            label32.Visible = true;
                            label33.Visible = true;
                            label34.Visible = true;
                            label35.Visible = true;
                            label36.Visible = true;
                            label37.Visible = true;
                            label38.Visible = true;
                            label39.Visible = true;
                            label40.Visible = true;
                            label41.Visible = true;
                            label42.Visible = true;
                            label43.Visible = true;

                            textBox37.Location = new Point((textBox5.Location.X + 71), textBox5.Location.Y);
                            textBox38.Location = new Point((textBox7.Location.X + 71), textBox7.Location.Y);
                            textBox39.Location = new Point((textBox19.Location.X + 71), textBox19.Location.Y);
                            textBox40.Location = new Point((textBox13.Location.X + 71), textBox13.Location.Y);
                            textBox41.Location = new Point((textBox31.Location.X + 71), textBox31.Location.Y);
                            textBox42.Location = new Point((textBox25.Location.X + 71), textBox25.Location.Y);
                            label8.Location = new Point((label6.Location.X + 71), label6.Location.Y);
                            label9.Location = new Point((label10.Location.X + 71), label10.Location.Y);
                            label23.Location = new Point((label24.Location.X + 71), label24.Location.Y);
                            label16.Location = new Point((label17.Location.X + 71), label17.Location.Y);
                            label37.Location = new Point((label38.Location.X + 71), label38.Location.Y);
                            label30.Location = new Point((label31.Location.X + 71), label31.Location.Y);

                        }
                        break;
                    default: MessageBox.Show("Можливі варіанти :  [ 1 : 6 ]", caption: "Зверніть увагу!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); break;
                }
            }
            //else MessageBox.Show("Поле не може бути пустим!", caption: "Зверніть увагу!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (size_Matrica > 0 && size_Matrica < 7)
            {
                double[][] data_tabel = new double[6][];
                for (int i = 0; i < 6; i++) data_tabel[i] = new double[7];
                data_tabel[0][0] = Convert.ToDouble(textBox1.Text);
                data_tabel[0][1] = Convert.ToDouble(textBox2.Text);
                data_tabel[0][2] = Convert.ToDouble(textBox4.Text);
                data_tabel[0][3] = Convert.ToDouble(textBox3.Text);
                data_tabel[0][4] = Convert.ToDouble(textBox6.Text);
                data_tabel[0][5] = Convert.ToDouble(textBox5.Text);
                data_tabel[0][6] = Convert.ToDouble(textBox37.Text);

                data_tabel[1][0] = Convert.ToDouble(textBox12.Text);
                data_tabel[1][1] = Convert.ToDouble(textBox11.Text);
                data_tabel[1][2] = Convert.ToDouble(textBox10.Text);
                data_tabel[1][3] = Convert.ToDouble(textBox9.Text);
                data_tabel[1][4] = Convert.ToDouble(textBox8.Text);
                data_tabel[1][5] = Convert.ToDouble(textBox7.Text);
                data_tabel[1][6] = Convert.ToDouble(textBox38.Text);

                data_tabel[2][0] = Convert.ToDouble(textBox24.Text);
                data_tabel[2][1] = Convert.ToDouble(textBox23.Text);
                data_tabel[2][2] = Convert.ToDouble(textBox22.Text);
                data_tabel[2][3] = Convert.ToDouble(textBox21.Text);
                data_tabel[2][4] = Convert.ToDouble(textBox20.Text);
                data_tabel[2][5] = Convert.ToDouble(textBox19.Text);
                data_tabel[2][6] = Convert.ToDouble(textBox39.Text);

                data_tabel[3][0] = Convert.ToDouble(textBox18.Text);
                data_tabel[3][1] = Convert.ToDouble(textBox17.Text);
                data_tabel[3][2] = Convert.ToDouble(textBox16.Text);
                data_tabel[3][3] = Convert.ToDouble(textBox15.Text);
                data_tabel[3][4] = Convert.ToDouble(textBox14.Text);
                data_tabel[3][5] = Convert.ToDouble(textBox13.Text);
                data_tabel[3][6] = Convert.ToDouble(textBox40.Text);

                data_tabel[4][0] = Convert.ToDouble(textBox36.Text);
                data_tabel[4][1] = Convert.ToDouble(textBox35.Text);
                data_tabel[4][2] = Convert.ToDouble(textBox34.Text);
                data_tabel[4][3] = Convert.ToDouble(textBox33.Text);
                data_tabel[4][4] = Convert.ToDouble(textBox32.Text);
                data_tabel[4][5] = Convert.ToDouble(textBox31.Text);
                data_tabel[4][6] = Convert.ToDouble(textBox41.Text);

                data_tabel[5][0] = Convert.ToDouble(textBox30.Text);
                data_tabel[5][1] = Convert.ToDouble(textBox29.Text);
                data_tabel[5][2] = Convert.ToDouble(textBox28.Text);
                data_tabel[5][3] = Convert.ToDouble(textBox27.Text);
                data_tabel[5][4] = Convert.ToDouble(textBox26.Text);
                data_tabel[5][5] = Convert.ToDouble(textBox25.Text);
                data_tabel[5][6] = Convert.ToDouble(textBox42.Text);


                int column = size_Matrica + 2;
                int line = size_Matrica + 1;
                for (int i = 0; i <= size_Matrica; i++)
                {
                    line += i;
                }
                double[][] result_tabel = new double[line][];
                for (int i = 0; i < line; i++) result_tabel[i] = new double[column];

                for (int i = 0; i < line; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        result_tabel[i][j] = 0;
                    }
                }


                for (int i = 0; i < size_Matrica; i++)
                {
                    for (int j = 0; j < size_Matrica + 2; j++)
                    {
                        if (j == size_Matrica + 1)
                        {
                            result_tabel[i][j] = 0;
                            for (int z = 0; z < size_Matrica + 1; z++)
                            {
                                result_tabel[i][j] += result_tabel[i][z];
                            }
                        }
                        else if (j == size_Matrica) result_tabel[i][j] = data_tabel[i][6];
                        else result_tabel[i][j] = data_tabel[i][j];
                    }
                }
                int red_line = size_Matrica;
                int white_line = size_Matrica - 1;
                int first_el = 0;
                int index;
                for (index = size_Matrica; index < line - 1;)
                {//червоні рядки 
                    if (index != size_Matrica)
                    {
                        first_el++;
                    }
                    for (int i = first_el; i < size_Matrica + 2; i++)
                    {
                        result_tabel[index][i] = result_tabel[index - red_line][i] / ((-1) * result_tabel[index - red_line][first_el]);
                    }
                    index++;

                    //білі рядки
                    for (int i = 0; i < white_line; i++)
                    {
                        for (int j = first_el; j < size_Matrica + 2; j++)
                        {
                            result_tabel[index][j] = result_tabel[index - red_line][j] + (result_tabel[index - red_line][first_el] * result_tabel[index - 1 - i][j]);
                        }
                        index++;
                    }
                    red_line--;
                    white_line--;
                }
                result_tabel[index][column - 1] = 0;
                result_tabel[index][column - 2] = 1;
                red_line = 0;
                white_line = 1;
                for (int i = size_Matrica - 1; i >= 0; i--)
                {
                    red_line += white_line;
                    result_tabel[index][i] = 0;
                    for (int j = i + 1; j < column - 1; j++)
                    {
                        result_tabel[index][i] += result_tabel[index][j] * result_tabel[index - red_line][j];
                    }
                    white_line++;
                }

                Form2 newForm = new Form2();

                newForm.Vil_Chlen.Height = 40;
                newForm.Vil_Chlen.Width = 100;
                newForm.Vil_Chlen.BackColor = Color.Blue;

                newForm.Summ.Height = 40;
                newForm.Summ.Width = 100;
                newForm.Summ.BackColor = Color.Blue;


                switch (size_Matrica)
                {
                    case 2:
                        {
                            newForm.l_0_0.Text = Convert.ToString(result_tabel[0][0]);
                            newForm.l_0_1.Text = Convert.ToString(result_tabel[0][1]);
                            newForm.l_0_6.Text = Convert.ToString(result_tabel[0][2]);
                            newForm.l_0_7.Text = Convert.ToString(result_tabel[0][3]);

                            newForm.l_1_0.Text = Convert.ToString(result_tabel[1][0]);
                            newForm.l_1_1.Text = Convert.ToString(result_tabel[1][1]);
                            newForm.l_1_6.Text = Convert.ToString(result_tabel[1][2]);
                            newForm.l_1_7.Text = Convert.ToString(result_tabel[1][3]);

                            newForm.l_2_0.Text = Convert.ToString(result_tabel[2][0]);
                            newForm.l_2_1.Text = Convert.ToString(result_tabel[2][1]);
                            newForm.l_2_6.Text = Convert.ToString(result_tabel[2][2]);
                            newForm.l_2_7.Text = Convert.ToString(result_tabel[2][3]);

                            newForm.l_3_0.Text = Convert.ToString(result_tabel[3][0]);
                            newForm.l_3_1.Text = Convert.ToString(result_tabel[3][1]);
                            newForm.l_3_6.Text = Convert.ToString(result_tabel[3][2]);
                            newForm.l_3_7.Text = Convert.ToString(result_tabel[3][3]);

                            newForm.l_4_0.Text = Convert.ToString(result_tabel[4][0]);
                            newForm.l_4_1.Text = Convert.ToString(result_tabel[4][1]);
                            newForm.l_4_6.Text = Convert.ToString(result_tabel[4][2]);
                            newForm.l_4_7.Text = Convert.ToString(result_tabel[4][3]);

                            newForm.l_5_0.Text = Convert.ToString(result_tabel[5][0]);
                            newForm.l_5_1.Text = Convert.ToString(result_tabel[5][1]);
                            newForm.l_5_6.Text = Convert.ToString(result_tabel[5][2]);
                            newForm.l_5_7.Text = Convert.ToString(result_tabel[5][3]);


                            newForm.line2.Height = 40;
                            newForm.line2.Width = 50;
                            newForm.line2.BackColor = Color.Red;

                            newForm.l_2_0.Height = 30;
                            newForm.l_2_0.Width = 100;
                            newForm.l_2_0.BackColor = Color.Red;

                            newForm.l_2_1.Height = 30;
                            newForm.l_2_1.Width = 100;
                            newForm.l_2_1.BackColor = Color.Red;

                            newForm.l_2_2.Height = 30;
                            newForm.l_2_2.Width = 100;
                            newForm.l_2_2.BackColor = Color.Red;

                            newForm.l_2_3.Height = 30;
                            newForm.l_2_3.Width = 100;
                            newForm.l_2_3.BackColor = Color.Red;

                            newForm.l_2_4.Height = 30;
                            newForm.l_2_4.Width = 100;
                            newForm.l_2_4.BackColor = Color.Red;

                            newForm.l_2_5.Height = 30;
                            newForm.l_2_5.Width = 100;
                            newForm.l_2_5.BackColor = Color.Red;

                            newForm.l_2_6.Height = 30;
                            newForm.l_2_6.Width = 100;
                            newForm.l_2_6.BackColor = Color.Red;

                            newForm.l_2_7.Height = 30;
                            newForm.l_2_7.Width = 100;
                            newForm.l_2_7.BackColor = Color.Red;



                            newForm.line4.Height = 40;
                            newForm.line4.Width = 50;
                            newForm.line4.BackColor = Color.Red;

                            newForm.l_4_0.Height = 30;
                            newForm.l_4_0.Width = 100;
                            newForm.l_4_0.BackColor = Color.Red;

                            newForm.l_4_1.Height = 30;
                            newForm.l_4_1.Width = 100;
                            newForm.l_4_1.BackColor = Color.Red;

                            newForm.l_4_2.Height = 30;
                            newForm.l_4_2.Width = 100;
                            newForm.l_4_2.BackColor = Color.Red;

                            newForm.l_4_3.Height = 30;
                            newForm.l_4_3.Width = 100;
                            newForm.l_4_3.BackColor = Color.Red;

                            newForm.l_4_4.Height = 30;
                            newForm.l_4_4.Width = 100;
                            newForm.l_4_4.BackColor = Color.Red;

                            newForm.l_4_5.Height = 30;
                            newForm.l_4_5.Width = 100;
                            newForm.l_4_5.BackColor = Color.Red;

                            newForm.l_4_6.Height = 30;
                            newForm.l_4_6.Width = 100;
                            newForm.l_4_6.BackColor = Color.Red;

                            newForm.l_4_7.Height = 30;
                            newForm.l_4_7.Width = 100;
                            newForm.l_4_7.BackColor = Color.Red;


                        }
                        break;
                    case 3:
                        {
                            newForm.l_0_0.Text = Convert.ToString(result_tabel[0][0]);
                            newForm.l_0_1.Text = Convert.ToString(result_tabel[0][1]);
                            newForm.l_0_2.Text = Convert.ToString(result_tabel[0][2]);
                            newForm.l_0_6.Text = Convert.ToString(result_tabel[0][3]);
                            newForm.l_0_7.Text = Convert.ToString(result_tabel[0][4]);

                            newForm.l_1_0.Text = Convert.ToString(result_tabel[1][0]);
                            newForm.l_1_1.Text = Convert.ToString(result_tabel[1][1]);
                            newForm.l_1_2.Text = Convert.ToString(result_tabel[1][2]);
                            newForm.l_1_6.Text = Convert.ToString(result_tabel[1][3]);
                            newForm.l_1_7.Text = Convert.ToString(result_tabel[1][4]);

                            newForm.l_2_0.Text = Convert.ToString(result_tabel[2][0]);
                            newForm.l_2_1.Text = Convert.ToString(result_tabel[2][1]);
                            newForm.l_2_2.Text = Convert.ToString(result_tabel[2][2]);
                            newForm.l_2_6.Text = Convert.ToString(result_tabel[2][3]);
                            newForm.l_2_7.Text = Convert.ToString(result_tabel[2][4]);

                            newForm.l_3_0.Text = Convert.ToString(result_tabel[3][0]);
                            newForm.l_3_1.Text = Convert.ToString(result_tabel[3][1]);
                            newForm.l_3_2.Text = Convert.ToString(result_tabel[3][2]);
                            newForm.l_3_6.Text = Convert.ToString(result_tabel[3][3]);
                            newForm.l_3_7.Text = Convert.ToString(result_tabel[3][4]);

                            newForm.l_4_0.Text = Convert.ToString(result_tabel[4][0]);
                            newForm.l_4_1.Text = Convert.ToString(result_tabel[4][1]);
                            newForm.l_4_2.Text = Convert.ToString(result_tabel[4][2]);
                            newForm.l_4_6.Text = Convert.ToString(result_tabel[4][3]);
                            newForm.l_4_7.Text = Convert.ToString(result_tabel[4][4]);

                            newForm.l_5_0.Text = Convert.ToString(result_tabel[5][0]);
                            newForm.l_5_1.Text = Convert.ToString(result_tabel[5][1]);
                            newForm.l_5_2.Text = Convert.ToString(result_tabel[5][2]);
                            newForm.l_5_6.Text = Convert.ToString(result_tabel[5][3]);
                            newForm.l_5_7.Text = Convert.ToString(result_tabel[5][4]);

                            newForm.l_6_0.Text = Convert.ToString(result_tabel[6][0]);
                            newForm.l_6_1.Text = Convert.ToString(result_tabel[6][1]);
                            newForm.l_6_2.Text = Convert.ToString(result_tabel[6][2]);
                            newForm.l_6_6.Text = Convert.ToString(result_tabel[6][3]);
                            newForm.l_6_7.Text = Convert.ToString(result_tabel[6][4]);

                            newForm.l_7_0.Text = Convert.ToString(result_tabel[7][0]);
                            newForm.l_7_1.Text = Convert.ToString(result_tabel[7][1]);
                            newForm.l_7_2.Text = Convert.ToString(result_tabel[7][2]);
                            newForm.l_7_6.Text = Convert.ToString(result_tabel[7][3]);
                            newForm.l_7_7.Text = Convert.ToString(result_tabel[7][4]);

                            newForm.l_8_0.Text = Convert.ToString(result_tabel[8][0]);
                            newForm.l_8_1.Text = Convert.ToString(result_tabel[8][1]);
                            newForm.l_8_2.Text = Convert.ToString(result_tabel[8][2]);
                            newForm.l_8_6.Text = Convert.ToString(result_tabel[8][3]);
                            newForm.l_8_7.Text = Convert.ToString(result_tabel[8][4]);

                            newForm.l_9_0.Text = Convert.ToString(result_tabel[9][0]);
                            newForm.l_9_1.Text = Convert.ToString(result_tabel[9][1]);
                            newForm.l_9_2.Text = Convert.ToString(result_tabel[9][2]);
                            newForm.l_9_6.Text = Convert.ToString(result_tabel[9][3]);
                            newForm.l_9_7.Text = Convert.ToString(result_tabel[9][4]);

                            newForm.line3.Height = 40;
                            newForm.line3.Width = 50;
                            newForm.line3.BackColor = Color.Red;

                            newForm.l_3_0.Height = 30;
                            newForm.l_3_0.Width = 100;
                            newForm.l_3_0.BackColor = Color.Red;

                            newForm.l_3_1.Height = 30;
                            newForm.l_3_1.Width = 100;
                            newForm.l_3_1.BackColor = Color.Red;

                            newForm.l_3_2.Height = 30;
                            newForm.l_3_2.Width = 100;
                            newForm.l_3_2.BackColor = Color.Red;

                            newForm.l_3_3.Height = 30;
                            newForm.l_3_3.Width = 100;
                            newForm.l_3_3.BackColor = Color.Red;

                            newForm.l_3_4.Height = 30;
                            newForm.l_3_4.Width = 100;
                            newForm.l_3_4.BackColor = Color.Red;

                            newForm.l_3_5.Height = 30;
                            newForm.l_3_5.Width = 100;
                            newForm.l_3_5.BackColor = Color.Red;

                            newForm.l_3_6.Height = 30;
                            newForm.l_3_6.Width = 100;
                            newForm.l_3_6.BackColor = Color.Red;

                            newForm.l_3_7.Height = 30;
                            newForm.l_3_7.Width = 100;
                            newForm.l_3_7.BackColor = Color.Red;



                            newForm.line6.Height = 40;
                            newForm.line6.Width = 50;
                            newForm.line6.BackColor = Color.Red;

                            newForm.l_6_0.Height = 30;
                            newForm.l_6_0.Width = 100;
                            newForm.l_6_0.BackColor = Color.Red;

                            newForm.l_6_1.Height = 30;
                            newForm.l_6_1.Width = 100;
                            newForm.l_6_1.BackColor = Color.Red;

                            newForm.l_6_2.Height = 30;
                            newForm.l_6_2.Width = 100;
                            newForm.l_6_2.BackColor = Color.Red;

                            newForm.l_6_3.Height = 30;
                            newForm.l_6_3.Width = 100;
                            newForm.l_6_3.BackColor = Color.Red;

                            newForm.l_6_4.Height = 30;
                            newForm.l_6_4.Width = 100;
                            newForm.l_6_4.BackColor = Color.Red;

                            newForm.l_6_5.Height = 30;
                            newForm.l_6_5.Width = 100;
                            newForm.l_6_5.BackColor = Color.Red;

                            newForm.l_6_6.Height = 30;
                            newForm.l_6_6.Width = 100;
                            newForm.l_6_6.BackColor = Color.Red;

                            newForm.l_6_7.Height = 30;
                            newForm.l_6_7.Width = 100;
                            newForm.l_6_7.BackColor = Color.Red;



                            newForm.line8.Height = 40;
                            newForm.line8.Width = 50;
                            newForm.line8.BackColor = Color.Red;

                            newForm.l_8_0.Height = 30;
                            newForm.l_8_0.Width = 100;
                            newForm.l_8_0.BackColor = Color.Red;

                            newForm.l_8_1.Height = 30;
                            newForm.l_8_1.Width = 100;
                            newForm.l_8_1.BackColor = Color.Red;

                            newForm.l_8_2.Height = 30;
                            newForm.l_8_2.Width = 100;
                            newForm.l_8_2.BackColor = Color.Red;

                            newForm.l_8_3.Height = 30;
                            newForm.l_8_3.Width = 100;
                            newForm.l_8_3.BackColor = Color.Red;

                            newForm.l_8_4.Height = 30;
                            newForm.l_8_4.Width = 100;
                            newForm.l_8_4.BackColor = Color.Red;

                            newForm.l_8_5.Height = 30;
                            newForm.l_8_5.Width = 100;
                            newForm.l_8_5.BackColor = Color.Red;

                            newForm.l_8_6.Height = 30;
                            newForm.l_8_6.Width = 100;
                            newForm.l_8_6.BackColor = Color.Red;

                            newForm.l_8_7.Height = 30;
                            newForm.l_8_7.Width = 100;
                            newForm.l_8_7.BackColor = Color.Red;

                        }
                        break;
                    case 4:
                        {
                            newForm.l_0_0.Text = Convert.ToString(result_tabel[0][0]);
                            newForm.l_0_1.Text = Convert.ToString(result_tabel[0][1]);
                            newForm.l_0_2.Text = Convert.ToString(result_tabel[0][2]);
                            newForm.l_0_3.Text = Convert.ToString(result_tabel[0][3]);
                            newForm.l_0_6.Text = Convert.ToString(result_tabel[0][4]);
                            newForm.l_0_7.Text = Convert.ToString(result_tabel[0][5]);

                            newForm.l_1_0.Text = Convert.ToString(result_tabel[1][0]);
                            newForm.l_1_1.Text = Convert.ToString(result_tabel[1][1]);
                            newForm.l_1_2.Text = Convert.ToString(result_tabel[1][2]);
                            newForm.l_1_3.Text = Convert.ToString(result_tabel[1][3]);
                            newForm.l_1_6.Text = Convert.ToString(result_tabel[1][4]);
                            newForm.l_1_7.Text = Convert.ToString(result_tabel[1][5]);

                            newForm.l_2_0.Text = Convert.ToString(result_tabel[2][0]);
                            newForm.l_2_1.Text = Convert.ToString(result_tabel[2][1]);
                            newForm.l_2_2.Text = Convert.ToString(result_tabel[2][2]);
                            newForm.l_2_3.Text = Convert.ToString(result_tabel[2][3]);
                            newForm.l_2_6.Text = Convert.ToString(result_tabel[2][4]);
                            newForm.l_2_7.Text = Convert.ToString(result_tabel[2][5]);

                            newForm.l_3_0.Text = Convert.ToString(result_tabel[3][0]);
                            newForm.l_3_1.Text = Convert.ToString(result_tabel[3][1]);
                            newForm.l_3_2.Text = Convert.ToString(result_tabel[3][2]);
                            newForm.l_3_3.Text = Convert.ToString(result_tabel[3][3]);
                            newForm.l_3_6.Text = Convert.ToString(result_tabel[3][4]);
                            newForm.l_3_7.Text = Convert.ToString(result_tabel[3][5]);

                            newForm.l_4_0.Text = Convert.ToString(result_tabel[4][0]);
                            newForm.l_4_1.Text = Convert.ToString(result_tabel[4][1]);
                            newForm.l_4_2.Text = Convert.ToString(result_tabel[4][2]);
                            newForm.l_4_3.Text = Convert.ToString(result_tabel[4][3]);
                            newForm.l_4_6.Text = Convert.ToString(result_tabel[4][4]);
                            newForm.l_4_7.Text = Convert.ToString(result_tabel[4][5]);

                            newForm.l_5_0.Text = Convert.ToString(result_tabel[5][0]);
                            newForm.l_5_1.Text = Convert.ToString(result_tabel[5][1]);
                            newForm.l_5_2.Text = Convert.ToString(result_tabel[5][2]);
                            newForm.l_5_3.Text = Convert.ToString(result_tabel[5][3]);
                            newForm.l_5_6.Text = Convert.ToString(result_tabel[5][4]);
                            newForm.l_5_7.Text = Convert.ToString(result_tabel[5][5]);

                            newForm.l_6_0.Text = Convert.ToString(result_tabel[6][0]);
                            newForm.l_6_1.Text = Convert.ToString(result_tabel[6][1]);
                            newForm.l_6_2.Text = Convert.ToString(result_tabel[6][2]);
                            newForm.l_6_3.Text = Convert.ToString(result_tabel[6][3]);
                            newForm.l_6_6.Text = Convert.ToString(result_tabel[6][4]);
                            newForm.l_6_7.Text = Convert.ToString(result_tabel[6][5]);

                            newForm.l_7_0.Text = Convert.ToString(result_tabel[7][0]);
                            newForm.l_7_1.Text = Convert.ToString(result_tabel[7][1]);
                            newForm.l_7_2.Text = Convert.ToString(result_tabel[7][2]);
                            newForm.l_7_3.Text = Convert.ToString(result_tabel[7][3]);
                            newForm.l_7_6.Text = Convert.ToString(result_tabel[7][4]);
                            newForm.l_7_7.Text = Convert.ToString(result_tabel[7][5]);

                            newForm.l_8_0.Text = Convert.ToString(result_tabel[8][0]);
                            newForm.l_8_1.Text = Convert.ToString(result_tabel[8][1]);
                            newForm.l_8_2.Text = Convert.ToString(result_tabel[8][2]);
                            newForm.l_8_3.Text = Convert.ToString(result_tabel[8][3]);
                            newForm.l_8_6.Text = Convert.ToString(result_tabel[8][4]);
                            newForm.l_8_7.Text = Convert.ToString(result_tabel[8][5]);

                            newForm.l_9_0.Text = Convert.ToString(result_tabel[9][0]);
                            newForm.l_9_1.Text = Convert.ToString(result_tabel[9][1]);
                            newForm.l_9_2.Text = Convert.ToString(result_tabel[9][2]);
                            newForm.l_9_3.Text = Convert.ToString(result_tabel[9][3]);
                            newForm.l_9_6.Text = Convert.ToString(result_tabel[9][4]);
                            newForm.l_9_7.Text = Convert.ToString(result_tabel[9][5]);

                            newForm.l_10_0.Text = Convert.ToString(result_tabel[10][0]);
                            newForm.l_10_1.Text = Convert.ToString(result_tabel[10][1]);
                            newForm.l_10_2.Text = Convert.ToString(result_tabel[10][2]);
                            newForm.l_10_3.Text = Convert.ToString(result_tabel[10][3]);
                            newForm.l_10_6.Text = Convert.ToString(result_tabel[10][4]);
                            newForm.l_10_7.Text = Convert.ToString(result_tabel[10][5]);

                            newForm.l_11_0.Text = Convert.ToString(result_tabel[11][0]);
                            newForm.l_11_1.Text = Convert.ToString(result_tabel[11][1]);
                            newForm.l_11_2.Text = Convert.ToString(result_tabel[11][2]);
                            newForm.l_11_3.Text = Convert.ToString(result_tabel[11][3]);
                            newForm.l_11_6.Text = Convert.ToString(result_tabel[11][4]);
                            newForm.l_11_7.Text = Convert.ToString(result_tabel[11][5]);

                            newForm.l_12_0.Text = Convert.ToString(result_tabel[12][0]);
                            newForm.l_12_1.Text = Convert.ToString(result_tabel[12][1]);
                            newForm.l_12_2.Text = Convert.ToString(result_tabel[12][2]);
                            newForm.l_12_3.Text = Convert.ToString(result_tabel[12][3]);
                            newForm.l_12_6.Text = Convert.ToString(result_tabel[12][4]);
                            newForm.l_12_7.Text = Convert.ToString(result_tabel[12][5]);

                            newForm.l_13_0.Text = Convert.ToString(result_tabel[13][0]);
                            newForm.l_13_1.Text = Convert.ToString(result_tabel[13][1]);
                            newForm.l_13_2.Text = Convert.ToString(result_tabel[13][2]);
                            newForm.l_13_3.Text = Convert.ToString(result_tabel[13][3]);
                            newForm.l_13_6.Text = Convert.ToString(result_tabel[13][4]);
                            newForm.l_13_7.Text = Convert.ToString(result_tabel[13][5]);

                            newForm.l_14_0.Text = Convert.ToString(result_tabel[14][0]);
                            newForm.l_14_1.Text = Convert.ToString(result_tabel[14][1]);
                            newForm.l_14_2.Text = Convert.ToString(result_tabel[14][2]);
                            newForm.l_14_3.Text = Convert.ToString(result_tabel[14][3]);
                            newForm.l_14_6.Text = Convert.ToString(result_tabel[14][4]);
                            newForm.l_14_7.Text = Convert.ToString(result_tabel[14][5]);


                            newForm.line4.Height = 40;
                            newForm.line4.Width = 50;
                            newForm.line4.BackColor = Color.Red;

                            newForm.l_4_0.Height = 30;
                            newForm.l_4_0.Width = 100;
                            newForm.l_4_0.BackColor = Color.Red;

                            newForm.l_4_1.Height = 30;
                            newForm.l_4_1.Width = 100;
                            newForm.l_4_1.BackColor = Color.Red;

                            newForm.l_4_2.Height = 30;
                            newForm.l_4_2.Width = 100;
                            newForm.l_4_2.BackColor = Color.Red;

                            newForm.l_4_3.Height = 30;
                            newForm.l_4_3.Width = 100;
                            newForm.l_4_3.BackColor = Color.Red;

                            newForm.l_4_4.Height = 30;
                            newForm.l_4_4.Width = 100;
                            newForm.l_4_4.BackColor = Color.Red;

                            newForm.l_4_5.Height = 30;
                            newForm.l_4_5.Width = 100;
                            newForm.l_4_5.BackColor = Color.Red;

                            newForm.l_4_6.Height = 30;
                            newForm.l_4_6.Width = 100;
                            newForm.l_4_6.BackColor = Color.Red;

                            newForm.l_4_7.Height = 30;
                            newForm.l_4_7.Width = 100;
                            newForm.l_4_7.BackColor = Color.Red;



                            newForm.line8.Height = 40;
                            newForm.line8.Width = 50;
                            newForm.line8.BackColor = Color.Red;

                            newForm.l_8_0.Height = 30;
                            newForm.l_8_0.Width = 100;
                            newForm.l_8_0.BackColor = Color.Red;

                            newForm.l_8_1.Height = 30;
                            newForm.l_8_1.Width = 100;
                            newForm.l_8_1.BackColor = Color.Red;

                            newForm.l_8_2.Height = 30;
                            newForm.l_8_2.Width = 100;
                            newForm.l_8_2.BackColor = Color.Red;

                            newForm.l_8_3.Height = 30;
                            newForm.l_8_3.Width = 100;
                            newForm.l_8_3.BackColor = Color.Red;

                            newForm.l_8_4.Height = 30;
                            newForm.l_8_4.Width = 100;
                            newForm.l_8_4.BackColor = Color.Red;

                            newForm.l_8_5.Height = 30;
                            newForm.l_8_5.Width = 100;
                            newForm.l_8_5.BackColor = Color.Red;

                            newForm.l_8_6.Height = 30;
                            newForm.l_8_6.Width = 100;
                            newForm.l_8_6.BackColor = Color.Red;

                            newForm.l_8_7.Height = 30;
                            newForm.l_8_7.Width = 100;
                            newForm.l_8_7.BackColor = Color.Red;



                            newForm.line11.Height = 40;
                            newForm.line11.Width = 50;
                            newForm.line11.BackColor = Color.Red;

                            newForm.l_11_0.Height = 30;
                            newForm.l_11_0.Width = 100;
                            newForm.l_11_0.BackColor = Color.Red;

                            newForm.l_11_1.Height = 30;
                            newForm.l_11_1.Width = 100;
                            newForm.l_11_1.BackColor = Color.Red;

                            newForm.l_11_2.Height = 30;
                            newForm.l_11_2.Width = 100;
                            newForm.l_11_2.BackColor = Color.Red;

                            newForm.l_11_3.Height = 30;
                            newForm.l_11_3.Width = 100;
                            newForm.l_11_3.BackColor = Color.Red;

                            newForm.l_11_4.Height = 30;
                            newForm.l_11_4.Width = 100;
                            newForm.l_11_4.BackColor = Color.Red;

                            newForm.l_11_5.Height = 30;
                            newForm.l_11_5.Width = 100;
                            newForm.l_11_5.BackColor = Color.Red;

                            newForm.l_11_6.Height = 30;
                            newForm.l_11_6.Width = 100;
                            newForm.l_11_6.BackColor = Color.Red;

                            newForm.l_11_7.Height = 30;
                            newForm.l_11_7.Width = 100;
                            newForm.l_11_7.BackColor = Color.Red;



                            newForm.line13.Height = 40;
                            newForm.line13.Width = 50;
                            newForm.line13.BackColor = Color.Red;

                            newForm.l_13_0.Height = 30;
                            newForm.l_13_0.Width = 100;
                            newForm.l_13_0.BackColor = Color.Red;

                            newForm.l_13_1.Height = 30;
                            newForm.l_13_1.Width = 100;
                            newForm.l_13_1.BackColor = Color.Red;

                            newForm.l_13_2.Height = 30;
                            newForm.l_13_2.Width = 100;
                            newForm.l_13_2.BackColor = Color.Red;

                            newForm.l_13_3.Height = 30;
                            newForm.l_13_3.Width = 100;
                            newForm.l_13_3.BackColor = Color.Red;

                            newForm.l_13_4.Height = 30;
                            newForm.l_13_4.Width = 100;
                            newForm.l_13_4.BackColor = Color.Red;

                            newForm.l_13_5.Height = 30;
                            newForm.l_13_5.Width = 100;
                            newForm.l_13_5.BackColor = Color.Red;

                            newForm.l_13_6.Height = 30;
                            newForm.l_13_6.Width = 100;
                            newForm.l_13_6.BackColor = Color.Red;

                            newForm.l_13_7.Height = 30;
                            newForm.l_13_7.Width = 100;
                            newForm.l_13_7.BackColor = Color.Red;

                        }
                        break;
                    case 5:
                        {
                            newForm.l_0_0.Text = Convert.ToString(result_tabel[0][0]);
                            newForm.l_0_1.Text = Convert.ToString(result_tabel[0][1]);
                            newForm.l_0_2.Text = Convert.ToString(result_tabel[0][2]);
                            newForm.l_0_3.Text = Convert.ToString(result_tabel[0][3]);
                            newForm.l_0_4.Text = Convert.ToString(result_tabel[0][4]);
                            newForm.l_0_6.Text = Convert.ToString(result_tabel[0][5]);
                            newForm.l_0_7.Text = Convert.ToString(result_tabel[0][6]);

                            newForm.l_1_0.Text = Convert.ToString(result_tabel[1][0]);
                            newForm.l_1_1.Text = Convert.ToString(result_tabel[1][1]);
                            newForm.l_1_2.Text = Convert.ToString(result_tabel[1][2]);
                            newForm.l_1_3.Text = Convert.ToString(result_tabel[1][3]);
                            newForm.l_1_4.Text = Convert.ToString(result_tabel[1][4]);
                            newForm.l_1_6.Text = Convert.ToString(result_tabel[1][5]);
                            newForm.l_1_7.Text = Convert.ToString(result_tabel[1][6]);

                            newForm.l_2_0.Text = Convert.ToString(result_tabel[2][0]);
                            newForm.l_2_1.Text = Convert.ToString(result_tabel[2][1]);
                            newForm.l_2_2.Text = Convert.ToString(result_tabel[2][2]);
                            newForm.l_2_3.Text = Convert.ToString(result_tabel[2][3]);
                            newForm.l_2_4.Text = Convert.ToString(result_tabel[2][4]);
                            newForm.l_2_6.Text = Convert.ToString(result_tabel[2][5]);
                            newForm.l_2_7.Text = Convert.ToString(result_tabel[2][6]);

                            newForm.l_3_0.Text = Convert.ToString(result_tabel[3][0]);
                            newForm.l_3_1.Text = Convert.ToString(result_tabel[3][1]);
                            newForm.l_3_2.Text = Convert.ToString(result_tabel[3][2]);
                            newForm.l_3_3.Text = Convert.ToString(result_tabel[3][3]);
                            newForm.l_3_4.Text = Convert.ToString(result_tabel[3][4]);
                            newForm.l_3_6.Text = Convert.ToString(result_tabel[3][5]);
                            newForm.l_3_7.Text = Convert.ToString(result_tabel[3][6]);

                            newForm.l_4_0.Text = Convert.ToString(result_tabel[4][0]);
                            newForm.l_4_1.Text = Convert.ToString(result_tabel[4][1]);
                            newForm.l_4_2.Text = Convert.ToString(result_tabel[4][2]);
                            newForm.l_4_3.Text = Convert.ToString(result_tabel[4][3]);
                            newForm.l_4_4.Text = Convert.ToString(result_tabel[4][4]);
                            newForm.l_4_6.Text = Convert.ToString(result_tabel[4][5]);
                            newForm.l_4_7.Text = Convert.ToString(result_tabel[4][6]);

                            newForm.l_5_0.Text = Convert.ToString(result_tabel[5][0]);
                            newForm.l_5_1.Text = Convert.ToString(result_tabel[5][1]);
                            newForm.l_5_2.Text = Convert.ToString(result_tabel[5][2]);
                            newForm.l_5_3.Text = Convert.ToString(result_tabel[5][3]);
                            newForm.l_5_4.Text = Convert.ToString(result_tabel[5][4]);
                            newForm.l_5_6.Text = Convert.ToString(result_tabel[5][5]);
                            newForm.l_5_7.Text = Convert.ToString(result_tabel[5][6]);

                            newForm.l_6_0.Text = Convert.ToString(result_tabel[6][0]);
                            newForm.l_6_1.Text = Convert.ToString(result_tabel[6][1]);
                            newForm.l_6_2.Text = Convert.ToString(result_tabel[6][2]);
                            newForm.l_6_3.Text = Convert.ToString(result_tabel[6][3]);
                            newForm.l_6_4.Text = Convert.ToString(result_tabel[6][4]);
                            newForm.l_6_6.Text = Convert.ToString(result_tabel[6][5]);
                            newForm.l_6_7.Text = Convert.ToString(result_tabel[6][6]);

                            newForm.l_7_0.Text = Convert.ToString(result_tabel[7][0]);
                            newForm.l_7_1.Text = Convert.ToString(result_tabel[7][1]);
                            newForm.l_7_2.Text = Convert.ToString(result_tabel[7][2]);
                            newForm.l_7_3.Text = Convert.ToString(result_tabel[7][3]);
                            newForm.l_7_4.Text = Convert.ToString(result_tabel[7][4]);
                            newForm.l_7_6.Text = Convert.ToString(result_tabel[7][5]);
                            newForm.l_7_7.Text = Convert.ToString(result_tabel[7][6]);

                            newForm.l_8_0.Text = Convert.ToString(result_tabel[8][0]);
                            newForm.l_8_1.Text = Convert.ToString(result_tabel[8][1]);
                            newForm.l_8_2.Text = Convert.ToString(result_tabel[8][2]);
                            newForm.l_8_3.Text = Convert.ToString(result_tabel[8][3]);
                            newForm.l_8_4.Text = Convert.ToString(result_tabel[8][4]);
                            newForm.l_8_6.Text = Convert.ToString(result_tabel[8][5]);
                            newForm.l_8_7.Text = Convert.ToString(result_tabel[8][6]);

                            newForm.l_9_0.Text = Convert.ToString(result_tabel[9][0]);
                            newForm.l_9_1.Text = Convert.ToString(result_tabel[9][1]);
                            newForm.l_9_2.Text = Convert.ToString(result_tabel[9][2]);
                            newForm.l_9_3.Text = Convert.ToString(result_tabel[9][3]);
                            newForm.l_9_4.Text = Convert.ToString(result_tabel[9][4]);
                            newForm.l_9_6.Text = Convert.ToString(result_tabel[9][5]);
                            newForm.l_9_7.Text = Convert.ToString(result_tabel[9][6]);

                            newForm.l_10_0.Text = Convert.ToString(result_tabel[10][0]);
                            newForm.l_10_1.Text = Convert.ToString(result_tabel[10][1]);
                            newForm.l_10_2.Text = Convert.ToString(result_tabel[10][2]);
                            newForm.l_10_3.Text = Convert.ToString(result_tabel[10][3]);
                            newForm.l_10_4.Text = Convert.ToString(result_tabel[10][4]);
                            newForm.l_10_6.Text = Convert.ToString(result_tabel[10][5]);
                            newForm.l_10_7.Text = Convert.ToString(result_tabel[10][6]);

                            newForm.l_11_0.Text = Convert.ToString(result_tabel[11][0]);
                            newForm.l_11_1.Text = Convert.ToString(result_tabel[11][1]);
                            newForm.l_11_2.Text = Convert.ToString(result_tabel[11][2]);
                            newForm.l_11_3.Text = Convert.ToString(result_tabel[11][3]);
                            newForm.l_11_4.Text = Convert.ToString(result_tabel[11][4]);
                            newForm.l_11_6.Text = Convert.ToString(result_tabel[11][5]);
                            newForm.l_11_7.Text = Convert.ToString(result_tabel[11][6]);

                            newForm.l_12_0.Text = Convert.ToString(result_tabel[12][0]);
                            newForm.l_12_1.Text = Convert.ToString(result_tabel[12][1]);
                            newForm.l_12_2.Text = Convert.ToString(result_tabel[12][2]);
                            newForm.l_12_3.Text = Convert.ToString(result_tabel[12][3]);
                            newForm.l_12_4.Text = Convert.ToString(result_tabel[12][4]);
                            newForm.l_12_6.Text = Convert.ToString(result_tabel[12][5]);
                            newForm.l_12_7.Text = Convert.ToString(result_tabel[12][6]);

                            newForm.l_13_0.Text = Convert.ToString(result_tabel[13][0]);
                            newForm.l_13_1.Text = Convert.ToString(result_tabel[13][1]);
                            newForm.l_13_2.Text = Convert.ToString(result_tabel[13][2]);
                            newForm.l_13_3.Text = Convert.ToString(result_tabel[13][3]);
                            newForm.l_13_4.Text = Convert.ToString(result_tabel[13][4]);
                            newForm.l_13_6.Text = Convert.ToString(result_tabel[13][5]);
                            newForm.l_13_7.Text = Convert.ToString(result_tabel[13][6]);

                            newForm.l_14_0.Text = Convert.ToString(result_tabel[14][0]);
                            newForm.l_14_1.Text = Convert.ToString(result_tabel[14][1]);
                            newForm.l_14_2.Text = Convert.ToString(result_tabel[14][2]);
                            newForm.l_14_3.Text = Convert.ToString(result_tabel[14][3]);
                            newForm.l_14_4.Text = Convert.ToString(result_tabel[14][4]);
                            newForm.l_14_6.Text = Convert.ToString(result_tabel[14][5]);
                            newForm.l_14_7.Text = Convert.ToString(result_tabel[14][6]);

                            newForm.l_15_0.Text = Convert.ToString(result_tabel[15][0]);
                            newForm.l_15_1.Text = Convert.ToString(result_tabel[15][1]);
                            newForm.l_15_2.Text = Convert.ToString(result_tabel[15][2]);
                            newForm.l_15_3.Text = Convert.ToString(result_tabel[15][3]);
                            newForm.l_15_4.Text = Convert.ToString(result_tabel[15][4]);
                            newForm.l_15_6.Text = Convert.ToString(result_tabel[15][5]);
                            newForm.l_15_7.Text = Convert.ToString(result_tabel[15][6]);

                            newForm.l_16_0.Text = Convert.ToString(result_tabel[16][0]);
                            newForm.l_16_1.Text = Convert.ToString(result_tabel[16][1]);
                            newForm.l_16_2.Text = Convert.ToString(result_tabel[16][2]);
                            newForm.l_16_3.Text = Convert.ToString(result_tabel[16][3]);
                            newForm.l_16_4.Text = Convert.ToString(result_tabel[16][4]);
                            newForm.l_16_6.Text = Convert.ToString(result_tabel[16][5]);
                            newForm.l_16_7.Text = Convert.ToString(result_tabel[16][6]);

                            newForm.l_17_0.Text = Convert.ToString(result_tabel[17][0]);
                            newForm.l_17_1.Text = Convert.ToString(result_tabel[17][1]);
                            newForm.l_17_2.Text = Convert.ToString(result_tabel[17][2]);
                            newForm.l_17_3.Text = Convert.ToString(result_tabel[17][3]);
                            newForm.l_17_4.Text = Convert.ToString(result_tabel[17][4]);
                            newForm.l_17_6.Text = Convert.ToString(result_tabel[17][5]);
                            newForm.l_17_7.Text = Convert.ToString(result_tabel[17][6]);

                            newForm.l_18_0.Text = Convert.ToString(result_tabel[18][0]);
                            newForm.l_18_1.Text = Convert.ToString(result_tabel[18][1]);
                            newForm.l_18_2.Text = Convert.ToString(result_tabel[18][2]);
                            newForm.l_18_3.Text = Convert.ToString(result_tabel[18][3]);
                            newForm.l_18_4.Text = Convert.ToString(result_tabel[18][4]);
                            newForm.l_18_6.Text = Convert.ToString(result_tabel[18][5]);
                            newForm.l_18_7.Text = Convert.ToString(result_tabel[18][6]);

                            newForm.l_19_0.Text = Convert.ToString(result_tabel[19][0]);
                            newForm.l_19_1.Text = Convert.ToString(result_tabel[19][1]);
                            newForm.l_19_2.Text = Convert.ToString(result_tabel[19][2]);
                            newForm.l_19_3.Text = Convert.ToString(result_tabel[19][3]);
                            newForm.l_19_4.Text = Convert.ToString(result_tabel[19][4]);
                            newForm.l_19_6.Text = Convert.ToString(result_tabel[19][5]);
                            newForm.l_19_7.Text = Convert.ToString(result_tabel[19][6]);

                            newForm.l_20_0.Text = Convert.ToString(result_tabel[20][0]);
                            newForm.l_20_1.Text = Convert.ToString(result_tabel[20][1]);
                            newForm.l_20_2.Text = Convert.ToString(result_tabel[20][2]);
                            newForm.l_20_3.Text = Convert.ToString(result_tabel[20][3]);
                            newForm.l_20_4.Text = Convert.ToString(result_tabel[20][4]);
                            newForm.l_20_6.Text = Convert.ToString(result_tabel[20][5]);
                            newForm.l_20_7.Text = Convert.ToString(result_tabel[20][6]);


                            newForm.line5.Height = 40;
                            newForm.line5.Width = 50;
                            newForm.line5.BackColor = Color.Red;

                            newForm.l_5_0.Height = 30;
                            newForm.l_5_0.Width = 100;
                            newForm.l_5_0.BackColor = Color.Red;

                            newForm.l_5_1.Height = 30;
                            newForm.l_5_1.Width = 100;
                            newForm.l_5_1.BackColor = Color.Red;

                            newForm.l_5_2.Height = 30;
                            newForm.l_5_2.Width = 100;
                            newForm.l_5_2.BackColor = Color.Red;

                            newForm.l_5_3.Height = 30;
                            newForm.l_5_3.Width = 100;
                            newForm.l_5_3.BackColor = Color.Red;

                            newForm.l_5_4.Height = 30;
                            newForm.l_5_4.Width = 100;
                            newForm.l_5_4.BackColor = Color.Red;

                            newForm.l_5_5.Height = 30;
                            newForm.l_5_5.Width = 100;
                            newForm.l_5_5.BackColor = Color.Red;

                            newForm.l_5_6.Height = 30;
                            newForm.l_5_6.Width = 100;
                            newForm.l_5_6.BackColor = Color.Red;

                            newForm.l_5_7.Height = 30;
                            newForm.l_5_7.Width = 100;
                            newForm.l_5_7.BackColor = Color.Red;




                            newForm.line10.Height = 40;
                            newForm.line10.Width = 50;
                            newForm.line10.BackColor = Color.Red;

                            newForm.l_10_0.Height = 30;
                            newForm.l_10_0.Width = 100;
                            newForm.l_10_0.BackColor = Color.Red;

                            newForm.l_10_1.Height = 30;
                            newForm.l_10_1.Width = 100;
                            newForm.l_10_1.BackColor = Color.Red;

                            newForm.l_10_2.Height = 30;
                            newForm.l_10_2.Width = 100;
                            newForm.l_10_2.BackColor = Color.Red;

                            newForm.l_10_3.Height = 30;
                            newForm.l_10_3.Width = 100;
                            newForm.l_10_3.BackColor = Color.Red;

                            newForm.l_10_4.Height = 30;
                            newForm.l_10_4.Width = 100;
                            newForm.l_10_4.BackColor = Color.Red;

                            newForm.l_10_5.Height = 30;
                            newForm.l_10_5.Width = 100;
                            newForm.l_10_5.BackColor = Color.Red;

                            newForm.l_10_6.Height = 30;
                            newForm.l_10_6.Width = 100;
                            newForm.l_10_6.BackColor = Color.Red;

                            newForm.l_10_7.Height = 30;
                            newForm.l_10_7.Width = 100;
                            newForm.l_10_7.BackColor = Color.Red;



                            newForm.line14.Height = 40;
                            newForm.line14.Width = 50;
                            newForm.line14.BackColor = Color.Red;

                            newForm.l_14_0.Height = 30;
                            newForm.l_14_0.Width = 100;
                            newForm.l_14_0.BackColor = Color.Red;

                            newForm.l_14_1.Height = 30;
                            newForm.l_14_1.Width = 100;
                            newForm.l_14_1.BackColor = Color.Red;

                            newForm.l_14_2.Height = 30;
                            newForm.l_14_2.Width = 100;
                            newForm.l_14_2.BackColor = Color.Red;

                            newForm.l_14_3.Height = 30;
                            newForm.l_14_3.Width = 100;
                            newForm.l_14_3.BackColor = Color.Red;

                            newForm.l_14_4.Height = 30;
                            newForm.l_14_4.Width = 100;
                            newForm.l_14_4.BackColor = Color.Red;

                            newForm.l_14_5.Height = 30;
                            newForm.l_14_5.Width = 100;
                            newForm.l_14_5.BackColor = Color.Red;

                            newForm.l_14_6.Height = 30;
                            newForm.l_14_6.Width = 100;
                            newForm.l_14_6.BackColor = Color.Red;

                            newForm.l_14_7.Height = 30;
                            newForm.l_14_7.Width = 100;
                            newForm.l_14_7.BackColor = Color.Red;



                            newForm.line17.Height = 40;
                            newForm.line17.Width = 50;
                            newForm.line17.BackColor = Color.Red;

                            newForm.l_17_0.Height = 30;
                            newForm.l_17_0.Width = 100;
                            newForm.l_17_0.BackColor = Color.Red;

                            newForm.l_17_1.Height = 30;
                            newForm.l_17_1.Width = 100;
                            newForm.l_17_1.BackColor = Color.Red;

                            newForm.l_17_2.Height = 30;
                            newForm.l_17_2.Width = 100;
                            newForm.l_17_2.BackColor = Color.Red;

                            newForm.l_17_3.Height = 30;
                            newForm.l_17_3.Width = 100;
                            newForm.l_17_3.BackColor = Color.Red;

                            newForm.l_17_4.Height = 30;
                            newForm.l_17_4.Width = 100;
                            newForm.l_17_4.BackColor = Color.Red;

                            newForm.l_17_5.Height = 30;
                            newForm.l_17_5.Width = 100;
                            newForm.l_17_5.BackColor = Color.Red;

                            newForm.l_17_6.Height = 30;
                            newForm.l_17_6.Width = 100;
                            newForm.l_17_6.BackColor = Color.Red;

                            newForm.l_17_7.Height = 30;
                            newForm.l_17_7.Width = 100;
                            newForm.l_17_7.BackColor = Color.Red;




                            newForm.line19.Height = 40;
                            newForm.line19.Width = 50;
                            newForm.line19.BackColor = Color.Red;

                            newForm.l_19_0.Height = 30;
                            newForm.l_19_0.Width = 100;
                            newForm.l_19_0.BackColor = Color.Red;

                            newForm.l_19_1.Height = 30;
                            newForm.l_19_1.Width = 100;
                            newForm.l_19_1.BackColor = Color.Red;

                            newForm.l_19_2.Height = 30;
                            newForm.l_19_2.Width = 100;
                            newForm.l_19_2.BackColor = Color.Red;

                            newForm.l_19_3.Height = 30;
                            newForm.l_19_3.Width = 100;
                            newForm.l_19_3.BackColor = Color.Red;

                            newForm.l_19_4.Height = 30;
                            newForm.l_19_4.Width = 100;
                            newForm.l_19_4.BackColor = Color.Red;

                            newForm.l_19_5.Height = 30;
                            newForm.l_19_5.Width = 100;
                            newForm.l_19_5.BackColor = Color.Red;

                            newForm.l_19_6.Height = 30;
                            newForm.l_19_6.Width = 100;
                            newForm.l_19_6.BackColor = Color.Red;

                            newForm.l_19_7.Height = 30;
                            newForm.l_19_7.Width = 100;
                            newForm.l_19_7.BackColor = Color.Red;
                        }
                        break;
                    case 6:
                        {
                            newForm.l_0_0.Text = Convert.ToString(result_tabel[0][0]);
                            newForm.l_0_1.Text = Convert.ToString(result_tabel[0][1]);
                            newForm.l_0_2.Text = Convert.ToString(result_tabel[0][2]);
                            newForm.l_0_3.Text = Convert.ToString(result_tabel[0][3]);
                            newForm.l_0_4.Text = Convert.ToString(result_tabel[0][4]);
                            newForm.l_0_5.Text = Convert.ToString(result_tabel[0][5]);
                            newForm.l_0_6.Text = Convert.ToString(result_tabel[0][6]);
                            newForm.l_0_7.Text = Convert.ToString(result_tabel[0][7]);

                            newForm.l_1_0.Text = Convert.ToString(result_tabel[1][0]);
                            newForm.l_1_1.Text = Convert.ToString(result_tabel[1][1]);
                            newForm.l_1_2.Text = Convert.ToString(result_tabel[1][2]);
                            newForm.l_1_3.Text = Convert.ToString(result_tabel[1][3]);
                            newForm.l_1_4.Text = Convert.ToString(result_tabel[1][4]);
                            newForm.l_1_5.Text = Convert.ToString(result_tabel[1][5]);
                            newForm.l_1_6.Text = Convert.ToString(result_tabel[1][6]);
                            newForm.l_1_7.Text = Convert.ToString(result_tabel[1][7]);

                            newForm.l_2_0.Text = Convert.ToString(result_tabel[2][0]);
                            newForm.l_2_1.Text = Convert.ToString(result_tabel[2][1]);
                            newForm.l_2_2.Text = Convert.ToString(result_tabel[2][2]);
                            newForm.l_2_3.Text = Convert.ToString(result_tabel[2][3]);
                            newForm.l_2_4.Text = Convert.ToString(result_tabel[2][4]);
                            newForm.l_2_5.Text = Convert.ToString(result_tabel[2][5]);
                            newForm.l_2_6.Text = Convert.ToString(result_tabel[2][6]);
                            newForm.l_2_7.Text = Convert.ToString(result_tabel[2][7]);

                            newForm.l_3_0.Text = Convert.ToString(result_tabel[3][0]);
                            newForm.l_3_1.Text = Convert.ToString(result_tabel[3][1]);
                            newForm.l_3_2.Text = Convert.ToString(result_tabel[3][2]);
                            newForm.l_3_3.Text = Convert.ToString(result_tabel[3][3]);
                            newForm.l_3_4.Text = Convert.ToString(result_tabel[3][4]);
                            newForm.l_3_5.Text = Convert.ToString(result_tabel[3][5]);
                            newForm.l_3_6.Text = Convert.ToString(result_tabel[3][6]);
                            newForm.l_3_7.Text = Convert.ToString(result_tabel[3][7]);

                            newForm.l_4_0.Text = Convert.ToString(result_tabel[4][0]);
                            newForm.l_4_1.Text = Convert.ToString(result_tabel[4][1]);
                            newForm.l_4_2.Text = Convert.ToString(result_tabel[4][2]);
                            newForm.l_4_3.Text = Convert.ToString(result_tabel[4][3]);
                            newForm.l_4_4.Text = Convert.ToString(result_tabel[4][4]);
                            newForm.l_4_5.Text = Convert.ToString(result_tabel[4][5]);
                            newForm.l_4_6.Text = Convert.ToString(result_tabel[4][6]);
                            newForm.l_4_7.Text = Convert.ToString(result_tabel[4][7]);

                            newForm.l_5_0.Text = Convert.ToString(result_tabel[5][0]);
                            newForm.l_5_1.Text = Convert.ToString(result_tabel[5][1]);
                            newForm.l_5_2.Text = Convert.ToString(result_tabel[5][2]);
                            newForm.l_5_3.Text = Convert.ToString(result_tabel[5][3]);
                            newForm.l_5_4.Text = Convert.ToString(result_tabel[5][4]);
                            newForm.l_5_5.Text = Convert.ToString(result_tabel[5][5]);
                            newForm.l_5_6.Text = Convert.ToString(result_tabel[5][6]);
                            newForm.l_5_7.Text = Convert.ToString(result_tabel[5][7]);

                            newForm.l_6_0.Text = Convert.ToString(result_tabel[6][0]);
                            newForm.l_6_1.Text = Convert.ToString(result_tabel[6][1]);
                            newForm.l_6_2.Text = Convert.ToString(result_tabel[6][2]);
                            newForm.l_6_3.Text = Convert.ToString(result_tabel[6][3]);
                            newForm.l_6_4.Text = Convert.ToString(result_tabel[6][4]);
                            newForm.l_6_5.Text = Convert.ToString(result_tabel[6][5]);
                            newForm.l_6_6.Text = Convert.ToString(result_tabel[6][6]);
                            newForm.l_6_7.Text = Convert.ToString(result_tabel[6][7]);

                            newForm.l_7_0.Text = Convert.ToString(result_tabel[7][0]);
                            newForm.l_7_1.Text = Convert.ToString(result_tabel[7][1]);
                            newForm.l_7_2.Text = Convert.ToString(result_tabel[7][2]);
                            newForm.l_7_3.Text = Convert.ToString(result_tabel[7][3]);
                            newForm.l_7_4.Text = Convert.ToString(result_tabel[7][4]);
                            newForm.l_7_5.Text = Convert.ToString(result_tabel[7][5]);
                            newForm.l_7_6.Text = Convert.ToString(result_tabel[7][6]);
                            newForm.l_7_7.Text = Convert.ToString(result_tabel[7][7]);

                            newForm.l_8_0.Text = Convert.ToString(result_tabel[8][0]);
                            newForm.l_8_1.Text = Convert.ToString(result_tabel[8][1]);
                            newForm.l_8_2.Text = Convert.ToString(result_tabel[8][2]);
                            newForm.l_8_3.Text = Convert.ToString(result_tabel[8][3]);
                            newForm.l_8_4.Text = Convert.ToString(result_tabel[8][4]);
                            newForm.l_8_5.Text = Convert.ToString(result_tabel[8][5]);
                            newForm.l_8_6.Text = Convert.ToString(result_tabel[8][6]);
                            newForm.l_8_7.Text = Convert.ToString(result_tabel[8][7]);

                            newForm.l_9_0.Text = Convert.ToString(result_tabel[9][0]);
                            newForm.l_9_1.Text = Convert.ToString(result_tabel[9][1]);
                            newForm.l_9_2.Text = Convert.ToString(result_tabel[9][2]);
                            newForm.l_9_3.Text = Convert.ToString(result_tabel[9][3]);
                            newForm.l_9_4.Text = Convert.ToString(result_tabel[9][4]);
                            newForm.l_9_5.Text = Convert.ToString(result_tabel[9][5]);
                            newForm.l_9_6.Text = Convert.ToString(result_tabel[9][6]);
                            newForm.l_9_7.Text = Convert.ToString(result_tabel[9][7]);

                            newForm.l_10_0.Text = Convert.ToString(result_tabel[10][0]);
                            newForm.l_10_1.Text = Convert.ToString(result_tabel[10][1]);
                            newForm.l_10_2.Text = Convert.ToString(result_tabel[10][2]);
                            newForm.l_10_3.Text = Convert.ToString(result_tabel[10][3]);
                            newForm.l_10_4.Text = Convert.ToString(result_tabel[10][4]);
                            newForm.l_10_5.Text = Convert.ToString(result_tabel[10][5]);
                            newForm.l_10_6.Text = Convert.ToString(result_tabel[10][6]);
                            newForm.l_10_7.Text = Convert.ToString(result_tabel[10][7]);

                            newForm.l_11_0.Text = Convert.ToString(result_tabel[11][0]);
                            newForm.l_11_1.Text = Convert.ToString(result_tabel[11][1]);
                            newForm.l_11_2.Text = Convert.ToString(result_tabel[11][2]);
                            newForm.l_11_3.Text = Convert.ToString(result_tabel[11][3]);
                            newForm.l_11_4.Text = Convert.ToString(result_tabel[11][4]);
                            newForm.l_11_5.Text = Convert.ToString(result_tabel[11][5]);
                            newForm.l_11_6.Text = Convert.ToString(result_tabel[11][6]);
                            newForm.l_11_7.Text = Convert.ToString(result_tabel[11][7]);

                            newForm.l_12_0.Text = Convert.ToString(result_tabel[12][0]);
                            newForm.l_12_1.Text = Convert.ToString(result_tabel[12][1]);
                            newForm.l_12_2.Text = Convert.ToString(result_tabel[12][2]);
                            newForm.l_12_3.Text = Convert.ToString(result_tabel[12][3]);
                            newForm.l_12_4.Text = Convert.ToString(result_tabel[12][4]);
                            newForm.l_12_5.Text = Convert.ToString(result_tabel[12][5]);
                            newForm.l_12_6.Text = Convert.ToString(result_tabel[12][6]);
                            newForm.l_12_7.Text = Convert.ToString(result_tabel[12][7]);

                            newForm.l_13_0.Text = Convert.ToString(result_tabel[13][0]);
                            newForm.l_13_1.Text = Convert.ToString(result_tabel[13][1]);
                            newForm.l_13_2.Text = Convert.ToString(result_tabel[13][2]);
                            newForm.l_13_3.Text = Convert.ToString(result_tabel[13][3]);
                            newForm.l_13_4.Text = Convert.ToString(result_tabel[13][4]);
                            newForm.l_13_5.Text = Convert.ToString(result_tabel[13][5]);
                            newForm.l_13_6.Text = Convert.ToString(result_tabel[13][6]);
                            newForm.l_13_7.Text = Convert.ToString(result_tabel[13][7]);

                            newForm.l_14_0.Text = Convert.ToString(result_tabel[14][0]);
                            newForm.l_14_1.Text = Convert.ToString(result_tabel[14][1]);
                            newForm.l_14_2.Text = Convert.ToString(result_tabel[14][2]);
                            newForm.l_14_3.Text = Convert.ToString(result_tabel[14][3]);
                            newForm.l_14_4.Text = Convert.ToString(result_tabel[14][4]);
                            newForm.l_14_5.Text = Convert.ToString(result_tabel[14][5]);
                            newForm.l_14_6.Text = Convert.ToString(result_tabel[14][6]);
                            newForm.l_14_7.Text = Convert.ToString(result_tabel[14][7]);

                            newForm.l_15_0.Text = Convert.ToString(result_tabel[15][0]);
                            newForm.l_15_1.Text = Convert.ToString(result_tabel[15][1]);
                            newForm.l_15_2.Text = Convert.ToString(result_tabel[15][2]);
                            newForm.l_15_3.Text = Convert.ToString(result_tabel[15][3]);
                            newForm.l_15_4.Text = Convert.ToString(result_tabel[15][4]);
                            newForm.l_15_5.Text = Convert.ToString(result_tabel[15][5]);
                            newForm.l_15_6.Text = Convert.ToString(result_tabel[15][6]);
                            newForm.l_15_7.Text = Convert.ToString(result_tabel[15][7]);

                            newForm.l_16_0.Text = Convert.ToString(result_tabel[16][0]);
                            newForm.l_16_1.Text = Convert.ToString(result_tabel[16][1]);
                            newForm.l_16_2.Text = Convert.ToString(result_tabel[16][2]);
                            newForm.l_16_3.Text = Convert.ToString(result_tabel[16][3]);
                            newForm.l_16_4.Text = Convert.ToString(result_tabel[16][4]);
                            newForm.l_16_5.Text = Convert.ToString(result_tabel[16][5]);
                            newForm.l_16_6.Text = Convert.ToString(result_tabel[16][6]);
                            newForm.l_16_7.Text = Convert.ToString(result_tabel[16][7]);

                            newForm.l_17_0.Text = Convert.ToString(result_tabel[17][0]);
                            newForm.l_17_1.Text = Convert.ToString(result_tabel[17][1]);
                            newForm.l_17_2.Text = Convert.ToString(result_tabel[17][2]);
                            newForm.l_17_3.Text = Convert.ToString(result_tabel[17][3]);
                            newForm.l_17_4.Text = Convert.ToString(result_tabel[17][4]);
                            newForm.l_17_5.Text = Convert.ToString(result_tabel[17][5]);
                            newForm.l_17_6.Text = Convert.ToString(result_tabel[17][6]);
                            newForm.l_17_7.Text = Convert.ToString(result_tabel[17][7]);

                            newForm.l_18_0.Text = Convert.ToString(result_tabel[18][0]);
                            newForm.l_18_1.Text = Convert.ToString(result_tabel[18][1]);
                            newForm.l_18_2.Text = Convert.ToString(result_tabel[18][2]);
                            newForm.l_18_3.Text = Convert.ToString(result_tabel[18][3]);
                            newForm.l_18_4.Text = Convert.ToString(result_tabel[18][4]);
                            newForm.l_18_5.Text = Convert.ToString(result_tabel[18][5]);
                            newForm.l_18_6.Text = Convert.ToString(result_tabel[18][6]);
                            newForm.l_18_7.Text = Convert.ToString(result_tabel[18][7]);

                            newForm.l_19_0.Text = Convert.ToString(result_tabel[19][0]);
                            newForm.l_19_1.Text = Convert.ToString(result_tabel[19][1]);
                            newForm.l_19_2.Text = Convert.ToString(result_tabel[19][2]);
                            newForm.l_19_3.Text = Convert.ToString(result_tabel[19][3]);
                            newForm.l_19_4.Text = Convert.ToString(result_tabel[19][4]);
                            newForm.l_19_5.Text = Convert.ToString(result_tabel[19][5]);
                            newForm.l_19_6.Text = Convert.ToString(result_tabel[19][6]);
                            newForm.l_19_7.Text = Convert.ToString(result_tabel[19][7]);

                            newForm.l_20_0.Text = Convert.ToString(result_tabel[20][0]);
                            newForm.l_20_1.Text = Convert.ToString(result_tabel[20][1]);
                            newForm.l_20_2.Text = Convert.ToString(result_tabel[20][2]);
                            newForm.l_20_3.Text = Convert.ToString(result_tabel[20][3]);
                            newForm.l_20_4.Text = Convert.ToString(result_tabel[20][4]);
                            newForm.l_20_5.Text = Convert.ToString(result_tabel[20][5]);
                            newForm.l_20_6.Text = Convert.ToString(result_tabel[20][6]);
                            newForm.l_20_7.Text = Convert.ToString(result_tabel[20][7]);

                            newForm.l_21_0.Text = Convert.ToString(result_tabel[21][0]);
                            newForm.l_21_1.Text = Convert.ToString(result_tabel[21][1]);
                            newForm.l_21_2.Text = Convert.ToString(result_tabel[21][2]);
                            newForm.l_21_3.Text = Convert.ToString(result_tabel[21][3]);
                            newForm.l_21_4.Text = Convert.ToString(result_tabel[21][4]);
                            newForm.l_21_5.Text = Convert.ToString(result_tabel[21][5]);
                            newForm.l_21_6.Text = Convert.ToString(result_tabel[21][6]);
                            newForm.l_21_7.Text = Convert.ToString(result_tabel[21][7]);

                            newForm.l_22_0.Text = Convert.ToString(result_tabel[22][0]);
                            newForm.l_22_1.Text = Convert.ToString(result_tabel[22][1]);
                            newForm.l_22_2.Text = Convert.ToString(result_tabel[22][2]);
                            newForm.l_22_3.Text = Convert.ToString(result_tabel[22][3]);
                            newForm.l_22_4.Text = Convert.ToString(result_tabel[22][4]);
                            newForm.l_22_5.Text = Convert.ToString(result_tabel[22][5]);
                            newForm.l_22_6.Text = Convert.ToString(result_tabel[22][6]);
                            newForm.l_22_7.Text = Convert.ToString(result_tabel[22][7]);

                            newForm.l_23_0.Text = Convert.ToString(result_tabel[23][0]);
                            newForm.l_23_1.Text = Convert.ToString(result_tabel[23][1]);
                            newForm.l_23_2.Text = Convert.ToString(result_tabel[23][2]);
                            newForm.l_23_3.Text = Convert.ToString(result_tabel[23][3]);
                            newForm.l_23_4.Text = Convert.ToString(result_tabel[23][4]);
                            newForm.l_23_5.Text = Convert.ToString(result_tabel[23][5]);
                            newForm.l_23_6.Text = Convert.ToString(result_tabel[23][6]);
                            newForm.l_23_7.Text = Convert.ToString(result_tabel[23][7]);

                            newForm.l_24_0.Text = Convert.ToString(result_tabel[24][0]);
                            newForm.l_24_1.Text = Convert.ToString(result_tabel[24][1]);
                            newForm.l_24_2.Text = Convert.ToString(result_tabel[24][2]);
                            newForm.l_24_3.Text = Convert.ToString(result_tabel[24][3]);
                            newForm.l_24_4.Text = Convert.ToString(result_tabel[24][4]);
                            newForm.l_24_5.Text = Convert.ToString(result_tabel[24][5]);
                            newForm.l_24_6.Text = Convert.ToString(result_tabel[24][6]);
                            newForm.l_24_7.Text = Convert.ToString(result_tabel[24][7]);

                            newForm.l_25_0.Text = Convert.ToString(result_tabel[25][0]);
                            newForm.l_25_1.Text = Convert.ToString(result_tabel[25][1]);
                            newForm.l_25_2.Text = Convert.ToString(result_tabel[25][2]);
                            newForm.l_25_3.Text = Convert.ToString(result_tabel[25][3]);
                            newForm.l_25_4.Text = Convert.ToString(result_tabel[25][4]);
                            newForm.l_25_5.Text = Convert.ToString(result_tabel[25][5]);
                            newForm.l_25_6.Text = Convert.ToString(result_tabel[25][6]);
                            newForm.l_25_7.Text = Convert.ToString(result_tabel[25][7]);

                            newForm.l_26_0.Text = Convert.ToString(result_tabel[26][0]);
                            newForm.l_26_1.Text = Convert.ToString(result_tabel[26][1]);
                            newForm.l_26_2.Text = Convert.ToString(result_tabel[26][2]);
                            newForm.l_26_3.Text = Convert.ToString(result_tabel[26][3]);
                            newForm.l_26_4.Text = Convert.ToString(result_tabel[26][4]);
                            newForm.l_26_5.Text = Convert.ToString(result_tabel[26][5]);
                            newForm.l_26_6.Text = Convert.ToString(result_tabel[26][6]);
                            newForm.l_26_7.Text = Convert.ToString(result_tabel[26][7]);

                            newForm.l_27_0.Text = Convert.ToString(result_tabel[27][0]);
                            newForm.l_27_1.Text = Convert.ToString(result_tabel[27][1]);
                            newForm.l_27_2.Text = Convert.ToString(result_tabel[27][2]);
                            newForm.l_27_3.Text = Convert.ToString(result_tabel[27][3]);
                            newForm.l_27_4.Text = Convert.ToString(result_tabel[27][4]);
                            newForm.l_27_5.Text = Convert.ToString(result_tabel[27][5]);
                            newForm.l_27_6.Text = Convert.ToString(result_tabel[27][6]);
                            newForm.l_27_7.Text = Convert.ToString(result_tabel[27][7]);

                            newForm.line6.Height = 40;
                            newForm.line6.Width = 50;
                            newForm.line6.BackColor = Color.Red;

                            newForm.l_6_0.Height = 30;
                            newForm.l_6_0.Width = 100;
                            newForm.l_6_0.BackColor = Color.Red;

                            newForm.l_6_1.Height = 30;
                            newForm.l_6_1.Width = 100;
                            newForm.l_6_1.BackColor = Color.Red;

                            newForm.l_6_2.Height = 30;
                            newForm.l_6_2.Width = 100;
                            newForm.l_6_2.BackColor = Color.Red;

                            newForm.l_6_3.Height = 30;
                            newForm.l_6_3.Width = 100;
                            newForm.l_6_3.BackColor = Color.Red;

                            newForm.l_6_4.Height = 30;
                            newForm.l_6_4.Width = 100;
                            newForm.l_6_4.BackColor = Color.Red;

                            newForm.l_6_5.Height = 30;
                            newForm.l_6_5.Width = 100;
                            newForm.l_6_5.BackColor = Color.Red;

                            newForm.l_6_6.Height = 30;
                            newForm.l_6_6.Width = 100;
                            newForm.l_6_6.BackColor = Color.Red;

                            newForm.l_6_7.Height = 30;
                            newForm.l_6_7.Width = 100;
                            newForm.l_6_7.BackColor = Color.Red;



                            newForm.line12.Height = 40;
                            newForm.line12.Width = 50;
                            newForm.line12.BackColor = Color.Red;

                            newForm.l_12_0.Height = 30;
                            newForm.l_12_0.Width = 100;
                            newForm.l_12_0.BackColor = Color.Red;

                            newForm.l_12_1.Height = 30;
                            newForm.l_12_1.Width = 100;
                            newForm.l_12_1.BackColor = Color.Red;

                            newForm.l_12_2.Height = 30;
                            newForm.l_12_2.Width = 100;
                            newForm.l_12_2.BackColor = Color.Red;

                            newForm.l_12_3.Height = 30;
                            newForm.l_12_3.Width = 100;
                            newForm.l_12_3.BackColor = Color.Red;

                            newForm.l_12_4.Height = 30;
                            newForm.l_12_4.Width = 100;
                            newForm.l_12_4.BackColor = Color.Red;

                            newForm.l_12_5.Height = 30;
                            newForm.l_12_5.Width = 100;
                            newForm.l_12_5.BackColor = Color.Red;

                            newForm.l_12_6.Height = 30;
                            newForm.l_12_6.Width = 100;
                            newForm.l_12_6.BackColor = Color.Red;

                            newForm.l_12_7.Height = 30;
                            newForm.l_12_7.Width = 100;
                            newForm.l_12_7.BackColor = Color.Red;



                            newForm.line17.Height = 40;
                            newForm.line17.Width = 50;
                            newForm.line17.BackColor = Color.Red;

                            newForm.l_17_0.Height = 30;
                            newForm.l_17_0.Width = 100;
                            newForm.l_17_0.BackColor = Color.Red;

                            newForm.l_17_1.Height = 30;
                            newForm.l_17_1.Width = 100;
                            newForm.l_17_1.BackColor = Color.Red;

                            newForm.l_17_2.Height = 30;
                            newForm.l_17_2.Width = 100;
                            newForm.l_17_2.BackColor = Color.Red;

                            newForm.l_17_3.Height = 30;
                            newForm.l_17_3.Width = 100;
                            newForm.l_17_3.BackColor = Color.Red;

                            newForm.l_17_4.Height = 30;
                            newForm.l_17_4.Width = 100;
                            newForm.l_17_4.BackColor = Color.Red;

                            newForm.l_17_5.Height = 30;
                            newForm.l_17_5.Width = 100;
                            newForm.l_17_5.BackColor = Color.Red;

                            newForm.l_17_6.Height = 30;
                            newForm.l_17_6.Width = 100;
                            newForm.l_17_6.BackColor = Color.Red;

                            newForm.l_17_7.Height = 30;
                            newForm.l_17_7.Width = 100;
                            newForm.l_17_7.BackColor = Color.Red;



                            newForm.line21.Height = 40;
                            newForm.line21.Width = 50;
                            newForm.line21.BackColor = Color.Red;

                            newForm.l_21_0.Height = 30;
                            newForm.l_21_0.Width = 100;
                            newForm.l_21_0.BackColor = Color.Red;

                            newForm.l_21_1.Height = 30;
                            newForm.l_21_1.Width = 100;
                            newForm.l_21_1.BackColor = Color.Red;

                            newForm.l_21_2.Height = 30;
                            newForm.l_21_2.Width = 100;
                            newForm.l_21_2.BackColor = Color.Red;

                            newForm.l_21_3.Height = 30;
                            newForm.l_21_3.Width = 100;
                            newForm.l_21_3.BackColor = Color.Red;

                            newForm.l_21_4.Height = 30;
                            newForm.l_21_4.Width = 100;
                            newForm.l_21_4.BackColor = Color.Red;

                            newForm.l_21_5.Height = 30;
                            newForm.l_21_5.Width = 100;
                            newForm.l_21_5.BackColor = Color.Red;

                            newForm.l_21_6.Height = 30;
                            newForm.l_21_6.Width = 100;
                            newForm.l_21_6.BackColor = Color.Red;

                            newForm.l_21_7.Height = 30;
                            newForm.l_21_7.Width = 100;
                            newForm.l_21_7.BackColor = Color.Red;



                            newForm.line24.Height = 40;
                            newForm.line24.Width = 50;
                            newForm.line24.BackColor = Color.Red;

                            newForm.l_24_0.Height = 30;
                            newForm.l_24_0.Width = 100;
                            newForm.l_24_0.BackColor = Color.Red;

                            newForm.l_24_1.Height = 30;
                            newForm.l_24_1.Width = 100;
                            newForm.l_24_1.BackColor = Color.Red;

                            newForm.l_24_2.Height = 30;
                            newForm.l_24_2.Width = 100;
                            newForm.l_24_2.BackColor = Color.Red;

                            newForm.l_24_3.Height = 30;
                            newForm.l_24_3.Width = 100;
                            newForm.l_24_3.BackColor = Color.Red;

                            newForm.l_24_4.Height = 30;
                            newForm.l_24_4.Width = 100;
                            newForm.l_24_4.BackColor = Color.Red;

                            newForm.l_24_5.Height = 30;
                            newForm.l_24_5.Width = 100;
                            newForm.l_24_5.BackColor = Color.Red;

                            newForm.l_24_6.Height = 30;
                            newForm.l_24_6.Width = 100;
                            newForm.l_24_6.BackColor = Color.Red;

                            newForm.l_24_7.Height = 30;
                            newForm.l_24_7.Width = 100;
                            newForm.l_24_7.BackColor = Color.Red;



                            newForm.line26.Height = 40;
                            newForm.line26.Width = 50;
                            newForm.line26.BackColor = Color.Red;

                            newForm.l_26_0.Height = 30;
                            newForm.l_26_0.Width = 100;
                            newForm.l_26_0.BackColor = Color.Red;

                            newForm.l_26_1.Height = 30;
                            newForm.l_26_1.Width = 100;
                            newForm.l_26_1.BackColor = Color.Red;

                            newForm.l_26_2.Height = 30;
                            newForm.l_26_2.Width = 100;
                            newForm.l_26_2.BackColor = Color.Red;

                            newForm.l_26_3.Height = 30;
                            newForm.l_26_3.Width = 100;
                            newForm.l_26_3.BackColor = Color.Red;

                            newForm.l_26_4.Height = 30;
                            newForm.l_26_4.Width = 100;
                            newForm.l_26_4.BackColor = Color.Red;

                            newForm.l_26_5.Height = 30;
                            newForm.l_26_5.Width = 100;
                            newForm.l_26_5.BackColor = Color.Red;

                            newForm.l_26_6.Height = 30;
                            newForm.l_26_6.Width = 100;
                            newForm.l_26_6.BackColor = Color.Red;

                            newForm.l_26_7.Height = 30;
                            newForm.l_26_7.Width = 100;
                            newForm.l_26_7.BackColor = Color.Red;
                        }
                        break;
                }

                switch (size_Matrica)
                {
                    case 2:
                        {
                            newForm.label1.Text += result_tabel[index][0];
                            newForm.label2.Text += result_tabel[index][1];

                            newForm.X1.Height = 40;
                            newForm.X1.Width = 100;
                            newForm.X1.BackColor = Color.Blue;

                            newForm.X2.Height = 40;
                            newForm.X2.Width = 100;
                            newForm.X2.BackColor = Color.Blue;




                            newForm.line5.Height = 40;
                            newForm.line5.Width = 50;
                            newForm.line5.BackColor = Color.Green;

                            newForm.l_5_0.Height = 30;
                            newForm.l_5_0.Width = 100;
                            newForm.l_5_0.BackColor = Color.Green;

                            newForm.l_5_1.Height = 30;
                            newForm.l_5_1.Width = 100;
                            newForm.l_5_1.BackColor = Color.Green;

                            newForm.l_5_2.Height = 30;
                            newForm.l_5_2.Width = 100;
                            newForm.l_5_2.BackColor = Color.Green;

                            newForm.l_5_3.Height = 30;
                            newForm.l_5_3.Width = 100;
                            newForm.l_5_3.BackColor = Color.Green;

                            newForm.l_5_4.Height = 30;
                            newForm.l_5_4.Width = 100;
                            newForm.l_5_4.BackColor = Color.Green;

                            newForm.l_5_5.Height = 30;
                            newForm.l_5_5.Width = 100;
                            newForm.l_5_5.BackColor = Color.Green;

                            newForm.l_5_6.Height = 30;
                            newForm.l_5_6.Width = 100;
                            newForm.l_5_6.BackColor = Color.Green;

                            newForm.l_5_7.Height = 30;
                            newForm.l_5_7.Width = 100;
                            newForm.l_5_7.BackColor = Color.Green;



                            newForm.line0.Height = 40;
                            newForm.line0.Width = 50;
                            newForm.line0.BackColor = Color.Blue;

                            newForm.line1.Height = 40;
                            newForm.line1.Width = 50;
                            newForm.line1.BackColor = Color.Blue;

                            newForm.line3.Height = 40;
                            newForm.line3.Width = 50;
                            newForm.line3.BackColor = Color.Blue;


                        }
                        break;
                    case 3:
                        {
                            newForm.label1.Text += result_tabel[index][0];
                            newForm.label2.Text += result_tabel[index][1];
                            newForm.label3.Text += result_tabel[index][2];


                            newForm.X1.Height = 40;
                            newForm.X1.Width = 100;
                            newForm.X1.BackColor = Color.Blue;

                            newForm.X2.Height = 40;
                            newForm.X2.Width = 100;
                            newForm.X2.BackColor = Color.Blue;

                            newForm.X3.Height = 40;
                            newForm.X3.Width = 100;
                            newForm.X3.BackColor = Color.Blue;



                            newForm.line9.Height = 40;
                            newForm.line9.Width = 50;
                            newForm.line9.BackColor = Color.Green;

                            newForm.l_9_0.Height = 30;
                            newForm.l_9_0.Width = 100;
                            newForm.l_9_0.BackColor = Color.Green;

                            newForm.l_9_1.Height = 30;
                            newForm.l_9_1.Width = 100;
                            newForm.l_9_1.BackColor = Color.Green;

                            newForm.l_9_2.Height = 30;
                            newForm.l_9_2.Width = 100;
                            newForm.l_9_2.BackColor = Color.Green;

                            newForm.l_9_3.Height = 30;
                            newForm.l_9_3.Width = 100;
                            newForm.l_9_3.BackColor = Color.Green;

                            newForm.l_9_4.Height = 30;
                            newForm.l_9_4.Width = 100;
                            newForm.l_9_4.BackColor = Color.Green;

                            newForm.l_9_5.Height = 30;
                            newForm.l_9_5.Width = 100;
                            newForm.l_9_5.BackColor = Color.Green;

                            newForm.l_9_6.Height = 30;
                            newForm.l_9_6.Width = 100;
                            newForm.l_9_6.BackColor = Color.Green;

                            newForm.l_9_7.Height = 30;
                            newForm.l_9_7.Width = 100;
                            newForm.l_9_7.BackColor = Color.Green;



                            newForm.line0.Height = 40;
                            newForm.line0.Width = 50;
                            newForm.line0.BackColor = Color.Blue;

                            newForm.line1.Height = 40;
                            newForm.line1.Width = 50;
                            newForm.line1.BackColor = Color.Blue;

                            newForm.line2.Height = 40;
                            newForm.line2.Width = 50;
                            newForm.line2.BackColor = Color.Blue;

                            newForm.line4.Height = 40;
                            newForm.line4.Width = 50;
                            newForm.line4.BackColor = Color.Blue;

                            newForm.line5.Height = 40;
                            newForm.line5.Width = 50;
                            newForm.line5.BackColor = Color.Blue;

                            newForm.line7.Height = 40;
                            newForm.line7.Width = 50;
                            newForm.line7.BackColor = Color.Blue;
                        }
                        break;
                    case 4:
                        {
                            newForm.label1.Text += result_tabel[index][0];
                            newForm.label2.Text += result_tabel[index][1];
                            newForm.label3.Text += result_tabel[index][2];
                            newForm.label4.Text += result_tabel[index][3];

                            newForm.X1.Height = 40;
                            newForm.X1.Width = 100;
                            newForm.X1.BackColor = Color.Blue;

                            newForm.X2.Height = 40;
                            newForm.X2.Width = 100;
                            newForm.X2.BackColor = Color.Blue;

                            newForm.X3.Height = 40;
                            newForm.X3.Width = 100;
                            newForm.X3.BackColor = Color.Blue;

                            newForm.X4.Height = 40;
                            newForm.X4.Width = 100;
                            newForm.X4.BackColor = Color.Blue;



                            newForm.line14.Height = 40;
                            newForm.line14.Width = 50;
                            newForm.line14.BackColor = Color.Green;

                            newForm.l_14_0.Height = 30;
                            newForm.l_14_0.Width = 100;
                            newForm.l_14_0.BackColor = Color.Green;

                            newForm.l_14_1.Height = 30;
                            newForm.l_14_1.Width = 100;
                            newForm.l_14_1.BackColor = Color.Green;

                            newForm.l_14_2.Height = 30;
                            newForm.l_14_2.Width = 100;
                            newForm.l_14_2.BackColor = Color.Green;

                            newForm.l_14_3.Height = 30;
                            newForm.l_14_3.Width = 100;
                            newForm.l_14_3.BackColor = Color.Green;

                            newForm.l_14_4.Height = 30;
                            newForm.l_14_4.Width = 100;
                            newForm.l_14_4.BackColor = Color.Green;

                            newForm.l_14_5.Height = 30;
                            newForm.l_14_5.Width = 100;
                            newForm.l_14_5.BackColor = Color.Green;

                            newForm.l_14_6.Height = 30;
                            newForm.l_14_6.Width = 100;
                            newForm.l_14_6.BackColor = Color.Green;

                            newForm.l_14_7.Height = 30;
                            newForm.l_14_7.Width = 100;
                            newForm.l_14_7.BackColor = Color.Green;



                            newForm.line0.Height = 40;
                            newForm.line0.Width = 50;
                            newForm.line0.BackColor = Color.Blue;

                            newForm.line1.Height = 40;
                            newForm.line1.Width = 50;
                            newForm.line1.BackColor = Color.Blue;

                            newForm.line2.Height = 40;
                            newForm.line2.Width = 50;
                            newForm.line2.BackColor = Color.Blue;

                            newForm.line3.Height = 40;
                            newForm.line3.Width = 50;
                            newForm.line3.BackColor = Color.Blue;

                            newForm.line5.Height = 40;
                            newForm.line5.Width = 50;
                            newForm.line5.BackColor = Color.Blue;

                            newForm.line6.Height = 40;
                            newForm.line6.Width = 50;
                            newForm.line6.BackColor = Color.Blue;

                            newForm.line7.Height = 40;
                            newForm.line7.Width = 50;
                            newForm.line7.BackColor = Color.Blue;

                            newForm.line9.Height = 40;
                            newForm.line9.Width = 50;
                            newForm.line9.BackColor = Color.Blue;

                            newForm.line10.Height = 40;
                            newForm.line10.Width = 50;
                            newForm.line10.BackColor = Color.Blue;

                            newForm.line12.Height = 40;
                            newForm.line12.Width = 50;
                            newForm.line12.BackColor = Color.Blue;
                        }
                        break;
                    case 5:
                        {
                            newForm.label1.Text += result_tabel[index][0];
                            newForm.label2.Text += result_tabel[index][1];
                            newForm.label3.Text += result_tabel[index][2];
                            newForm.label4.Text += result_tabel[index][3];
                            newForm.label5.Text += result_tabel[index][4];

                            newForm.X1.Height = 40;
                            newForm.X1.Width = 100;
                            newForm.X1.BackColor = Color.Blue;

                            newForm.X2.Height = 40;
                            newForm.X2.Width = 100;
                            newForm.X2.BackColor = Color.Blue;

                            newForm.X3.Height = 40;
                            newForm.X3.Width = 100;
                            newForm.X3.BackColor = Color.Blue;

                            newForm.X4.Height = 40;
                            newForm.X4.Width = 100;
                            newForm.X4.BackColor = Color.Blue;

                            newForm.X5.Height = 40;
                            newForm.X5.Width = 100;
                            newForm.X5.BackColor = Color.Blue;



                            newForm.line20.Height = 40;
                            newForm.line20.Width = 50;
                            newForm.line20.BackColor = Color.Green;

                            newForm.l_20_0.Height = 30;
                            newForm.l_20_0.Width = 100;
                            newForm.l_20_0.BackColor = Color.Green;

                            newForm.l_20_1.Height = 30;
                            newForm.l_20_1.Width = 100;
                            newForm.l_20_1.BackColor = Color.Green;

                            newForm.l_20_2.Height = 30;
                            newForm.l_20_2.Width = 100;
                            newForm.l_20_2.BackColor = Color.Green;

                            newForm.l_20_3.Height = 30;
                            newForm.l_20_3.Width = 100;
                            newForm.l_20_3.BackColor = Color.Green;

                            newForm.l_20_4.Height = 30;
                            newForm.l_20_4.Width = 100;
                            newForm.l_20_4.BackColor = Color.Green;

                            newForm.l_20_5.Height = 30;
                            newForm.l_20_5.Width = 100;
                            newForm.l_20_5.BackColor = Color.Green;

                            newForm.l_20_6.Height = 30;
                            newForm.l_20_6.Width = 100;
                            newForm.l_20_6.BackColor = Color.Green;

                            newForm.l_20_7.Height = 30;
                            newForm.l_20_7.Width = 100;
                            newForm.l_20_7.BackColor = Color.Green;



                            newForm.line0.Height = 40;
                            newForm.line0.Width = 50;
                            newForm.line0.BackColor = Color.Blue;

                            newForm.line1.Height = 40;
                            newForm.line1.Width = 50;
                            newForm.line1.BackColor = Color.Blue;

                            newForm.line2.Height = 40;
                            newForm.line2.Width = 50;
                            newForm.line2.BackColor = Color.Blue;

                            newForm.line3.Height = 40;
                            newForm.line3.Width = 50;
                            newForm.line3.BackColor = Color.Blue;

                            newForm.line4.Height = 40;
                            newForm.line4.Width = 50;
                            newForm.line4.BackColor = Color.Blue;

                            newForm.line6.Height = 40;
                            newForm.line6.Width = 50;
                            newForm.line6.BackColor = Color.Blue;

                            newForm.line7.Height = 40;
                            newForm.line7.Width = 50;
                            newForm.line7.BackColor = Color.Blue;

                            newForm.line8.Height = 40;
                            newForm.line8.Width = 50;
                            newForm.line8.BackColor = Color.Blue;

                            newForm.line9.Height = 40;
                            newForm.line9.Width = 50;
                            newForm.line9.BackColor = Color.Blue;

                            newForm.line11.Height = 40;
                            newForm.line11.Width = 50;
                            newForm.line11.BackColor = Color.Blue;

                            newForm.line12.Height = 40;
                            newForm.line12.Width = 50;
                            newForm.line12.BackColor = Color.Blue;

                            newForm.line13.Height = 40;
                            newForm.line13.Width = 50;
                            newForm.line13.BackColor = Color.Blue;

                            newForm.line15.Height = 40;
                            newForm.line15.Width = 50;
                            newForm.line15.BackColor = Color.Blue;

                            newForm.line16.Height = 40;
                            newForm.line16.Width = 50;
                            newForm.line16.BackColor = Color.Blue;

                            newForm.line18.Height = 40;
                            newForm.line18.Width = 50;
                            newForm.line18.BackColor = Color.Blue;
                        }
                        break;
                    case 6:
                        {
                            newForm.label1.Text += result_tabel[index][0];
                            newForm.label2.Text += result_tabel[index][1];
                            newForm.label3.Text += result_tabel[index][2];
                            newForm.label4.Text += result_tabel[index][3];
                            newForm.label5.Text += result_tabel[index][4];
                            newForm.label6.Text += result_tabel[index][5];

                            newForm.X1.Height = 40;
                            newForm.X1.Width = 100;
                            newForm.X1.BackColor = Color.Blue;

                            newForm.X2.Height = 40;
                            newForm.X2.Width = 100;
                            newForm.X2.BackColor = Color.Blue;

                            newForm.X3.Height = 40;
                            newForm.X3.Width = 100;
                            newForm.X3.BackColor = Color.Blue;

                            newForm.X4.Height = 40;
                            newForm.X4.Width = 100;
                            newForm.X4.BackColor = Color.Blue;

                            newForm.X5.Height = 40;
                            newForm.X5.Width = 100;
                            newForm.X5.BackColor = Color.Blue;

                            newForm.X6.Height = 40;
                            newForm.X6.Width = 100;
                            newForm.X6.BackColor = Color.Blue;



                            newForm.line27.Height = 40;
                            newForm.line27.Width = 50;
                            newForm.line27.BackColor = Color.Green;

                            newForm.l_27_0.Height = 30;
                            newForm.l_27_0.Width = 100;
                            newForm.l_27_0.BackColor = Color.Green;

                            newForm.l_27_1.Height = 30;
                            newForm.l_27_1.Width = 100;
                            newForm.l_27_1.BackColor = Color.Green;

                            newForm.l_27_2.Height = 30;
                            newForm.l_27_2.Width = 100;
                            newForm.l_27_2.BackColor = Color.Green;

                            newForm.l_27_3.Height = 30;
                            newForm.l_27_3.Width = 100;
                            newForm.l_27_3.BackColor = Color.Green;

                            newForm.l_27_4.Height = 30;
                            newForm.l_27_4.Width = 100;
                            newForm.l_27_4.BackColor = Color.Green;

                            newForm.l_27_5.Height = 30;
                            newForm.l_27_5.Width = 100;
                            newForm.l_27_5.BackColor = Color.Green;

                            newForm.l_27_6.Height = 30;
                            newForm.l_27_6.Width = 100;
                            newForm.l_27_6.BackColor = Color.Green;

                            newForm.l_27_7.Height = 30;
                            newForm.l_27_7.Width = 100;
                            newForm.l_27_7.BackColor = Color.Green;



                            newForm.line0.Height = 40;
                            newForm.line0.Width = 50;
                            newForm.line0.BackColor = Color.Blue;

                            newForm.line1.Height = 40;
                            newForm.line1.Width = 50;
                            newForm.line1.BackColor = Color.Blue;

                            newForm.line2.Height = 40;
                            newForm.line2.Width = 50;
                            newForm.line2.BackColor = Color.Blue;

                            newForm.line3.Height = 40;
                            newForm.line3.Width = 50;
                            newForm.line3.BackColor = Color.Blue;

                            newForm.line4.Height = 40;
                            newForm.line4.Width = 50;
                            newForm.line4.BackColor = Color.Blue;

                            newForm.line5.Height = 40;
                            newForm.line5.Width = 50;
                            newForm.line5.BackColor = Color.Blue;

                            newForm.line7.Height = 40;
                            newForm.line7.Width = 50;
                            newForm.line7.BackColor = Color.Blue;

                            newForm.line8.Height = 40;
                            newForm.line8.Width = 50;
                            newForm.line8.BackColor = Color.Blue;

                            newForm.line9.Height = 40;
                            newForm.line9.Width = 50;
                            newForm.line9.BackColor = Color.Blue;

                            newForm.line10.Height = 40;
                            newForm.line10.Width = 50;
                            newForm.line10.BackColor = Color.Blue;

                            newForm.line11.Height = 40;
                            newForm.line11.Width = 50;
                            newForm.line11.BackColor = Color.Blue;

                            newForm.line13.Height = 40;
                            newForm.line13.Width = 50;
                            newForm.line13.BackColor = Color.Blue;

                            newForm.line14.Height = 40;
                            newForm.line14.Width = 50;
                            newForm.line14.BackColor = Color.Blue;

                            newForm.line15.Height = 40;
                            newForm.line15.Width = 50;
                            newForm.line15.BackColor = Color.Blue;

                            newForm.line16.Height = 40;
                            newForm.line16.Width = 50;
                            newForm.line16.BackColor = Color.Blue;

                            newForm.line18.Height = 40;
                            newForm.line18.Width = 50;
                            newForm.line18.BackColor = Color.Blue;

                            newForm.line19.Height = 40;
                            newForm.line19.Width = 50;
                            newForm.line19.BackColor = Color.Blue;

                            newForm.line20.Height = 40;
                            newForm.line20.Width = 50;
                            newForm.line20.BackColor = Color.Blue;

                            newForm.line22.Height = 40;
                            newForm.line22.Width = 50;
                            newForm.line22.BackColor = Color.Blue;

                            newForm.line23.Height = 40;
                            newForm.line23.Width = 50;
                            newForm.line23.BackColor = Color.Blue;

                            newForm.line25.Height = 40;
                            newForm.line25.Width = 50;
                            newForm.line25.BackColor = Color.Blue;
                        }
                        break;
                }

                newForm.Show();


            }
        }



        //лень исправлять
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        //перевірка ввода коефіцієнтів

        private void Al_mask(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58)&& e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

            private void Atb_mask(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if((e.KeyChar<=47 || e.KeyChar>=58) && e.KeyChar!=45 && e.KeyChar!=44 && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }
    }
}
