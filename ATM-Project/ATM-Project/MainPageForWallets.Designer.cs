namespace ATM_Project;

partial class MainPageForWallets
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
        label3 = new Label();
        panel2 = new Panel();
        button2 = new Button();
        button1 = new Button();
        panel1 = new Panel();
        label2 = new Label();
        label1 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial",12F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label3.ForeColor = Color.FromArgb(  135,  30,  53);
        label3.Location = new Point(286,418);
        label3.Name = "label3";
        label3.Size = new Size(94,23);
        label3.TabIndex = 12;
        label3.Text = "LOGOUT";
        label3.Click += label3_Click;
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
        // button2
        // 
        button2.BackColor = Color.FromArgb(  135,  30,  53);
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Arial",14.25F);
        button2.ForeColor = Color.White;
        button2.Location = new Point(378,234);
        button2.Margin = new Padding(3,4,3,4);
        button2.Name = "button2";
        button2.Size = new Size(272,47);
        button2.TabIndex = 9;
        button2.Text = "WITHDRAW";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(  135,  30,  53);
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Arial",14.25F);
        button1.ForeColor = Color.White;
        button1.Location = new Point(40,234);
        button1.Margin = new Padding(3,4,3,4);
        button1.Name = "button1";
        button1.Size = new Size(264,47);
        button1.TabIndex = 10;
        button1.Text = "DEPOSIT";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(  135,  30,  53);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0,0);
        panel1.Margin = new Padding(3,4,3,4);
        panel1.Name = "panel1";
        panel1.Size = new Size(685,84);
        panel1.TabIndex = 8;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label2.ForeColor = Color.White;
        label2.Location = new Point(644,1);
        label2.Name = "label2";
        label2.Size = new Size(43,42);
        label2.TabIndex = 2;
        label2.Text = "X";
        label2.Click += label2_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(110,18);
        label1.Name = "label1";
        label1.Size = new Size(465,42);
        label1.TabIndex = 2;
        label1.Text = "Please Select Your Process";
        // 
        // MainPageForWallets
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(685,505);
        Controls.Add(label3);
        Controls.Add(panel2);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MainPageForWallets";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "MainPageForWallets";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label3;
    private Panel panel2;
    private Button button2;
    private Button button1;
    private Panel panel1;
    private Label label2;
    private Label label1;
}