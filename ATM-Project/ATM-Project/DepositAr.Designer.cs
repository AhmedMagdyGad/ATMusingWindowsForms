namespace ATM_Project;

partial class DepositAr
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
        btn_Deposit = new Button();
        txt_Amount = new TextBox();
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
        label5.Font = new Font("Arial",19.8000011F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(  135,  30,  53);
        label5.Location = new Point(312,91);
        label5.Name = "label5";
        label5.Size = new Size(70,40);
        label5.TabIndex = 29;
        label5.Text = "ايداع";
        // 
        // lbl_BackHome
        // 
        lbl_BackHome.AutoSize = true;
        lbl_BackHome.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_BackHome.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_BackHome.Location = new Point(240,371);
        lbl_BackHome.Name = "lbl_BackHome";
        lbl_BackHome.Size = new Size(75,35);
        lbl_BackHome.TabIndex = 28;
        lbl_BackHome.Text = "رجوع";
        lbl_BackHome.Click += lbl_BackHome_Click;
        // 
        // btn_Deposit
        // 
        btn_Deposit.BackColor = Color.FromArgb(  135,  30,  53);
        btn_Deposit.FlatStyle = FlatStyle.Flat;
        btn_Deposit.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        btn_Deposit.ForeColor = Color.White;
        btn_Deposit.Location = new Point(189,304);
        btn_Deposit.Margin = new Padding(3,4,3,4);
        btn_Deposit.Name = "btn_Deposit";
        btn_Deposit.Size = new Size(179,47);
        btn_Deposit.TabIndex = 27;
        btn_Deposit.Text = "ايداع";
        btn_Deposit.UseVisualStyleBackColor = false;
        btn_Deposit.Click += btn_Deposit_Click;
        // 
        // txt_Amount
        // 
        txt_Amount.Font = new Font("Arial",14.25F);
        txt_Amount.Location = new Point(146,220);
        txt_Amount.Margin = new Padding(3,4,3,4);
        txt_Amount.Name = "txt_Amount";
        txt_Amount.Size = new Size(262,35);
        txt_Amount.TabIndex = 26;
        txt_Amount.KeyPress += txt_Amount_KeyPress;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial",18F);
        label3.ForeColor = Color.FromArgb(  135,  30,  53);
        label3.Location = new Point(470,220);
        label3.Name = "label3";
        label3.Size = new Size(66,35);
        label3.TabIndex = 25;
        label3.Text = "المبلغ";
        // 
        // DepositAr
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(685,505);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(label5);
        Controls.Add(lbl_BackHome);
        Controls.Add(btn_Deposit);
        Controls.Add(txt_Amount);
        Controls.Add(label3);
        FormBorderStyle = FormBorderStyle.None;
        Name = "DepositAr";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "DepositAr";
        Load += DepositAr_Load;
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
    private Button btn_Deposit;
    private TextBox txt_Amount;
    private Label label3;
}