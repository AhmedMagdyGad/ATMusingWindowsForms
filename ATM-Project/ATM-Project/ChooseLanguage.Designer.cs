namespace ATM_Project;

partial class ChooseLanguage
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
        label6 = new Label();
        label1 = new Label();
        panel2 = new Panel();
        btn_ArabicLanguage = new Button();
        btn_EnglishLanguage = new Button();
        label2 = new Label();
        label5 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(  135,  30,  53);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0,0);
        panel1.Margin = new Padding(3,4,3,4);
        panel1.Name = "panel1";
        panel1.Size = new Size(685,76);
        panel1.TabIndex = 27;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label6.ForeColor = Color.White;
        label6.Location = new Point(648,1);
        label6.Name = "label6";
        label6.Size = new Size(34,35);
        label6.TabIndex = 1;
        label6.Text = "X";
        label6.Click += label6_Click;
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
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,485);
        panel2.Margin = new Padding(3,4,3,4);
        panel2.Name = "panel2";
        panel2.Size = new Size(685,20);
        panel2.TabIndex = 32;
        // 
        // btn_ArabicLanguage
        // 
        btn_ArabicLanguage.BackColor = Color.FromArgb(  135,  30,  53);
        btn_ArabicLanguage.FlatStyle = FlatStyle.Flat;
        btn_ArabicLanguage.Font = new Font("Arial",14.25F);
        btn_ArabicLanguage.ForeColor = Color.White;
        btn_ArabicLanguage.Location = new Point(212,346);
        btn_ArabicLanguage.Margin = new Padding(3,4,3,4);
        btn_ArabicLanguage.Name = "btn_ArabicLanguage";
        btn_ArabicLanguage.Size = new Size(279,47);
        btn_ArabicLanguage.TabIndex = 30;
        btn_ArabicLanguage.Text = "العربية";
        btn_ArabicLanguage.UseVisualStyleBackColor = false;
        btn_ArabicLanguage.Click += btn_ArabicLanguage_Click;
        // 
        // btn_EnglishLanguage
        // 
        btn_EnglishLanguage.BackColor = Color.FromArgb(  135,  30,  53);
        btn_EnglishLanguage.FlatStyle = FlatStyle.Flat;
        btn_EnglishLanguage.Font = new Font("Arial",14.25F);
        btn_EnglishLanguage.ForeColor = Color.White;
        btn_EnglishLanguage.Location = new Point(212,255);
        btn_EnglishLanguage.Margin = new Padding(3,4,3,4);
        btn_EnglishLanguage.Name = "btn_EnglishLanguage";
        btn_EnglishLanguage.Size = new Size(279,47);
        btn_EnglishLanguage.TabIndex = 31;
        btn_EnglishLanguage.Text = "English";
        btn_EnglishLanguage.UseVisualStyleBackColor = false;
        btn_EnglishLanguage.Click += btn_EnglishLanguage_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial",25.8000011F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label2.ForeColor = Color.FromArgb(  135,  30,  53);
        label2.Location = new Point(288,141);
        label2.Name = "label2";
        label2.Size = new Size(104,51);
        label2.TabIndex = 28;
        label2.Text = "مرحبا";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(  135,  30,  53);
        label5.Location = new Point(256,98);
        label5.Name = "label5";
        label5.Size = new Size(172,35);
        label5.TabIndex = 29;
        label5.Text = "WELCOME";
        // 
        // ChooseLanguage
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(685,505);
        Controls.Add(panel1);
        Controls.Add(panel2);
        Controls.Add(btn_ArabicLanguage);
        Controls.Add(btn_EnglishLanguage);
        Controls.Add(label2);
        Controls.Add(label5);
        FormBorderStyle = FormBorderStyle.None;
        Name = "ChooseLanguage";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ChooseLanguage";
        Load += ChooseLanguage_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label label6;
    private Label label1;
    private Panel panel2;
    private Button btn_ArabicLanguage;
    private Button btn_EnglishLanguage;
    private Label label2;
    private Label label5;
}