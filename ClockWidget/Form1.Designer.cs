
namespace ClockWidget
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Hours = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbl_clock
            // 
            this.lbl_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_clock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clock.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_clock.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_clock.ForeColor = System.Drawing.Color.White;
            this.lbl_clock.Location = new System.Drawing.Point(12, 235);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_clock.Size = new System.Drawing.Size(1010, 58);
            this.lbl_clock.TabIndex = 0;
            this.lbl_clock.Text = "Friday, 29 May 2015";
            this.lbl_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Hours
            // 
            this.lbl_Hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Hours.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hours.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Hours.Font = new System.Drawing.Font("Century Gothic", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Hours.ForeColor = System.Drawing.Color.White;
            this.lbl_Hours.Location = new System.Drawing.Point(12, 73);
            this.lbl_Hours.Name = "lbl_Hours";
            this.lbl_Hours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Hours.Size = new System.Drawing.Size(1004, 115);
            this.lbl_Hours.TabIndex = 1;
            this.lbl_Hours.Text = "label1";
            this.lbl_Hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Hours.Click += new System.EventHandler(this.lbl_Hours_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(186, 310);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(660, 2);
            this.label1.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Image = global::ClockWidget.Properties.Resources.icons8_delete_50;
            this.btn_exit.Location = new System.Drawing.Point(977, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(39, 40);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 3;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.Black;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.Black;
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(22, 14);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 4;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1028, 388);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Hours);
            this.Controls.Add(this.lbl_clock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Hours;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_exit;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
    }
}

