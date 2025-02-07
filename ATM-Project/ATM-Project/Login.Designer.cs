namespace ATM_Project;

partial class Login
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
        lbl_SignIn = new Label();
        pictureBox1 = new PictureBox();
        label3 = new Label();
        label4 = new Label();
        txt_AccountPINCode = new TextBox();
        txt_AccountNumber = new TextBox();
        btn_Login = new Button();
        label5 = new Label();
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
        panel1.TabIndex = 0;
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
        // lbl_SignIn
        // 
        lbl_SignIn.AutoSize = true;
        lbl_SignIn.Font = new Font("Arial",12F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_SignIn.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_SignIn.Location = new Point(442,413);
        lbl_SignIn.Name = "lbl_SignIn";
        lbl_SignIn.Size = new Size(84,23);
        lbl_SignIn.TabIndex = 1;
        lbl_SignIn.Text = "SIGNUP";
        lbl_SignIn.Click += lbl_SignIn_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.Login;
        pictureBox1.Location = new Point(24,200);
        pictureBox1.Margin = new Padding(3,4,3,4);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(126,132);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial",14.25F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label3.ForeColor = Color.FromArgb(  135,  30,  53);
        label3.Location = new Point(172,206);
        label3.Name = "label3";
        label3.Size = new Size(170,27);
        label3.TabIndex = 1;
        label3.Text = "ACC NUMBER";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Arial",14.25F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label4.ForeColor = Color.FromArgb(  135,  30,  53);
        label4.Location = new Point(172,291);
        label4.Name = "label4";
        label4.Size = new Size(127,27);
        label4.TabIndex = 1;
        label4.Text = "PIN CODE";
        // 
        // txt_AccountPINCode
        // 
        txt_AccountPINCode.Font = new Font("Arial",14.25F);
        txt_AccountPINCode.Location = new Point(362,283);
        txt_AccountPINCode.Margin = new Padding(3,4,3,4);
        txt_AccountPINCode.MaxLength = 4;
        txt_AccountPINCode.Name = "txt_AccountPINCode";
        txt_AccountPINCode.PasswordChar = '●';
        txt_AccountPINCode.Size = new Size(302,35);
        txt_AccountPINCode.TabIndex = 3;
        txt_AccountPINCode.KeyPress += txt_AccountPINCode_KeyPress;
        // 
        // txt_AccountNumber
        // 
        txt_AccountNumber.Font = new Font("Arial",14.25F);
        txt_AccountNumber.Location = new Point(362,198);
        txt_AccountNumber.Margin = new Padding(3,4,3,4);
        txt_AccountNumber.MaxLength = 30;
        txt_AccountNumber.Name = "txt_AccountNumber";
        txt_AccountNumber.Size = new Size(302,35);
        txt_AccountNumber.TabIndex = 3;
        txt_AccountNumber.KeyPress += txt_AccountNumber_KeyPress;
        // 
        // btn_Login
        // 
        btn_Login.BackColor = Color.FromArgb(  135,  30,  53);
        btn_Login.FlatStyle = FlatStyle.Flat;
        btn_Login.Font = new Font("Arial",14.25F);
        btn_Login.ForeColor = Color.White;
        btn_Login.Location = new Point(390,358);
        btn_Login.Margin = new Padding(3,4,3,4);
        btn_Login.Name = "btn_Login";
        btn_Login.Size = new Size(179,47);
        btn_Login.TabIndex = 4;
        btn_Login.Text = "LOGIN";
        btn_Login.UseVisualStyleBackColor = false;
        btn_Login.Click += btn_Login_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(  135,  30,  53);
        label5.Location = new Point(293,96);
        label5.Name = "label5";
        label5.Size = new Size(109,35);
        label5.TabIndex = 1;
        label5.Text = "LOGIN";
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(685,505);
        Controls.Add(label5);
        Controls.Add(btn_Login);
        Controls.Add(txt_AccountNumber);
        Controls.Add(txt_AccountPINCode);
        Controls.Add(pictureBox1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(lbl_SignIn);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3,4,3,4);
        Name = "Login";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        Load += Login_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Label lbl_SignIn;
    private PictureBox pictureBox1;
    private Label label3;
    private Label label4;
    private TextBox txt_AccountPINCode;
    private TextBox txt_AccountNumber;
    private Button btn_Login;
    private Label lbl_CloseApplication;
    private Label label5;
}