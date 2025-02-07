namespace ATM_Project;

partial class FinalPage
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
        components = new System.ComponentModel.Container();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        label5 = new Label();
        timer1 = new System.Windows.Forms.Timer(components);
        MyProgressBar = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
        panel2 = new Panel();
        panel1 = new Panel();
        label1 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(  135,  30,  53);
        label5.Location = new Point(39,106);
        label5.Name = "label5";
        label5.Size = new Size(580,29);
        label5.TabIndex = 28;
        label5.Text = "Please wait while your transaction is proccessing";
        // 
        // timer1
        // 
        timer1.Tick += timer1_Tick;
        // 
        // MyProgressBar
        // 
        MyProgressBar.AnimationSpeed = 80;
        MyProgressBar.CircleSize = 2F;
        MyProgressBar.Location = new Point(263,155);
        MyProgressBar.Margin = new Padding(3,2,3,2);
        MyProgressBar.Name = "MyProgressBar";
        MyProgressBar.NumberOfCircles = 13;
        MyProgressBar.ProgressColor = Color.FromArgb(  135,  30,  53);
        MyProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges1;
        MyProgressBar.Size = new Size(236,152);
        MyProgressBar.TabIndex = 29;
        MyProgressBar.Click += MyProgressBar_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,364);
        panel2.Name = "panel2";
        panel2.Size = new Size(664,15);
        panel2.TabIndex = 31;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(  135,  30,  53);
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0,0);
        panel1.Name = "panel1";
        panel1.Size = new Size(664,57);
        panel1.TabIndex = 30;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(285,7);
        label1.Name = "label1";
        label1.Size = new Size(113,33);
        label1.TabIndex = 1;
        label1.Text = "ITI ATM";
        // 
        // FinalPage
        // 
        AutoScaleDimensions = new SizeF(7F,15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(664,379);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(MyProgressBar);
        Controls.Add(label5);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3,2,3,2);
        Name = "FinalPage";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FinalPage";
        Load += FinalPage_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label5;
    private System.Windows.Forms.Timer timer1;
    private Guna.UI2.WinForms.Guna2WinProgressIndicator MyProgressBar;
    private Panel panel2;
    private Panel panel1;
    private Label label1;
}