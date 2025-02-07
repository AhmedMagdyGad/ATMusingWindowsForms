namespace ATM_Project;

partial class MainPageForWalletsAr
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
        label3.Font = new Font("Arial",18F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label3.ForeColor = Color.FromArgb(  135,  30,  53);
        label3.Location = new Point(259,314);
        label3.Name = "label3";
        label3.Size = new Size(61,27);
        label3.TabIndex = 17;
        label3.Text = "خروج";
        label3.Click += label3_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,364);
        panel2.Name = "panel2";
        panel2.Size = new Size(599,15);
        panel2.TabIndex = 16;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(  135,  30,  53);
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Arial",14.25F);
        button2.ForeColor = Color.White;
        button2.Location = new Point(326,176);
        button2.Name = "button2";
        button2.Size = new Size(238,35);
        button2.TabIndex = 14;
        button2.Text = "سحب";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(  135,  30,  53);
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Arial",14.25F);
        button1.ForeColor = Color.White;
        button1.Location = new Point(30,176);
        button1.Name = "button1";
        button1.Size = new Size(231,35);
        button1.TabIndex = 15;
        button1.Text = "ايداع";
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
        panel1.Name = "panel1";
        panel1.Size = new Size(599,63);
        panel1.TabIndex = 13;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label2.ForeColor = Color.White;
        label2.Location = new Point(564,1);
        label2.Name = "label2";
        label2.Size = new Size(34,33);
        label2.TabIndex = 2;
        label2.Text = "X";
        label2.Click += label2_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(172,15);
        label1.Name = "label1";
        label1.Size = new Size(227,33);
        label1.TabIndex = 2;
        label1.Text = "من فضللك اختر العملية";
        // 
        // MainPageForWalletsAr
        // 
        AutoScaleDimensions = new SizeF(7F,15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(599,379);
        Controls.Add(label3);
        Controls.Add(panel2);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3,2,3,2);
        Name = "MainPageForWalletsAr";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "MainPageForWalletsAr";
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