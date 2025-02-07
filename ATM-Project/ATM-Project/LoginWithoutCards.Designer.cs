namespace ATM_Project;

partial class LoginWithoutCards
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
        label5 = new Label();
        btn_Login = new Button();
        txt_AccountNumber = new TextBox();
        pictureBox1 = new PictureBox();
        txt_PhoneNumber = new Label();
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
        panel1.Margin = new Padding(3,4,3,4);
        panel1.Name = "panel1";
        panel1.Size = new Size(685,76);
        panel1.TabIndex = 5;
        // 
        // lbl_CloseApplication
        // 
        lbl_CloseApplication.AutoSize = true;
        lbl_CloseApplication.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_CloseApplication.ForeColor = Color.White;
        lbl_CloseApplication.Location = new Point(649,4);
        lbl_CloseApplication.Name = "lbl_CloseApplication";
        lbl_CloseApplication.Size = new Size(34,35);
        lbl_CloseApplication.TabIndex = 1;
        lbl_CloseApplication.Text = "X";
        lbl_CloseApplication.Click += lbl_CloseApplication_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(278,11);
        label1.Name = "label1";
        label1.Size = new Size(143,42);
        label1.TabIndex = 1;
        label1.Text = "ITI ATM";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(  135,  30,  53);
        label5.Location = new Point(293,101);
        label5.Name = "label5";
        label5.Size = new Size(109,35);
        label5.TabIndex = 6;
        label5.Text = "LOGIN";
        // 
        // btn_Login
        // 
        btn_Login.BackColor = Color.FromArgb(  135,  30,  53);
        btn_Login.FlatStyle = FlatStyle.Flat;
        btn_Login.Font = new Font("Arial",14.25F);
        btn_Login.ForeColor = Color.White;
        btn_Login.Location = new Point(399,364);
        btn_Login.Margin = new Padding(3,4,3,4);
        btn_Login.Name = "btn_Login";
        btn_Login.Size = new Size(179,47);
        btn_Login.TabIndex = 13;
        btn_Login.Text = "LOGIN";
        btn_Login.UseVisualStyleBackColor = false;
        btn_Login.Click += btn_Login_Click;
        // 
        // txt_AccountNumber
        // 
        txt_AccountNumber.Font = new Font("Arial",14.25F);
        txt_AccountNumber.Location = new Point(327,266);
        txt_AccountNumber.Margin = new Padding(3,4,3,4);
        txt_AccountNumber.MaxLength = 30;
        txt_AccountNumber.Name = "txt_AccountNumber";
        txt_AccountNumber.Size = new Size(302,35);
        txt_AccountNumber.TabIndex = 11;
        txt_AccountNumber.KeyPress += txt_AccountNumber_KeyPress;
        txt_AccountNumber.Leave += txt_AccountNumber_Leave;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.Login;
        pictureBox1.Location = new Point(24,211);
        pictureBox1.Margin = new Padding(3,4,3,4);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(126,132);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 10;
        pictureBox1.TabStop = false;
        // 
        // txt_PhoneNumber
        // 
        txt_PhoneNumber.AutoSize = true;
        txt_PhoneNumber.Font = new Font("Arial",14.25F,FontStyle.Regular,GraphicsUnit.Point, 0);
        txt_PhoneNumber.ForeColor = Color.FromArgb(  135,  30,  53);
        txt_PhoneNumber.Location = new Point(167,274);
        txt_PhoneNumber.Name = "txt_PhoneNumber";
        txt_PhoneNumber.Size = new Size(97,27);
        txt_PhoneNumber.TabIndex = 8;
        txt_PhoneNumber.Text = "PHONE";
        // 
        // LoginWithoutCards
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(685,505);
        Controls.Add(panel1);
        Controls.Add(label5);
        Controls.Add(btn_Login);
        Controls.Add(txt_AccountNumber);
        Controls.Add(pictureBox1);
        Controls.Add(txt_PhoneNumber);
        FormBorderStyle = FormBorderStyle.None;
        Name = "LoginWithoutCards";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LoginWithoutCards";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label lbl_CloseApplication;
    private Label label1;
    private Label label5;
    private Button btn_Login;
    private TextBox txt_AccountNumber;
    private PictureBox pictureBox1;
    private Label txt_PhoneNumber;
}