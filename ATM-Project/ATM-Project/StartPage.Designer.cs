namespace ATM_Project
{
    partial class StartPage
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            MyProgress = new ProgressBar();
            lbl_ProgressBar = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize) pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(  135,  30,  53);
            label1.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(278,11);
            label1.Name = "label1";
            label1.Size = new Size(143,42);
            label1.TabIndex = 0;
            label1.Text = "ITI ATM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ATM_Logo;
            pictureBox1.Location = new Point(230,100);
            pictureBox1.Margin = new Padding(3,4,3,4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251,236);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MyProgress
            // 
            MyProgress.Location = new Point(-6,475);
            MyProgress.Margin = new Padding(3,4,3,4);
            MyProgress.Name = "MyProgress";
            MyProgress.Size = new Size(692,31);
            MyProgress.TabIndex = 2;
            // 
            // lbl_ProgressBar
            // 
            lbl_ProgressBar.AutoSize = true;
            lbl_ProgressBar.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
            lbl_ProgressBar.ForeColor = Color.White;
            lbl_ProgressBar.Location = new Point(332,417);
            lbl_ProgressBar.Name = "lbl_ProgressBar";
            lbl_ProgressBar.Size = new Size(51,42);
            lbl_ProgressBar.TabIndex = 0;
            lbl_ProgressBar.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(8F,20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  135,  30,  53);
            ClientSize = new Size(685,505);
            Controls.Add(MyProgress);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_ProgressBar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3,4,3,4);
            Name = "StartPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += StartPage_Load;
            ((System.ComponentModel.ISupportInitialize) pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar MyProgress;
        private Label lbl_ProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}
