namespace ATM_Project;

partial class Balance
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
        label3 = new Label();
        label2 = new Label();
        panel2 = new Panel();
        lbl_BackHome = new Label();
        lbl_AccountNumber = new Label();
        lbl_AccountBalance = new Label();
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
        panel1.Size = new Size(685,76);
        panel1.TabIndex = 1;
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
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial",18F);
        label3.ForeColor = Color.FromArgb(  135,  30,  53);
        label3.Location = new Point(49,187);
        label3.Name = "label3";
        label3.Size = new Size(310,35);
        label3.TabIndex = 8;
        label3.Text = "ACCOUNT NUMBER:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial",18F);
        label2.ForeColor = Color.FromArgb(  135,  30,  53);
        label2.Location = new Point(49,297);
        label2.Name = "label2";
        label2.Size = new Size(256,35);
        label2.TabIndex = 8;
        label2.Text = "YOUR BALANCE:";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,485);
        panel2.Margin = new Padding(3,4,3,4);
        panel2.Name = "panel2";
        panel2.Size = new Size(685,20);
        panel2.TabIndex = 9;
        // 
        // lbl_BackHome
        // 
        lbl_BackHome.AutoSize = true;
        lbl_BackHome.Font = new Font("Arial",13.8F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_BackHome.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_BackHome.Location = new Point(301,408);
        lbl_BackHome.Name = "lbl_BackHome";
        lbl_BackHome.Size = new Size(74,26);
        lbl_BackHome.TabIndex = 9;
        lbl_BackHome.Text = "BACK";
        lbl_BackHome.Click += lbl_BackHome_Click;
        // 
        // lbl_AccountNumber
        // 
        lbl_AccountNumber.AutoSize = true;
        lbl_AccountNumber.Font = new Font("Arial",18F);
        lbl_AccountNumber.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_AccountNumber.Location = new Point(378,187);
        lbl_AccountNumber.Name = "lbl_AccountNumber";
        lbl_AccountNumber.Size = new Size(128,35);
        lbl_AccountNumber.TabIndex = 8;
        lbl_AccountNumber.Text = "AccNum";
        // 
        // lbl_AccountBalance
        // 
        lbl_AccountBalance.AutoSize = true;
        lbl_AccountBalance.Font = new Font("Arial",18F);
        lbl_AccountBalance.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_AccountBalance.Location = new Point(378,295);
        lbl_AccountBalance.Name = "lbl_AccountBalance";
        lbl_AccountBalance.Size = new Size(122,35);
        lbl_AccountBalance.TabIndex = 8;
        lbl_AccountBalance.Text = "Balance";
        // 
        // Balance
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(685,505);
        Controls.Add(lbl_BackHome);
        Controls.Add(panel2);
        Controls.Add(lbl_AccountBalance);
        Controls.Add(label2);
        Controls.Add(lbl_AccountNumber);
        Controls.Add(label3);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3,4,3,4);
        Name = "Balance";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Balance";
        Load += Balance_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label lbl_CloseApplication;
    private Label label1;
    private Label label3;
    private Label label2;
    private Panel panel2;
    private Label lbl_BackHome;
    private Label lbl_AccountNumber;
    private Label lbl_AccountBalance;
}