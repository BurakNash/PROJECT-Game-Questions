using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void questionBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
        int questionNo = 0, correct = 0, wrong = 0;



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //changing the text from Start to Answer
            linkLabel1.Text = "Next";
            //Adds to Question number 0 each time clicked
            questionNo++;
            this.Text = questionNo.ToString();

            //When question is one, richtext will write the question and backcolor changes

            if (questionNo == 1)
            {
                richTextBox1.Text = "What is the most northern State in the USA";
                button0.BackColor = Color.Yellow;
            }
            if (questionNo == 2)
            {
                richTextBox1.Text = "What is the largest country in South America";
                button1.BackColor = Color.Yellow;
            }
            if (questionNo == 3)
            {
                richTextBox1.Text = "What is the capital city of Denmark?";
                button2.BackColor = Color.Yellow;
            }
            if (questionNo == 4)
            {
                richTextBox1.Text = "What is the capital city of Denmark?";
                button3.BackColor = Color.Yellow;
            }
            if (questionNo == 5)
            {
                richTextBox1.Text = "What is the Baltic country next to Latvia?";
                button4.BackColor = Color.Yellow;
            }
            if (questionNo == 6)
            {
                richTextBox1.Text = "Where is the Eiffel Tower is located?";
                button5.BackColor = Color.Yellow;
            }
            if (questionNo == 7)
            {
                richTextBox1.Text = "What is the country in Central America starting with G?";
                button6.BackColor = Color.Yellow;
            }
            if (questionNo == 8)
            {
                richTextBox1.Text = "Which country is always hungry?";
                button10.BackColor = Color.Yellow;
            }
        }
        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (questionNo)
                {
                    case 1:
                        if (richTextBox2.Text == "alaska")
                        {
                            button0.BackColor = Color.Green;
                        }
                        else
                        {
                            button0.BackColor = Color.Red;
                        }
                        break;
                }
            }
        }
    }
}

