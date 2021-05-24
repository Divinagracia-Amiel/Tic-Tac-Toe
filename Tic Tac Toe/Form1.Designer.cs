
namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tp_lft = new System.Windows.Forms.Button();
            this.tp = new System.Windows.Forms.Button();
            this.tp_rt = new System.Windows.Forms.Button();
            this.lft = new System.Windows.Forms.Button();
            this.mid = new System.Windows.Forms.Button();
            this.rt = new System.Windows.Forms.Button();
            this.btm_lft = new System.Windows.Forms.Button();
            this.btm = new System.Windows.Forms.Button();
            this.btm_rt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tp_lft
            // 
            this.tp_lft.Location = new System.Drawing.Point(12, 12);
            this.tp_lft.Margin = new System.Windows.Forms.Padding(0);
            this.tp_lft.Name = "tp_lft";
            this.tp_lft.Size = new System.Drawing.Size(125, 125);
            this.tp_lft.TabIndex = 0;
            this.tp_lft.UseVisualStyleBackColor = true;
            this.tp_lft.Click += new System.EventHandler(this.tp_lft_Click);
            // 
            // tp
            // 
            this.tp.Location = new System.Drawing.Point(137, 12);
            this.tp.Margin = new System.Windows.Forms.Padding(0);
            this.tp.Name = "tp";
            this.tp.Size = new System.Drawing.Size(125, 125);
            this.tp.TabIndex = 1;
            this.tp.UseVisualStyleBackColor = true;
            this.tp.Click += new System.EventHandler(this.tp_Click);
            // 
            // tp_rt
            // 
            this.tp_rt.Location = new System.Drawing.Point(262, 12);
            this.tp_rt.Margin = new System.Windows.Forms.Padding(0);
            this.tp_rt.Name = "tp_rt";
            this.tp_rt.Size = new System.Drawing.Size(125, 125);
            this.tp_rt.TabIndex = 2;
            this.tp_rt.UseVisualStyleBackColor = true;
            this.tp_rt.Click += new System.EventHandler(this.tp_rt_Click);
            // 
            // lft
            // 
            this.lft.Location = new System.Drawing.Point(137, 262);
            this.lft.Margin = new System.Windows.Forms.Padding(0);
            this.lft.Name = "lft";
            this.lft.Size = new System.Drawing.Size(125, 125);
            this.lft.TabIndex = 3;
            this.lft.UseVisualStyleBackColor = true;
            this.lft.Click += new System.EventHandler(this.lft_Click);
            // 
            // mid
            // 
            this.mid.Location = new System.Drawing.Point(262, 137);
            this.mid.Margin = new System.Windows.Forms.Padding(0);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(125, 125);
            this.mid.TabIndex = 4;
            this.mid.UseVisualStyleBackColor = true;
            this.mid.Click += new System.EventHandler(this.mid_Click);
            // 
            // rt
            // 
            this.rt.Location = new System.Drawing.Point(12, 262);
            this.rt.Margin = new System.Windows.Forms.Padding(0);
            this.rt.Name = "rt";
            this.rt.Size = new System.Drawing.Size(125, 125);
            this.rt.TabIndex = 5;
            this.rt.UseVisualStyleBackColor = true;
            this.rt.Click += new System.EventHandler(this.rt_Click);
            // 
            // btm_lft
            // 
            this.btm_lft.Location = new System.Drawing.Point(12, 137);
            this.btm_lft.Margin = new System.Windows.Forms.Padding(0);
            this.btm_lft.Name = "btm_lft";
            this.btm_lft.Size = new System.Drawing.Size(125, 125);
            this.btm_lft.TabIndex = 6;
            this.btm_lft.UseVisualStyleBackColor = true;
            this.btm_lft.Click += new System.EventHandler(this.btm_lft_Click);
            // 
            // btm
            // 
            this.btm.Location = new System.Drawing.Point(262, 262);
            this.btm.Margin = new System.Windows.Forms.Padding(0);
            this.btm.Name = "btm";
            this.btm.Size = new System.Drawing.Size(125, 125);
            this.btm.TabIndex = 7;
            this.btm.UseVisualStyleBackColor = true;
            this.btm.Click += new System.EventHandler(this.btm_Click);
            // 
            // btm_rt
            // 
            this.btm_rt.Location = new System.Drawing.Point(137, 137);
            this.btm_rt.Margin = new System.Windows.Forms.Padding(0);
            this.btm_rt.Name = "btm_rt";
            this.btm_rt.Size = new System.Drawing.Size(125, 125);
            this.btm_rt.TabIndex = 8;
            this.btm_rt.UseVisualStyleBackColor = true;
            this.btm_rt.Click += new System.EventHandler(this.btm_rt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btm_rt);
            this.Controls.Add(this.btm);
            this.Controls.Add(this.btm_lft);
            this.Controls.Add(this.rt);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.lft);
            this.Controls.Add(this.tp_rt);
            this.Controls.Add(this.tp);
            this.Controls.Add(this.tp_lft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tp_lft;
        private System.Windows.Forms.Button tp;
        private System.Windows.Forms.Button tp_rt;
        private System.Windows.Forms.Button lft;
        private System.Windows.Forms.Button mid;
        private System.Windows.Forms.Button rt;
        private System.Windows.Forms.Button btm_lft;
        private System.Windows.Forms.Button btm;
        private System.Windows.Forms.Button btm_rt;
    }
}

