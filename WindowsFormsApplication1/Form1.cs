﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    private void Form1_Load_1(object sender, EventArgs e)
    {
      textBox1.Text = "OPSKDJKS";
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      textBox1.ForeColor = Color.Black;
    }
  }
}
