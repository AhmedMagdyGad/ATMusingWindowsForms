namespace ATM_Project;

partial class LockedScreen
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
        if(disposing && (components != null))
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
        pictureBox1 = new PictureBox();
        label1 = new Label();
        lbl_CloseApplication = new Label();
        ((System.ComponentModel.ISupportInitialize) pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.unlock;
        pictureBox1.Location = new Point(151,91);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(306,188);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial Narrow",15.75F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(62,45);
        label1.Name = "label1";
        label1.Size = new Size(492,25);
        label1.TabIndex = 1;
        label1.Text = "This account is locked, Please contact customer service";
        // 
        // lbl_CloseApplication
        // 
        lbl_CloseApplication.AutoSize = true;
        lbl_CloseApplication.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_CloseApplication.ForeColor = Color.White;
        lbl_CloseApplication.Location = new Point(568,3);
        lbl_CloseApplication.Name = "lbl_CloseApplication";
        lbl_CloseApplication.Size = new Size(27,27);
        lbl_CloseApplication.TabIndex = 2;
        lbl_CloseApplication.Text = "X";
        lbl_CloseApplication.Click += lbl_CloseApplication_Click;
        // 
        // LockedScreen
        // 
        AutoScaleDimensions = new SizeF(7F,15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(  135,  30,  53);
        ClientSize = new Size(599,379);
        Controls.Add(lbl_CloseApplication);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "LockedScreen";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LockedScreen";
        ((System.ComponentModel.ISupportInitialize) pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label label1;
    private Label lbl_CloseApplication;
}