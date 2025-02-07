namespace ATM_Project;

partial class DepositForWalletAr
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
        label6 = new Label();
        label1 = new Label();
        label5 = new Label();
        label10 = new Label();
        button1 = new Button();
        textBox1 = new TextBox();
        label3 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,364);
        panel2.Name = "panel2";
        panel2.Size = new Size(599,15);
        panel2.TabIndex = 31;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(  135,  30,  53);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0,0);
        panel1.Name = "panel1";
        panel1.Size = new Size(599,57);
        panel1.TabIndex = 30;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label6.ForeColor = Color.White;
        label6.Location = new Point(567,1);
        label6.Name = "label6";
        label6.Size = new Size(27,27);
        label6.TabIndex = 1;
        label6.Text = "X";
        label6.Click += label6_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(243,8);
        label1.Name = "label1";
        label1.Size = new Size(113,33);
        label1.TabIndex = 1;
        label1.Text = "ITI ATM";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial",19.8000011F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(  135,  30,  53);
        label5.Location = new Point(268,74);
        label5.Name = "label5";
        label5.Size = new Size(57,32);
        label5.TabIndex = 36;
        label5.Text = "ايداع";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label10.ForeColor = Color.FromArgb(  135,  30,  53);
        label10.Location = new Point(200,287);
        label10.Name = "label10";
        label10.Size = new Size(60,27);
        label10.TabIndex = 35;
        label10.Text = "رجوع";
        label10.Click += label10_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(  135,  30,  53);
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Arial",14.25F);
        button1.ForeColor = Color.White;
        button1.Location = new Point(150,240);
        button1.Name = "button1";
        button1.Size = new Size(157,35);
        button1.TabIndex = 34;
        button1.Text = "ايداع";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Arial",14.25F);
        textBox1.Location = new Point(112,177);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(230,29);
        textBox1.TabIndex = 33;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial",18F);
        label3.ForeColor = Color.FromArgb(  135,  30,  53);
        label3.Location = new Point(407,177);
        label3.Name = "label3";
        label3.Size = new Size(53,27);
        label3.TabIndex = 32;
        label3.Text = "المبلغ";
        // 
        // DepositForWalletAr
        // 
        AutoScaleDimensions = new SizeF(7F,15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(599,379);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(label5);
        Controls.Add(label10);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(label3);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3,2,3,2);
        Name = "DepositForWalletAr";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "DepositForWalletAr";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel2;
    private Panel panel1;
    private Label label6;
    private Label label1;
    private Label label5;
    private Label label10;
    private Button button1;
    private TextBox textBox1;
    private Label label3;
}