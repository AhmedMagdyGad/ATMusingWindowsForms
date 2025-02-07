namespace ATM_Project;

partial class DepositForWallet
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
        lbl_GoHome = new Label();
        btn_Deposit = new Button();
        txt_Deposit = new TextBox();
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
        panel2.TabIndex = 24;
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
        panel1.TabIndex = 23;
        // 
        // lbl_CloseApplication
        // 
        lbl_CloseApplication.AutoSize = true;
        lbl_CloseApplication.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_CloseApplication.ForeColor = Color.White;
        lbl_CloseApplication.Location = new Point(648,1);
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
        label5.Location = new Point(278,104);
        label5.Name = "label5";
        label5.Size = new Size(146,35);
        label5.TabIndex = 29;
        label5.Text = "DEPOSIT";
        // 
        // lbl_GoHome
        // 
        lbl_GoHome.AutoSize = true;
        lbl_GoHome.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_GoHome.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_GoHome.Location = new Point(385,387);
        lbl_GoHome.Name = "lbl_GoHome";
        lbl_GoHome.Size = new Size(96,35);
        lbl_GoHome.TabIndex = 28;
        lbl_GoHome.Text = "BACK";
        lbl_GoHome.Click += lbl_GoHome_Click;
        // 
        // btn_Deposit
        // 
        btn_Deposit.BackColor = Color.FromArgb(  135,  30,  53);
        btn_Deposit.FlatStyle = FlatStyle.Flat;
        btn_Deposit.Font = new Font("Arial",14.25F);
        btn_Deposit.ForeColor = Color.White;
        btn_Deposit.Location = new Point(345,325);
        btn_Deposit.Margin = new Padding(3,4,3,4);
        btn_Deposit.Name = "btn_Deposit";
        btn_Deposit.Size = new Size(179,47);
        btn_Deposit.TabIndex = 27;
        btn_Deposit.Text = "DEPOSIT";
        btn_Deposit.UseVisualStyleBackColor = false;
        btn_Deposit.Click += btn_Deposit_Click;
        // 
        // txt_Deposit
        // 
        txt_Deposit.Font = new Font("Arial",14.25F);
        txt_Deposit.Location = new Point(306,240);
        txt_Deposit.Margin = new Padding(3,4,3,4);
        txt_Deposit.Name = "txt_Deposit";
        txt_Deposit.Size = new Size(262,35);
        txt_Deposit.TabIndex = 26;
        txt_Deposit.KeyPress += txt_Deposit_KeyPress;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial",18F);
        label3.ForeColor = Color.FromArgb(  135,  30,  53);
        label3.Location = new Point(107,241);
        label3.Name = "label3";
        label3.Size = new Size(145,35);
        label3.TabIndex = 25;
        label3.Text = "AMOUNT";
        // 
        // DepositForWallet
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(685,505);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(label5);
        Controls.Add(lbl_GoHome);
        Controls.Add(btn_Deposit);
        Controls.Add(txt_Deposit);
        Controls.Add(label3);
        FormBorderStyle = FormBorderStyle.None;
        Name = "DepositForWallet";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "DepositForWallet";
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
    private Label lbl_GoHome;
    private Button btn_Deposit;
    private TextBox txt_Deposit;
    private Label label3;
}