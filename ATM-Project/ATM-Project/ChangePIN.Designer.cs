namespace ATM_Project;

partial class ChangePIN
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
        label2 = new Label();
        label3 = new Label();
        btn_ChangePIN = new Button();
        txt_ConfirmPIN = new TextBox();
        txt_NewPIN = new TextBox();
        lbl_BackHome = new Label();
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
        panel2.TabIndex = 11;
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
        panel1.TabIndex = 10;
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
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial",18F);
        label2.ForeColor = Color.FromArgb(  135,  30,  53);
        label2.Location = new Point(79,287);
        label2.Name = "label2";
        label2.Size = new Size(211,35);
        label2.TabIndex = 12;
        label2.Text = "CONFIRM PIN";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial",18F);
        label3.ForeColor = Color.FromArgb(  135,  30,  53);
        label3.Location = new Point(79,176);
        label3.Name = "label3";
        label3.Size = new Size(144,35);
        label3.TabIndex = 13;
        label3.Text = "NEW PIN";
        // 
        // btn_ChangePIN
        // 
        btn_ChangePIN.BackColor = Color.FromArgb(  135,  30,  53);
        btn_ChangePIN.FlatStyle = FlatStyle.Flat;
        btn_ChangePIN.Font = new Font("Arial",14.25F);
        btn_ChangePIN.ForeColor = Color.White;
        btn_ChangePIN.Location = new Point(359,367);
        btn_ChangePIN.Margin = new Padding(3,4,3,4);
        btn_ChangePIN.Name = "btn_ChangePIN";
        btn_ChangePIN.Size = new Size(179,47);
        btn_ChangePIN.TabIndex = 16;
        btn_ChangePIN.Text = "CHANGE";
        btn_ChangePIN.UseVisualStyleBackColor = false;
        btn_ChangePIN.Click += btn_ChangePIN_Click;
        // 
        // txt_ConfirmPIN
        // 
        txt_ConfirmPIN.Font = new Font("Arial",14.25F);
        txt_ConfirmPIN.Location = new Point(317,287);
        txt_ConfirmPIN.Margin = new Padding(3,4,3,4);
        txt_ConfirmPIN.Name = "txt_ConfirmPIN";
        txt_ConfirmPIN.Size = new Size(262,35);
        txt_ConfirmPIN.TabIndex = 14;
        txt_ConfirmPIN.KeyPress += txt_ConfirmPIN_KeyPress;
        txt_ConfirmPIN.Leave += txt_ConfirmPIN_Leave;
        // 
        // txt_NewPIN
        // 
        txt_NewPIN.Font = new Font("Arial",14.25F);
        txt_NewPIN.Location = new Point(317,176);
        txt_NewPIN.Margin = new Padding(3,4,3,4);
        txt_NewPIN.Name = "txt_NewPIN";
        txt_NewPIN.Size = new Size(262,35);
        txt_NewPIN.TabIndex = 15;
        txt_NewPIN.KeyPress += txt_NewPIN_KeyPress;
        txt_NewPIN.Leave += txt_NewPIN_Leave;
        // 
        // lbl_BackHome
        // 
        lbl_BackHome.AutoSize = true;
        lbl_BackHome.Font = new Font("Arial",16.2F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_BackHome.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_BackHome.Location = new Point(401,428);
        lbl_BackHome.Name = "lbl_BackHome";
        lbl_BackHome.Size = new Size(91,32);
        lbl_BackHome.TabIndex = 17;
        lbl_BackHome.Text = "BACK";
        lbl_BackHome.Click += lbl_BackHome_Click;
        // 
        // ChangePIN
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(685,505);
        Controls.Add(lbl_BackHome);
        Controls.Add(btn_ChangePIN);
        Controls.Add(txt_ConfirmPIN);
        Controls.Add(txt_NewPIN);
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3,4,3,4);
        Name = "ChangePIN";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ChangePIN";
        Load += ChangePIN_Load;
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
    private Label label2;
    private Label label3;
    private Button btn_ChangePIN;
    private TextBox txt_ConfirmPIN;
    private TextBox txt_NewPIN;
    private Label lbl_BackHome;
}