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
        string crs = "✕";
        string turn = "○";
        string cir_comp = "○○○";
        string crs_comp = "✕✕✕";
        bool off = false;
        int cir_scr = 0;
        int crs_scr = 0;
        IDictionary<int, string> pos = new Dictionary<int, string>();
        int actv_tp_lft = 1;
        int actv_tp = 1;
        int actv_tp_rt = 1;
        int actv_lft = 1;
        int actv_md = 1;
        int actv_rt = 1;
        int actv_btm_lft = 1;
        int actv_btm = 1;
        int actv_btm_rt = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void tp_lft_Click(object sender, EventArgs e)
        {           
            if (actv_tp_lft == 1)
            {
                if (turn == cir)
                {
                    tp_lft.Text = cir;
                    tp_lft.BackColor = Color.Salmon;
                    turn = crs;
                    actv_tp_lft = 0;
                    pos[1] = cir;
                }
                else
                {
                    tp_lft.Text = crs;
                    tp_lft.BackColor = Color.CornflowerBlue;
                    turn = cir;
                    actv_tp_lft = 0; ;
                    pos[1] = crs;
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
                    tp.BackColor = Color.Salmon;
                    turn = crs;
                    actv_tp = 0;
                    pos[2] = cir;
                }
                else
                {
                    tp.Text = crs;
                    tp.BackColor = Color.CornflowerBlue;
                    turn = cir;
                    actv_tp = 0;
                    pos[2] = crs;
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
                    tp_rt.BackColor = Color.Salmon;
                    turn = crs;
                    actv_tp_rt = 0;
                    pos[3] = cir;
                }
                else
                {
                    tp_rt.Text = crs;
                    tp_rt.BackColor = Color.CornflowerBlue;
                    turn = cir;
                    actv_tp_rt = 0;
                    pos[3] = crs;
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
                    lft.BackColor = Color.Salmon;
                    turn = crs;
                    actv_lft = 0;
                    pos[4] = cir;
                }
                else
                {
                    lft.Text = crs;
                    lft.BackColor = Color.CornflowerBlue;
                    turn = cir;
                    actv_lft = 0;
                    pos[4] = crs;
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
                    mid.BackColor = Color.Salmon;
                    turn = crs;
                    actv_md = 0;
                    pos[5] = cir;
                }
                else
                {
                    mid.Text = crs;
                    mid.BackColor = Color.CornflowerBlue;
                    turn = cir;
                    actv_md = 0;
                    pos[5] = crs;
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
                    rt.BackColor = Color.Salmon;
                    turn = crs;
                    actv_rt = 0;
                    pos[6] = cir;
                }
                else
                {
                    rt.Text = crs;
                    rt.BackColor = Color.CornflowerBlue;
                    turn = cir;
                    actv_rt = 0;
                    pos[6] = crs;
                }
            }           
        }

        private void btm_lft_Click(object sender, EventArgs e)
        {
            if (actv_btm_lft == 1)
            {
                if (turn == cir)
                {
                    btm_lft.Text = cir;
                    btm_lft.BackColor = Color.Salmon;
                    turn = crs;
                    actv_btm_lft = 0;
                    pos[7] = cir;
                }
                else
                {
                    btm_lft.Text = crs;
                    btm_lft.BackColor = Color.CornflowerBlue;
                    turn = cir;
                    actv_btm_lft = 0;
                    pos[7] = crs;
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
                    btm.BackColor = Color.Salmon;
                    turn = crs;
                    actv_btm = 0;
                    pos[8] = cir;
                }
                else
                {
                    btm.Text = crs;
                    btm.BackColor = Color.CornflowerBlue;
                    turn = cir;
                    actv_btm = 0;
                    pos[8] = crs;
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
                    btm_rt.BackColor = Color.Salmon;
                    turn = crs;
                    actv_btm_rt = 0;
                    pos[9] = cir;
                }
                else
                {
                    btm_rt.Text = crs;
                    btm_rt.BackColor = Color.CornflowerBlue;
                    turn = cir;
                    actv_btm_rt = 0;
                    pos[9] = crs;
                }
            }           
        }

        private void game_envi_Paint(object sender, PaintEventArgs e)
        {
            string pos_123 = "";
            string pos_456 = "";
            string pos_789 = "";
            string pos_147 = "";
            string pos_258 = "";
            string pos_369 = "";
            string pos_753 = "";
            string pos_159 = "";
            if (off == false)
            {               
                if (actv_tp_lft == 0 && actv_tp == 0 && actv_tp_rt == 0)
                {
                    pos_123 = pos[1] + pos[2] + pos[3];
                }
                if (actv_lft == 0 && actv_md == 0 && actv_rt == 0)
                {
                    pos_456 = pos[4] + pos[5] + pos[6];
                }
                if (actv_btm_lft == 0 && actv_btm == 0 && actv_btm_rt == 0)
                {
                    pos_789 = pos[7] + pos[8] + pos[9];
                }
                if (actv_tp_lft == 0 && actv_lft == 0 && actv_btm_lft == 0)
                {
                    pos_147 = pos[1] + pos[4] + pos[7];
                }
                if (actv_tp == 0 && actv_md == 0 && actv_btm == 0)
                {
                    pos_258 = pos[2] + pos[5] + pos[8];
                }
                if (actv_tp_rt == 0 && actv_rt == 0 && actv_btm_rt == 0)
                {
                    pos_369 = pos[3] + pos[6] + pos[9];
                }
                if (actv_btm_lft == 0 && actv_md == 0 && actv_tp_rt == 0)
                {
                    pos_753 = pos[7] + pos[5] + pos[3];
                }
                if (actv_tp_lft == 0 && actv_md == 0 && actv_btm_rt == 0)
                {
                    pos_159 = pos[1] + pos[5] + pos[9];
                }
            }            
             
            if (pos_123 == cir_comp || pos_123 == crs_comp)
            {
                if (pos_123 == cir_comp)
                {
                    MessageBox.Show("Circle Wins");
                    pos_123 = "";
                    off = true;
                    cir_scr = cir_scr + 1;
                    cir_score.Text = "○\n" + cir_scr;
                }
                else
                {
                    MessageBox.Show("Cross Wins");
                    pos_123 = "";
                    off = true;
                    crs_scr = crs_scr + 1;
                    crs_score.Text = "✕\n" + crs_scr;
                }
            }
            else if (pos_456 == cir_comp || pos_456 == crs_comp)
            {
                if (pos_456 == cir_comp)
                {
                    MessageBox.Show("Circle Wins");
                    off = true;
                    cir_scr = cir_scr + 1;
                    cir_score.Text = "○\n" + cir_scr;
                }
                else
                {
                    MessageBox.Show("Cross Wins");
                    off = true;
                    crs_scr = crs_scr + 1;
                    crs_score.Text = "✕\n" + crs_scr;
                }
            }
            else if (pos_789 == cir_comp || pos_789 == crs_comp)
            {
                if (pos_789 == cir_comp)
                {
                    MessageBox.Show("Circle Wins");
                    off = true;
                    cir_scr = cir_scr + 1;
                    cir_score.Text = "○\n" + cir_scr;
                }
                else
                {
                    MessageBox.Show("Cross Wins");
                    off = true;
                    crs_scr = crs_scr + 1;
                    crs_score.Text = "✕\n" + crs_scr;
                }
            }
            else if (pos_147 == cir_comp || pos_147 == crs_comp)
            {
                if (pos_147 == cir_comp)
                {
                    MessageBox.Show("Circle Wins");
                    off = true;
                    cir_scr = cir_scr + 1;
                    cir_score.Text = "○\n" + cir_scr;
                }
                else
                {
                    MessageBox.Show("Cross Wins");
                    off = true;
                    crs_scr = crs_scr + 1;
                    crs_score.Text = "✕\n" + crs_scr;
                }
            }
            else if (pos_258 == cir_comp || pos_258 == crs_comp)
            {
                if (pos_258 == cir_comp)
                {
                    MessageBox.Show("Circle Wins");
                    off = true;
                    cir_scr = cir_scr + 1;
                    cir_score.Text = "○\n" + cir_scr;
                }
                else
                {
                    MessageBox.Show("Cross Wins");
                    off = true;
                    crs_scr = crs_scr + 1;
                    crs_score.Text = "✕\n" + crs_scr;
                }
            }
            else if (pos_369 == cir_comp || pos_369 == crs_comp)
            {
                if (pos_369 == cir_comp)
                {
                    MessageBox.Show("Circle Wins");
                    off = true;
                    cir_scr = cir_scr + 1;
                    cir_score.Text = "○\n" + cir_scr;
                }
                else
                {
                    MessageBox.Show("Cross Wins");
                    off = true;
                    crs_scr = crs_scr + 1;
                    crs_score.Text = "✕\n" + crs_scr;
                }
            }
            else if (pos_753 == cir_comp || pos_753 == crs_comp)
            {
                if (pos_753 == cir_comp)
                {
                    MessageBox.Show("Circle Wins");
                    off = true;
                    cir_scr = cir_scr + 1;
                    cir_score.Text = "○\n" + cir_scr;
                }
                else
                {
                    MessageBox.Show("Cross Wins");
                    off = true;
                    crs_scr = crs_scr + 1;
                    crs_score.Text = "✕\n" + crs_scr;
                }
            }
            else if (pos_159 == cir_comp || pos_159 == crs_comp)
            {
                if (pos_159 == cir_comp)
                {
                    MessageBox.Show("Circle Wins");
                    off = true;
                    cir_scr = cir_scr + 1;
                    cir_score.Text = "○\n" + cir_scr;
                }
                else
                {
                    MessageBox.Show("Cross Wins");
                    off = true;
                    crs_scr = crs_scr + 1;
                    crs_score.Text = "✕\n" + crs_scr;
                }
            }
            else if (actv_tp_lft == 0 && actv_tp == 0 && actv_tp_rt == 0 && actv_lft == 0 && actv_md == 0 && actv_rt == 0 && actv_btm_lft == 0 && actv_btm == 0 && actv_btm_rt == 0 && off == false)
            {
                MessageBox.Show("Draw");
                off = true;
            }
            if (off == true)
            {
                game_envi.Enabled = false;
                pos[1] = "";
                pos[2] = "";
                pos[3] = "";
                pos[4] = "";
                pos[5] = "";
                pos[6] = "";
                pos[7] = "";
                pos[8] = "";
                pos[9] = "";
                tp_lft.Text = "";
                tp.Text = "";
                tp_rt.Text = "";
                lft.Text = "";
                mid.Text = "";
                rt.Text = "";
                btm_lft.Text = "";
                btm.Text = "";
                btm_rt.Text = "";
                actv_tp_lft = 1;
                actv_tp = 1;
                actv_tp_rt = 1;
                actv_lft = 1;
                actv_md = 1;
                actv_rt = 1;
                actv_btm_lft = 1;
                actv_btm = 1;
                actv_btm_rt = 1;
                tp_lft.BackColor = Color.FromArgb(255,255,192);
                tp.BackColor = Color.FromArgb(255, 255, 192);
                tp_rt.BackColor = Color.FromArgb(255, 255, 192);
                lft.BackColor = Color.FromArgb(255, 255, 192);
                mid.BackColor = Color.FromArgb(255, 255, 192);
                rt.BackColor = Color.FromArgb(255, 255, 192);
                btm_lft.BackColor = Color.FromArgb(255, 255, 192);
                btm.BackColor = Color.FromArgb(255, 255, 192);
                btm_rt.BackColor = Color.FromArgb(255, 255, 192);
                game_envi.Enabled = true;
                off = false;

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            pos.Add(1, "");
            pos.Add(2, "");
            pos.Add(3, "");
            pos.Add(4, "");
            pos.Add(5, "");
            pos.Add(6, "");
            pos.Add(7, "");
            pos.Add(8, "");
            pos.Add(9, "");
        }

        private void crs_score_Click(object sender, EventArgs e)
        {

        }

        private void cir_score_Click(object sender, EventArgs e)
        {

        }
    }
}
