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
        int actv_tp_lft = 1;
        int actv_tp = 1;
        int actv_tp_rt = 1;
        int actv_lft = 1;
        int actv_md = 1;
        int actv_rt = 1;
        int actv_btm_lgt = 1;
        int actv_btm = 1;
        int actv_btm_rt = 1;

        public Form1()
        {
            InitializeComponent();
            if (actv_tp_lft == 0)
            {
                tp_lft.BackColor = Color.Salmon;
            }
        }

        private void tp_lft_Click(object sender, EventArgs e)
        {           
            if (actv_tp_lft == 1)
            {
                if (turn == cir)
                {
                    tp_lft.Text = cir;
                    turn = crs;
                    actv_tp_lft = 0;
                }
                else
                {
                    tp_lft.Text = crs;
                    turn = cir;
                    actv_tp_lft = 0; ;
                }
            }
            
        }

        private void tp_Click(object sender, EventArgs e)
        {
            if (actv_tp == 1)
            {
                if (turn == cir)
                {
                    tp.Text = cir;
                    turn = crs;
                    actv_tp = 0;
                }
                else
                {
                    tp.Text = crs;
                    turn = cir;
                    actv_tp = 0;
                }
            }
            
        }

        private void tp_rt_Click(object sender, EventArgs e)
        {
            if (actv_tp_rt == 1)
            {
                if (turn == cir)
                {
                    tp_rt.Text = cir;
                    turn = crs;
                    actv_tp_rt = 0;
                }
                else
                {
                    tp_rt.Text = crs;
                    turn = cir;
                    actv_tp_rt = 0;
                }
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void lft_Click(object sender, EventArgs e)
        {
            if (actv_lft == 1)
            {
                if (turn == cir)
                {
                    lft.Text = cir;
                    turn = crs;
                    actv_lft = 0;
                }
                else
                {
                    lft.Text = crs;
                    turn = cir;
                    actv_lft = 0;
                }
            }
            
        }

        private void mid_Click(object sender, EventArgs e)
        {
            if (actv_md == 1)
            {
                if (turn == cir)
                {
                    mid.Text = cir;
                    turn = crs;
                    actv_md = 0;
                }
                else
                {
                    mid.Text = crs;
                    turn = cir;
                    actv_md = 0;
                }
            }
        }

        private void rt_Click(object sender, EventArgs e)
        {
            if (actv_rt == 1)
            {
                if (turn == cir)
                {
                    rt.Text = cir;
                    turn = crs;
                    actv_rt = 0;
                }
                else
                {
                    rt.Text = crs;
                    turn = cir;
                    actv_rt = 0;
                }
            }           
        }

        private void btm_lft_Click(object sender, EventArgs e)
        {
            if (actv_btm_lgt == 1)
            {
                if (turn == cir)
                {
                    btm_lft.Text = cir;
                    turn = crs;
                    actv_btm_lgt = 0;
                }
                else
                {
                    btm_lft.Text = crs;
                    turn = cir;
                    actv_btm_lgt = 0;
                }
            }           
        }

        private void btm_Click(object sender, EventArgs e)
        {
            if (actv_btm == 1)
            {
                if (turn == cir)
                {
                    btm.Text = cir;
                    turn = crs;
                    actv_btm = 0;
                }
                else
                {
                    btm.Text = crs;
                    turn = cir;
                    actv_btm = 0;
                }
            }           
        }

        private void btm_rt_Click(object sender, EventArgs e)
        {
            if (actv_btm_rt == 1)
            {
                if (turn == cir)
                {
                    btm_rt.Text = cir;
                    turn = crs;
                    actv_btm_rt = 0;
                }
                else
                {
                    btm_rt.Text = crs;
                    turn = cir;
                    actv_btm_rt = 0;
                }
            }           
        }

        private void game_envi_Paint(object sender, PaintEventArgs e)
        {
            if (actv_tp_lft == 0)
            {
                tp_lft.BackColor = Color.Salmon;
            }
        }
    }
}
