namespace ATM_Project;

partial class FastCash
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
        lbl_BackHome = new Label();
        btn_FastCash500 = new Button();
        btn_FastCash2000 = new Button();
        btn_FastCash10000 = new Button();
        btn_FastCash5000 = new Button();
        btn_FastCash1000 = new Button();
        btn_FastCash100 = new Button();
        label5 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,623);
        panel2.Margin = new Padding(3,4,3,4);
        panel2.Name = "panel2";
        panel2.Size = new Size(873,20);
        panel2.TabIndex = 8;
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
        panel1.Size = new Size(873,84);
        panel1.TabIndex = 7;
        // 
        // lbl_CloseApplication
        // 
        lbl_CloseApplication.AutoSize = true;
        lbl_CloseApplication.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_CloseApplication.ForeColor = Color.White;
        lbl_CloseApplication.Location = new Point(833,1);
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
        label1.Location = new Point(373,19);
        label1.Name = "label1";
        label1.Size = new Size(143,42);
        label1.TabIndex = 2;
        label1.Text = "ITI ATM";
        // 
        // lbl_BackHome
        // 
        lbl_BackHome.AutoSize = true;
        lbl_BackHome.Font = new Font("Arial",16.2F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_BackHome.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_BackHome.Location = new Point(400,547);
        lbl_BackHome.Name = "lbl_BackHome";
        lbl_BackHome.Size = new Size(91,32);
        lbl_BackHome.TabIndex = 14;
        lbl_BackHome.Text = "BACK";
        lbl_BackHome.Click += lbl_BackHome_Click;
        // 
        // btn_FastCash500
        // 
        btn_FastCash500.BackColor = Color.FromArgb(  135,  30,  53);
        btn_FastCash500.FlatStyle = FlatStyle.Flat;
        btn_FastCash500.Font = new Font("Arial",14.25F);
        btn_FastCash500.ForeColor = Color.White;
        btn_FastCash500.Location = new Point(536,197);
        btn_FastCash500.Margin = new Padding(3,4,3,4);
        btn_FastCash500.Name = "btn_FastCash500";
        btn_FastCash500.Size = new Size(264,47);
        btn_FastCash500.TabIndex = 8;
        btn_FastCash500.Text = "500";
        btn_FastCash500.UseVisualStyleBackColor = false;
        btn_FastCash500.Click += btn_FastCash500_Click;
        // 
        // btn_FastCash2000
        // 
        btn_FastCash2000.BackColor = Color.FromArgb(  135,  30,  53);
        btn_FastCash2000.FlatStyle = FlatStyle.Flat;
        btn_FastCash2000.Font = new Font("Arial",14.25F);
        btn_FastCash2000.ForeColor = Color.White;
        btn_FastCash2000.Location = new Point(536,321);
        btn_FastCash2000.Margin = new Padding(3,4,3,4);
        btn_FastCash2000.Name = "btn_FastCash2000";
        btn_FastCash2000.Size = new Size(264,47);
        btn_FastCash2000.TabIndex = 9;
        btn_FastCash2000.Text = "2000";
        btn_FastCash2000.UseVisualStyleBackColor = false;
        btn_FastCash2000.Click += btn_FastCash2000_Click;
        // 
        // btn_FastCash10000
        // 
        btn_FastCash10000.BackColor = Color.FromArgb(  135,  30,  53);
        btn_FastCash10000.FlatStyle = FlatStyle.Flat;
        btn_FastCash10000.Font = new Font("Arial",14.25F);
        btn_FastCash10000.ForeColor = Color.White;
        btn_FastCash10000.Location = new Point(536,448);
        btn_FastCash10000.Margin = new Padding(3,4,3,4);
        btn_FastCash10000.Name = "btn_FastCash10000";
        btn_FastCash10000.Size = new Size(264,47);
        btn_FastCash10000.TabIndex = 10;
        btn_FastCash10000.Text = "10000";
        btn_FastCash10000.UseVisualStyleBackColor = false;
        btn_FastCash10000.Click += btn_FastCash10000_Click;
        // 
        // btn_FastCash5000
        // 
        btn_FastCash5000.BackColor = Color.FromArgb(  135,  30,  53);
        btn_FastCash5000.FlatStyle = FlatStyle.Flat;
        btn_FastCash5000.Font = new Font("Arial",14.25F);
        btn_FastCash5000.ForeColor = Color.White;
        btn_FastCash5000.Location = new Point(80,448);
        btn_FastCash5000.Margin = new Padding(3,4,3,4);
        btn_FastCash5000.Name = "btn_FastCash5000";
        btn_FastCash5000.Size = new Size(264,47);
        btn_FastCash5000.TabIndex = 11;
        btn_FastCash5000.Text = "5000";
        btn_FastCash5000.UseVisualStyleBackColor = false;
        btn_FastCash5000.Click += btn_FastCash5000_Click;
        // 
        // btn_FastCash1000
        // 
        btn_FastCash1000.BackColor = Color.FromArgb(  135,  30,  53);
        btn_FastCash1000.FlatStyle = FlatStyle.Flat;
        btn_FastCash1000.Font = new Font("Arial",14.25F);
        btn_FastCash1000.ForeColor = Color.White;
        btn_FastCash1000.Location = new Point(80,321);
        btn_FastCash1000.Margin = new Padding(3,4,3,4);
        btn_FastCash1000.Name = "btn_FastCash1000";
        btn_FastCash1000.Size = new Size(264,47);
        btn_FastCash1000.TabIndex = 12;
        btn_FastCash1000.Text = "1000";
        btn_FastCash1000.UseVisualStyleBackColor = false;
        btn_FastCash1000.Click += btn_FastCash1000_Click;
        // 
        // btn_FastCash100
        // 
        btn_FastCash100.BackColor = Color.FromArgb(  135,  30,  53);
        btn_FastCash100.FlatStyle = FlatStyle.Flat;
        btn_FastCash100.Font = new Font("Arial",14.25F);
        btn_FastCash100.ForeColor = Color.White;
        btn_FastCash100.Location = new Point(80,197);
        btn_FastCash100.Margin = new Padding(3,4,3,4);
        btn_FastCash100.Name = "btn_FastCash100";
        btn_FastCash100.Size = new Size(264,47);
        btn_FastCash100.TabIndex = 13;
        btn_FastCash100.Text = "100";
        btn_FastCash100.UseVisualStyleBackColor = false;
        btn_FastCash100.Click += btn_FastCash100_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(  135,  30,  53);
        label5.Location = new Point(351,106);
        label5.Name = "label5";
        label5.Size = new Size(183,35);
        label5.TabIndex = 28;
        label5.Text = "FAST CASH";
        // 
        // FastCash
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(873,643);
        Controls.Add(label5);
        Controls.Add(lbl_BackHome);
        Controls.Add(panel2);
        Controls.Add(btn_FastCash500);
        Controls.Add(btn_FastCash2000);
        Controls.Add(panel1);
        Controls.Add(btn_FastCash10000);
        Controls.Add(btn_FastCash100);
        Controls.Add(btn_FastCash5000);
        Controls.Add(btn_FastCash1000);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3,4,3,4);
        Name = "FastCash";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FastCash";
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
    private Label lbl_BackHome;
    private Button btn_FastCash500;
    private Button btn_FastCash2000;
    private Button btn_FastCash10000;
    private Button btn_FastCash5000;
    private Button btn_FastCash1000;
    private Button btn_FastCash100;
    private Label label5;
}