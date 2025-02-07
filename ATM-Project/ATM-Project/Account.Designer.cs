namespace ATM_Project;

partial class Account
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
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        panel1 = new Panel();
        lbl_CloseApplication = new Label();
        label1 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        label9 = new Label();
        label12 = new Label();
        txt_AccountNumber = new TextBox();
        txt_AccountName = new TextBox();
        txt_AccountFName = new TextBox();
        txt_AccountPhone = new TextBox();
        txt_AccountPIN = new TextBox();
        cb_AccountEducation = new ComboBox();
        panel2 = new Panel();
        btn_Submit = new Button();
        lbl_GoLoginPage = new Label();
        DTP_AccountDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
        label11 = new Label();
        txt_AccountAddress = new RichTextBox();
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
        panel1.Size = new Size(1070,94);
        panel1.TabIndex = 1;
        // 
        // lbl_CloseApplication
        // 
        lbl_CloseApplication.AutoSize = true;
        lbl_CloseApplication.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_CloseApplication.ForeColor = Color.White;
        lbl_CloseApplication.Location = new Point(1027,5);
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
        label1.Location = new Point(460,27);
        label1.Name = "label1";
        label1.Size = new Size(143,42);
        label1.TabIndex = 2;
        label1.Text = "ITI ATM";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial",12F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label3.ForeColor = Color.FromArgb(  135,  30,  53);
        label3.Location = new Point(31,224);
        label3.Name = "label3";
        label3.Size = new Size(194,23);
        label3.TabIndex = 3;
        label3.Text = "ACCOUNT NUMBER";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Arial",12F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label4.ForeColor = Color.FromArgb(  135,  30,  53);
        label4.Location = new Point(31,436);
        label4.Name = "label4";
        label4.Size = new Size(78,23);
        label4.TabIndex = 3;
        label4.Text = "FNAME";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial",12F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(  135,  30,  53);
        label5.Location = new Point(597,334);
        label5.Name = "label5";
        label5.Size = new Size(78,23);
        label5.TabIndex = 3;
        label5.Text = "PHONE";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Arial",12F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label6.ForeColor = Color.FromArgb(  135,  30,  53);
        label6.Location = new Point(31,332);
        label6.Name = "label6";
        label6.Size = new Size(66,23);
        label6.TabIndex = 3;
        label6.Text = "NAME";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Arial",12F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label7.ForeColor = Color.FromArgb(  135,  30,  53);
        label7.Location = new Point(31,555);
        label7.Name = "label7";
        label7.Size = new Size(104,23);
        label7.TabIndex = 3;
        label7.Text = "ADDRESS";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Arial",12F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label8.ForeColor = Color.FromArgb(  135,  30,  53);
        label8.Location = new Point(597,222);
        label8.Name = "label8";
        label8.Size = new Size(105,23);
        label8.TabIndex = 3;
        label8.Text = "PIN CODE";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Arial",12F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label9.ForeColor = Color.FromArgb(  135,  30,  53);
        label9.Location = new Point(597,441);
        label9.Name = "label9";
        label9.Size = new Size(123,23);
        label9.TabIndex = 3;
        label9.Text = "EDUCATION";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Arial",12F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label12.ForeColor = Color.FromArgb(  135,  30,  53);
        label12.Location = new Point(597,552);
        label12.Name = "label12";
        label12.Size = new Size(126,23);
        label12.TabIndex = 3;
        label12.Text = "Date Of Birth";
        // 
        // txt_AccountNumber
        // 
        txt_AccountNumber.Font = new Font("Arial",12F);
        txt_AccountNumber.Location = new Point(231,221);
        txt_AccountNumber.Margin = new Padding(3,4,3,4);
        txt_AccountNumber.MaxLength = 30;
        txt_AccountNumber.Name = "txt_AccountNumber";
        txt_AccountNumber.Size = new Size(313,30);
        txt_AccountNumber.TabIndex = 4;
        txt_AccountNumber.KeyPress += txt_AccountNumber_KeyPress;
        // 
        // txt_AccountName
        // 
        txt_AccountName.Font = new Font("Arial",12F);
        txt_AccountName.Location = new Point(231,332);
        txt_AccountName.Margin = new Padding(3,4,3,4);
        txt_AccountName.MaxLength = 30;
        txt_AccountName.Name = "txt_AccountName";
        txt_AccountName.Size = new Size(313,30);
        txt_AccountName.TabIndex = 4;
        // 
        // txt_AccountFName
        // 
        txt_AccountFName.Font = new Font("Arial",12F);
        txt_AccountFName.Location = new Point(231,436);
        txt_AccountFName.Margin = new Padding(3,4,3,4);
        txt_AccountFName.MaxLength = 30;
        txt_AccountFName.Name = "txt_AccountFName";
        txt_AccountFName.Size = new Size(313,30);
        txt_AccountFName.TabIndex = 4;
        // 
        // txt_AccountPhone
        // 
        txt_AccountPhone.Font = new Font("Arial",12F);
        txt_AccountPhone.Location = new Point(733,330);
        txt_AccountPhone.Margin = new Padding(3,4,3,4);
        txt_AccountPhone.MaxLength = 11;
        txt_AccountPhone.Name = "txt_AccountPhone";
        txt_AccountPhone.Size = new Size(313,30);
        txt_AccountPhone.TabIndex = 4;
        txt_AccountPhone.KeyPress += txt_AccountPhone_KeyPress;
        txt_AccountPhone.Leave += txt_AccountPhone_Leave;
        // 
        // txt_AccountPIN
        // 
        txt_AccountPIN.Font = new Font("Arial",12F);
        txt_AccountPIN.Location = new Point(733,222);
        txt_AccountPIN.Margin = new Padding(3,4,3,4);
        txt_AccountPIN.MaxLength = 4;
        txt_AccountPIN.Name = "txt_AccountPIN";
        txt_AccountPIN.Size = new Size(313,30);
        txt_AccountPIN.TabIndex = 4;
        txt_AccountPIN.KeyPress += txt_AccountPIN_KeyPress;
        // 
        // cb_AccountEducation
        // 
        cb_AccountEducation.Font = new Font("Arial",12F);
        cb_AccountEducation.FormattingEnabled = true;
        cb_AccountEducation.Items.AddRange(new object[] { "Non Graduate","Under Graduate","Post Graduate" });
        cb_AccountEducation.Location = new Point(733,430);
        cb_AccountEducation.Margin = new Padding(3,4,3,4);
        cb_AccountEducation.Name = "cb_AccountEducation";
        cb_AccountEducation.Size = new Size(313,31);
        cb_AccountEducation.TabIndex = 5;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,768);
        panel2.Margin = new Padding(3,4,3,4);
        panel2.Name = "panel2";
        panel2.Size = new Size(1070,20);
        panel2.TabIndex = 7;
        // 
        // btn_Submit
        // 
        btn_Submit.BackColor = Color.FromArgb(  135,  30,  53);
        btn_Submit.FlatStyle = FlatStyle.Flat;
        btn_Submit.Font = new Font("Arial",14.25F);
        btn_Submit.ForeColor = Color.White;
        btn_Submit.Location = new Point(455,669);
        btn_Submit.Margin = new Padding(3,4,3,4);
        btn_Submit.Name = "btn_Submit";
        btn_Submit.Size = new Size(179,47);
        btn_Submit.TabIndex = 5;
        btn_Submit.Text = "SUBMIT";
        btn_Submit.UseVisualStyleBackColor = false;
        btn_Submit.Click += btn_Submit_Click;
        // 
        // lbl_GoLoginPage
        // 
        lbl_GoLoginPage.AutoSize = true;
        lbl_GoLoginPage.Font = new Font("Arial",13.8F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_GoLoginPage.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_GoLoginPage.Location = new Point(502,725);
        lbl_GoLoginPage.Name = "lbl_GoLoginPage";
        lbl_GoLoginPage.Size = new Size(84,26);
        lbl_GoLoginPage.TabIndex = 8;
        lbl_GoLoginPage.Text = "LOGIN";
        lbl_GoLoginPage.Click += lbl_GoLoginPage_Click;
        // 
        // DTP_AccountDateOfBirth
        // 
        DTP_AccountDateOfBirth.Checked = true;
        DTP_AccountDateOfBirth.CustomizableEdges = customizableEdges1;
        DTP_AccountDateOfBirth.FillColor = Color.FromArgb(  135,  30,  53);
        DTP_AccountDateOfBirth.Font = new Font("Segoe UI",9F);
        DTP_AccountDateOfBirth.ForeColor = Color.White;
        DTP_AccountDateOfBirth.Format = DateTimePickerFormat.Long;
        DTP_AccountDateOfBirth.Location = new Point(773,539);
        DTP_AccountDateOfBirth.Margin = new Padding(3,4,3,4);
        DTP_AccountDateOfBirth.MaxDate = new DateTime(9998,12,31,0,0,0,0);
        DTP_AccountDateOfBirth.MinDate = new DateTime(1753,1,1,0,0,0,0);
        DTP_AccountDateOfBirth.Name = "DTP_AccountDateOfBirth";
        DTP_AccountDateOfBirth.ShadowDecoration.CustomizableEdges = customizableEdges2;
        DTP_AccountDateOfBirth.Size = new Size(219,48);
        DTP_AccountDateOfBirth.TabIndex = 9;
        DTP_AccountDateOfBirth.Value = new DateTime(2025,1,25,0,17,28,763);
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Arial",19.8000011F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label11.ForeColor = Color.FromArgb(  135,  30,  53);
        label11.Location = new Point(455,120);
        label11.Name = "label11";
        label11.Size = new Size(154,40);
        label11.TabIndex = 29;
        label11.Text = "Register";
        // 
        // txt_AccountAddress
        // 
        txt_AccountAddress.Font = new Font("Arial Narrow",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_AccountAddress.Location = new Point(231,520);
        txt_AccountAddress.MaxLength = 100;
        txt_AccountAddress.Name = "txt_AccountAddress";
        txt_AccountAddress.Size = new Size(313,120);
        txt_AccountAddress.TabIndex = 30;
        txt_AccountAddress.Text = "";
        // 
        // Account
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1070,788);
        Controls.Add(txt_AccountAddress);
        Controls.Add(label11);
        Controls.Add(DTP_AccountDateOfBirth);
        Controls.Add(lbl_GoLoginPage);
        Controls.Add(btn_Submit);
        Controls.Add(panel2);
        Controls.Add(cb_AccountEducation);
        Controls.Add(txt_AccountPhone);
        Controls.Add(txt_AccountFName);
        Controls.Add(txt_AccountName);
        Controls.Add(txt_AccountPIN);
        Controls.Add(txt_AccountNumber);
        Controls.Add(label12);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label9);
        Controls.Add(label4);
        Controls.Add(label8);
        Controls.Add(label3);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3,4,3,4);
        Name = "Account";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Account";
        Load += Account_Load;
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
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label12;
    private TextBox txt_AccountNumber;
    private TextBox txt_AccountName;
    private TextBox txt_AccountFName;
    private TextBox txt_AccountPhone;
    private TextBox txt_AccountPIN;
    private ComboBox cb_AccountEducation;
    private Panel panel2;
    private Button btn_Submit;
    private Label lbl_GoLoginPage;
    private Guna.UI2.WinForms.Guna2DateTimePicker DTP_AccountDateOfBirth;
    private Label label11;
    private RichTextBox txt_AccountAddress;
}