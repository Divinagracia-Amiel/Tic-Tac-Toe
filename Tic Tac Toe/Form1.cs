using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        string cir = "○";
        string crs = "x";
        string turn = "○";

        public Form1()
        {
            InitializeComponent();
        }

        private void tp_lft_Click(object sender, EventArgs e)
        {
            if (turn == cir)
            {
                tp_lft.Text = cir;
                turn = crs;
            }
            else
            {
                tp_lft.Text = crs;
                turn = cir;
            }
        }

        private void tp_Click(object sender, EventArgs e)
        {
            if (turn == cir)
            {
                tp.Text = cir;
                turn = crs;
            }
            else
            {
                tp.Text = crs;
                turn = cir;
            }
        }

        private void tp_rt_Click(object sender, EventArgs e)
        {
            if (turn == cir)
            {
                tp_rt.Text = cir;
                turn = crs;
            }
            else
            {
                tp_rt.Text = crs;
                turn = cir;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void lft_Click(object sender, EventArgs e)
        {
            if (turn == cir)
            {
                lft.Text = cir;
                turn = crs;
            }
            else
            {
                lft.Text = crs;
                turn = cir;
            }
        }

        private void mid_Click(object sender, EventArgs e)
        {
            if (turn == cir)
            {
                mid.Text = cir;
                turn = crs;
            }
            else
            {
                mid.Text = crs;
                turn = cir;
            }
        }

        private void rt_Click(object sender, EventArgs e)
        {
            if (turn == cir)
            {
                rt.Text = cir;
                turn = crs;
            }
            else
            {
                rt.Text = crs;
                turn = cir;
            }
        }

        private void btm_lft_Click(object sender, EventArgs e)
        {
            if (turn == cir)
            {
                btm_lft.Text = cir;
                turn = crs;
            }
            else
            {
                btm_lft.Text = crs;
                turn = cir;
            }
        }

        private void btm_Click(object sender, EventArgs e)
        {
            if (turn == cir)
            {
                btm.Text = cir;
                turn = crs;
            }
            else
            {
                btm.Text = crs;
                turn = cir;
            }
        }

        private void btm_rt_Click(object sender, EventArgs e)
        {
            if (turn == cir)
            {
                btm_rt.Text = cir;
                turn = crs;
            }
            else
            {
                btm_rt.Text = crs;
                turn = cir;
            }
        }
    }
}
