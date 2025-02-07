namespace ATM_Project;

partial class ChooseCardOrWallets
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
        panel1 = new Panel();
        lbl_CloseApplication = new Label();
        label1 = new Label();
        panel2 = new Panel();
        btn_WithCard = new Button();
        btn_WithoutCard = new Button();
        pictureBox1 = new PictureBox();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(  135,  30,  53);
        panel1.Controls.Add(lbl_CloseApplication);
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0,0);
        panel1.Name = "panel1";
        panel1.Size = new Size(599,57);
        panel1.TabIndex = 27;
        // 
        // lbl_CloseApplication
        // 
        lbl_CloseApplication.AutoSize = true;
        lbl_CloseApplication.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_CloseApplication.ForeColor = Color.White;
        lbl_CloseApplication.Location = new Point(567,1);
        lbl_CloseApplication.Name = "lbl_CloseApplication";
        lbl_CloseApplication.Size = new Size(27,27);
        lbl_CloseApplication.TabIndex = 1;
        lbl_CloseApplication.Text = "X";
        lbl_CloseApplication.Click += lbl_CloseApplication_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(243,8);
        label1.Name = "label1";
        label1.Size = new Size(113,33);
        label1.TabIndex = 1;
        label1.Text = "ITI ATM";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,364);
        panel2.Name = "panel2";
        panel2.Size = new Size(599,15);
        panel2.TabIndex = 32;
        // 
        // btn_WithCard
        // 
        btn_WithCard.BackColor = Color.FromArgb(  135,  30,  53);
        btn_WithCard.FlatStyle = FlatStyle.Flat;
        btn_WithCard.Font = new Font("Arial",14.25F);
        btn_WithCard.ForeColor = Color.White;
        btn_WithCard.Location = new Point(332,250);
        btn_WithCard.Name = "btn_WithCard";
        btn_WithCard.Size = new Size(244,62);
        btn_WithCard.TabIndex = 30;
        btn_WithCard.UseVisualStyleBackColor = false;
        btn_WithCard.Click += btn_WithCard_Click;
        // 
        // btn_WithoutCard
        // 
        btn_WithoutCard.BackColor = Color.FromArgb(  135,  30,  53);
        btn_WithoutCard.FlatStyle = FlatStyle.Flat;
        btn_WithoutCard.Font = new Font("Arial",14.25F);
        btn_WithoutCard.ForeColor = Color.White;
        btn_WithoutCard.Location = new Point(24,250);
        btn_WithoutCard.Name = "btn_WithoutCard";
        btn_WithoutCard.Size = new Size(244,62);
        btn_WithoutCard.TabIndex = 31;
        btn_WithoutCard.UseVisualStyleBackColor = false;
        btn_WithoutCard.Click += btn_WithoutCard_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.ATM_Logo;
        pictureBox1.Location = new Point(201,75);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(232,137);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 33;
        pictureBox1.TabStop = false;
        // 
        // ChooseCardOrWallets
        // 
        AutoScaleDimensions = new SizeF(7F,15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(599,379);
        Controls.Add(pictureBox1);
        Controls.Add(panel1);
        Controls.Add(panel2);
        Controls.Add(btn_WithCard);
        Controls.Add(btn_WithoutCard);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3,2,3,2);
        Name = "ChooseCardOrWallets";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ChooseCardOrWallets";
        Load += ChooseCardOrWallets_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label lbl_CloseApplication;
    private Label label1;
    private Panel panel2;
    private Button btn_WithCard;
    private Button btn_WithoutCard;
    private PictureBox pictureBox1;
}