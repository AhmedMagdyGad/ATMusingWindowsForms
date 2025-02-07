namespace ATM_Project;

partial class WithdrawForWallet
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
        panel2 = new Panel();
        panel1 = new Panel();
        lbl_CloseApplication = new Label();
        label1 = new Label();
        label5 = new Label();
        lbl_BackHome = new Label();
        btn_Withdraw = new Button();
        txt_Withdraw = new TextBox();
        label3 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,485);
        panel2.Margin = new Padding(3,4,3,4);
        panel2.Name = "panel2";
        panel2.Size = new Size(685,20);
        panel2.TabIndex = 29;
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
        panel1.TabIndex = 28;
        // 
        // lbl_CloseApplication
        // 
        lbl_CloseApplication.AutoSize = true;
        lbl_CloseApplication.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_CloseApplication.ForeColor = Color.White;
        lbl_CloseApplication.Location = new Point(649,1);
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
        label5.Location = new Point(267,101);
        label5.Name = "label5";
        label5.Size = new Size(184,35);
        label5.TabIndex = 35;
        label5.Text = "WITHDRAW";
        // 
        // lbl_BackHome
        // 
        lbl_BackHome.AutoSize = true;
        lbl_BackHome.Font = new Font("Arial",16.2F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_BackHome.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_BackHome.Location = new Point(397,389);
        lbl_BackHome.Name = "lbl_BackHome";
        lbl_BackHome.Size = new Size(91,32);
        lbl_BackHome.TabIndex = 33;
        lbl_BackHome.Text = "BACK";
        lbl_BackHome.Click += lbl_BackHome_Click;
        // 
        // btn_Withdraw
        // 
        btn_Withdraw.BackColor = Color.FromArgb(  135,  30,  53);
        btn_Withdraw.FlatStyle = FlatStyle.Flat;
        btn_Withdraw.Font = new Font("Arial",14.25F);
        btn_Withdraw.ForeColor = Color.White;
        btn_Withdraw.Location = new Point(358,325);
        btn_Withdraw.Margin = new Padding(3,4,3,4);
        btn_Withdraw.Name = "btn_Withdraw";
        btn_Withdraw.Size = new Size(179,47);
        btn_Withdraw.TabIndex = 32;
        btn_Withdraw.Text = "WITHDRAW";
        btn_Withdraw.UseVisualStyleBackColor = false;
        btn_Withdraw.Click += btn_Withdraw_Click;
        // 
        // txt_Withdraw
        // 
        txt_Withdraw.Font = new Font("Arial",14.25F);
        txt_Withdraw.Location = new Point(318,245);
        txt_Withdraw.Margin = new Padding(3,4,3,4);
        txt_Withdraw.MaxLength = 11;
        txt_Withdraw.Name = "txt_Withdraw";
        txt_Withdraw.Size = new Size(262,35);
        txt_Withdraw.TabIndex = 31;
        txt_Withdraw.KeyPress += txt_Withdraw_KeyPress;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial",15.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label3.ForeColor = Color.FromArgb(  135,  30,  53);
        label3.Location = new Point(136,249);
        label3.Name = "label3";
        label3.Size = new Size(130,32);
        label3.TabIndex = 30;
        label3.Text = "AMOUNT";
        // 
        // WithdrawForWallet
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(685,505);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(label5);
        Controls.Add(lbl_BackHome);
        Controls.Add(btn_Withdraw);
        Controls.Add(txt_Withdraw);
        Controls.Add(label3);
        FormBorderStyle = FormBorderStyle.None;
        Name = "WithdrawForWallet";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "WithdrawForWallet";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel2;
    private Panel panel1;
    private Label lbl_CloseApplication;
    private Label label1;
    private Label label5;
    private Label lbl_BackHome;
    private Button btn_Withdraw;
    private TextBox txt_Withdraw;
    private Label label3;
}