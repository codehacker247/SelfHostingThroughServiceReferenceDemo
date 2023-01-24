﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsClient1.MathServiceReference;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace WindowsClient1
{
    public partial class Form1 : Form
    {
        private MathServiceClient proxy = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
           proxy = new MathServiceClient("MathService_netTcp");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyNumbers obj = new MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);    
            textBox3.Text= proxy.Add(obj).ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyNumbers obj = new MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = proxy.Subtract(obj).ToString();
        }
    }
}
