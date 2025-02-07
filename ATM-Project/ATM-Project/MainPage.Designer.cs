namespace ATM_Project;

partial class MainPage
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
        btn_Deposit = new Button();
        btn_Withdraw = new Button();
        btn_FastCash = new Button();
        btn_LastTransaction = new Button();
        btn_ChangePIN = new Button();
        btn_Balance = new Button();
        panel2 = new Panel();
        lbl_Logout = new Label();
        panel1.SuspendLayout();
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
        panel1.Size = new Size(873,103);
        panel1.TabIndex = 0;
        // 
        // lbl_CloseApplication
        // 
        lbl_CloseApplication.AutoSize = true;
        lbl_CloseApplication.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_CloseApplication.ForeColor = Color.White;
        lbl_CloseApplication.Location = new Point(832,3);
        lbl_CloseApplication.Name = "lbl_CloseApplication";
        lbl_CloseApplication.Size = new Size(43,42);
        lbl_CloseApplication.TabIndex = 2;
        lbl_CloseApplication.Text = "X";
        lbl_CloseApplication.Click += lbl_CloseApplication_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(205,30);
        label1.Name = "label1";
        label1.Size = new Size(465,42);
        label1.TabIndex = 2;
        label1.Text = "Please Select Your Process";
        // 
        // btn_Deposit
        // 
        btn_Deposit.BackColor = Color.FromArgb(  135,  30,  53);
        btn_Deposit.FlatStyle = FlatStyle.Flat;
        btn_Deposit.Font = new Font("Arial",14.25F);
        btn_Deposit.ForeColor = Color.White;
        btn_Deposit.Location = new Point(66,185);
        btn_Deposit.Margin = new Padding(3,4,3,4);
        btn_Deposit.Name = "btn_Deposit";
        btn_Deposit.Size = new Size(264,47);
        btn_Deposit.TabIndex = 5;
        btn_Deposit.Text = "DEPOSIT";
        btn_Deposit.UseVisualStyleBackColor = false;
        btn_Deposit.Click += btn_Deposit_Click;
        // 
        // btn_Withdraw
        // 
        btn_Withdraw.BackColor = Color.FromArgb(  135,  30,  53);
        btn_Withdraw.FlatStyle = FlatStyle.Flat;
        btn_Withdraw.Font = new Font("Arial",14.25F);
        btn_Withdraw.ForeColor = Color.White;
        btn_Withdraw.Location = new Point(522,185);
        btn_Withdraw.Margin = new Padding(3,4,3,4);
        btn_Withdraw.Name = "btn_Withdraw";
        btn_Withdraw.Size = new Size(272,47);
        btn_Withdraw.TabIndex = 5;
        btn_Withdraw.Text = "WITHDRAW";
        btn_Withdraw.UseVisualStyleBackColor = false;
        btn_Withdraw.Click += btn_Withdraw_Click;
        // 
        // btn_FastCash
        // 
        btn_FastCash.BackColor = Color.FromArgb(  135,  30,  53);
        btn_FastCash.FlatStyle = FlatStyle.Flat;
        btn_FastCash.Font = new Font("Arial",14.25F);
        btn_FastCash.ForeColor = Color.White;
        btn_FastCash.Location = new Point(66,309);
        btn_FastCash.Margin = new Padding(3,4,3,4);
        btn_FastCash.Name = "btn_FastCash";
        btn_FastCash.Size = new Size(264,47);
        btn_FastCash.TabIndex = 5;
        btn_FastCash.Text = "FAST CASH";
        btn_FastCash.UseVisualStyleBackColor = false;
        btn_FastCash.Click += btn_FastCash_Click;
        // 
        // btn_LastTransaction
        // 
        btn_LastTransaction.BackColor = Color.FromArgb(  135,  30,  53);
        btn_LastTransaction.FlatStyle = FlatStyle.Flat;
        btn_LastTransaction.Font = new Font("Arial",14.25F);
        btn_LastTransaction.ForeColor = Color.White;
        btn_LastTransaction.Location = new Point(522,309);
        btn_LastTransaction.Margin = new Padding(3,4,3,4);
        btn_LastTransaction.Name = "btn_LastTransaction";
        btn_LastTransaction.Size = new Size(272,47);
        btn_LastTransaction.TabIndex = 5;
        btn_LastTransaction.Text = "LAST TRANSACTIONS";
        btn_LastTransaction.UseVisualStyleBackColor = false;
        btn_LastTransaction.Click += btn_LastTransaction_Click;
        // 
        // btn_ChangePIN
        // 
        btn_ChangePIN.BackColor = Color.FromArgb(  135,  30,  53);
        btn_ChangePIN.FlatStyle = FlatStyle.Flat;
        btn_ChangePIN.Font = new Font("Arial",14.25F);
        btn_ChangePIN.ForeColor = Color.White;
        btn_ChangePIN.Location = new Point(66,436);
        btn_ChangePIN.Margin = new Padding(3,4,3,4);
        btn_ChangePIN.Name = "btn_ChangePIN";
        btn_ChangePIN.Size = new Size(264,47);
        btn_ChangePIN.TabIndex = 5;
        btn_ChangePIN.Text = "CHANG PIN";
        btn_ChangePIN.UseVisualStyleBackColor = false;
        btn_ChangePIN.Click += btn_ChangePIN_Click;
        // 
        // btn_Balance
        // 
        btn_Balance.BackColor = Color.FromArgb(  135,  30,  53);
        btn_Balance.FlatStyle = FlatStyle.Flat;
        btn_Balance.Font = new Font("Arial",14.25F);
        btn_Balance.ForeColor = Color.White;
        btn_Balance.Location = new Point(522,436);
        btn_Balance.Margin = new Padding(3,4,3,4);
        btn_Balance.Name = "btn_Balance";
        btn_Balance.Size = new Size(272,47);
        btn_Balance.TabIndex = 5;
        btn_Balance.Text = "BALANCE";
        btn_Balance.UseVisualStyleBackColor = false;
        btn_Balance.Click += btn_Balance_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,623);
        panel2.Margin = new Padding(3,4,3,4);
        panel2.Name = "panel2";
        panel2.Size = new Size(873,20);
        panel2.TabIndex = 6;
        // 
        // lbl_Logout
        // 
        lbl_Logout.AutoSize = true;
        lbl_Logout.Font = new Font("Arial",12F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_Logout.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_Logout.Location = new Point(381,560);
        lbl_Logout.Name = "lbl_Logout";
        lbl_Logout.Size = new Size(94,23);
        lbl_Logout.TabIndex = 7;
        lbl_Logout.Text = "LOGOUT";
        lbl_Logout.Click += lbl_Logout_Click;
        // 
        // MainPage
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(873,643);
        Controls.Add(lbl_Logout);
        Controls.Add(panel2);
        Controls.Add(btn_Withdraw);
        Controls.Add(btn_LastTransaction);
        Controls.Add(btn_Balance);
        Controls.Add(btn_ChangePIN);
        Controls.Add(btn_FastCash);
        Controls.Add(btn_Deposit);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3,4,3,4);
        Name = "MainPage";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "MainPage";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label lbl_CloseApplication;
    private Label label1;
    private Button btn_Deposit;
    private Button btn_Withdraw;
    private Button btn_FastCash;
    private Button btn_LastTransaction;
    private Button btn_ChangePIN;
    private Button btn_Balance;
    private Panel panel2;
    private Label lbl_Logout;
}