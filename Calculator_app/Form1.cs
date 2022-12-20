using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count;
        float ans, num;



        private void btn_zero_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + 0;
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + 1;
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + 2;

        }
        private void btn_three_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + 3;
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + 4;
        }

       

        private void btn_five_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + 5;
        }

       
        private void btn_six_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + 6;
        }
        private void btn_seven_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + 7;
        }
//testing

        private void btn_eight_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + 8;
        }

       
        private void btn_nine_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + 9;
        }

       

        private void btn_plus_Click(object sender, EventArgs e)
        {
                num=float.Parse(txt_box.Text);
                txt_box.Clear();
                txt_box.Focus();
                count = 1;
        }

    private void btn_minus_Click(object sender, EventArgs e)
        { 
                num = float.Parse(txt_box.Text);
                txt_box.Clear();
                txt_box.Focus();
                count = 2; 
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
                num = float.Parse(txt_box.Text);
                txt_box.Clear();
                txt_box.Focus();
                count = 3;

        }
        private void btn_divide_Click(object sender, EventArgs e)
        {
            num = float.Parse(txt_box.Text);
            txt_box.Clear();
            txt_box.Focus();
            count = 4;
        }


        private void btn_percent_Click(object sender, EventArgs e)
        {
            num = float.Parse(txt_box.Text);
            txt_box.Clear();
            txt_box.Focus();
            count = 5;  
        }

        private void btn_point_Click(object sender, EventArgs e)
        {

            int d= txt_box.TextLength;
            int point = 0;
            string text = txt_box.Text;
            for (int i = 0; i < d; i++)
            {
                if (text[i].ToString() == ".")
                {
                    point = 1; 
                    break;
                }
                else
                {
                    point = 0;
                }
            }
            if (point == 0)
            {
                txt_box.Text = txt_box.Text + ".";
            }

        }


        public void compute(int count)
        {

            switch(count)
            {
                case 1:
                    ans = num + float.Parse(txt_box.Text);
                    txt_box.Text = num + "+" + float.Parse(txt_box.Text) + "=" + ans.ToString();
                    break;

                case 2:
                    ans=num - float.Parse(txt_box.Text);
                    txt_box.Text=num +"-" + float.Parse(txt_box.Text)+ "="+ans.ToString();
                    break;
                case 3:
                    ans=num * float.Parse(txt_box.Text);
                    txt_box.Text = num + "x" + float.Parse(txt_box.Text) + "=" + ans.ToString();
                    break;
                case 4:
                    ans=num / float.Parse(txt_box.Text);
                    txt_box.Text = num + "÷" + float.Parse(txt_box.Text) + "=" + ans.ToString();
                    break;
                    case 5:
                    ans = num / 100;
                    txt_box.Text= num + "%" +"="+ans.ToString();
                    break;
                default:
                    break;
            }

        }

       
        private void btn_equal_Click(object sender, EventArgs e)
        {
            compute(count);
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            // ??
            string delete = "0";
            if (txt_box.Text.Length > 1)
            {
                 delete = txt_box.Text;
                delete = delete.Substring(0, delete.Length - 1);
            }
            txt_box.Text = delete;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_box.Clear();
            count = 0;
        }

    }

}
