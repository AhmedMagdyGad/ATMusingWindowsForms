namespace ATM_Project;

partial class MainPageAr
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
        lbl_Logout = new Label();
        panel2 = new Panel();
        btn_Withdraw = new Button();
        btn_LastTransactions = new Button();
        btn_Balance = new Button();
        btn_ChangePIN = new Button();
        btn_FastCash = new Button();
        btn_Deposit = new Button();
        panel1 = new Panel();
        lbl_CloseApplication = new Label();
        label1 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // lbl_Logout
        // 
        lbl_Logout.AutoSize = true;
        lbl_Logout.Font = new Font("Arial",19.8000011F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_Logout.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_Logout.Location = new Point(395,541);
        lbl_Logout.Name = "lbl_Logout";
        lbl_Logout.Size = new Size(86,39);
        lbl_Logout.TabIndex = 16;
        lbl_Logout.Text = "خروج";
        lbl_Logout.Click += lbl_Logout_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,623);
        panel2.Margin = new Padding(3,4,3,4);
        panel2.Name = "panel2";
        panel2.Size = new Size(873,20);
        panel2.TabIndex = 15;
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
        btn_Withdraw.Size = new Size(264,47);
        btn_Withdraw.TabIndex = 9;
        btn_Withdraw.Text = "سحب";
        btn_Withdraw.UseVisualStyleBackColor = false;
        btn_Withdraw.Click += btn_Withdraw_Click;
        // 
        // btn_LastTransactions
        // 
        btn_LastTransactions.BackColor = Color.FromArgb(  135,  30,  53);
        btn_LastTransactions.FlatStyle = FlatStyle.Flat;
        btn_LastTransactions.Font = new Font("Arial",14.25F);
        btn_LastTransactions.ForeColor = Color.White;
        btn_LastTransactions.Location = new Point(522,309);
        btn_LastTransactions.Margin = new Padding(3,4,3,4);
        btn_LastTransactions.Name = "btn_LastTransactions";
        btn_LastTransactions.Size = new Size(264,47);
        btn_LastTransactions.TabIndex = 10;
        btn_LastTransactions.Text = "اخر العمليات";
        btn_LastTransactions.UseVisualStyleBackColor = false;
        btn_LastTransactions.Click += btn_LastTransactions_Click;
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
        btn_Balance.Size = new Size(264,47);
        btn_Balance.TabIndex = 11;
        btn_Balance.Text = "الرصيد";
        btn_Balance.UseVisualStyleBackColor = false;
        btn_Balance.Click += btn_Balance_Click;
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
        btn_ChangePIN.TabIndex = 12;
        btn_ChangePIN.Text = "تغير الرقم السري";
        btn_ChangePIN.UseVisualStyleBackColor = false;
        btn_ChangePIN.Click += btn_ChangePIN_Click;
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
        btn_FastCash.TabIndex = 13;
        btn_FastCash.Text = "سحب سريع";
        btn_FastCash.UseVisualStyleBackColor = false;
        btn_FastCash.Click += btn_FastCash_Click;
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
        btn_Deposit.TabIndex = 14;
        btn_Deposit.Text = "ايداع";
        btn_Deposit.UseVisualStyleBackColor = false;
        btn_Deposit.Click += btn_Deposit_Click;
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
        panel1.TabIndex = 8;
        // 
        // lbl_CloseApplication
        // 
        lbl_CloseApplication.AutoSize = true;
        lbl_CloseApplication.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_CloseApplication.ForeColor = Color.White;
        lbl_CloseApplication.Location = new Point(830,1);
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
        label1.Location = new Point(296,29);
        label1.Name = "label1";
        label1.Size = new Size(285,42);
        label1.TabIndex = 2;
        label1.Text = "من فضلك اختر العملية";
        // 
        // MainPageAr
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(873,643);
        Controls.Add(lbl_Logout);
        Controls.Add(panel2);
        Controls.Add(btn_Withdraw);
        Controls.Add(btn_LastTransactions);
        Controls.Add(btn_Balance);
        Controls.Add(btn_ChangePIN);
        Controls.Add(btn_FastCash);
        Controls.Add(btn_Deposit);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MainPageAr";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "MainPageAr";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl_Logout;
    private Panel panel2;
    private Button btn_Withdraw;
    private Button btn_LastTransactions;
    private Button btn_Balance;
    private Button btn_ChangePIN;
    private Button btn_FastCash;
    private Button btn_Deposit;
    private Panel panel1;
    private Label lbl_CloseApplication;
    private Label label1;
}