namespace ATM_Project;

partial class LastTransactions
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        lbl_BackHome = new Label();
        panel2 = new Panel();
        panel1 = new Panel();
        lbl_CloseApplication = new Label();
        label1 = new Label();
        label5 = new Label();
        dgv_LastTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) dgv_LastTransactions).BeginInit();
        SuspendLayout();
        // 
        // lbl_BackHome
        // 
        lbl_BackHome.AutoSize = true;
        lbl_BackHome.Font = new Font("Arial",16.2F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_BackHome.ForeColor = Color.FromArgb(  135,  30,  53);
        lbl_BackHome.Location = new Point(385,572);
        lbl_BackHome.Name = "lbl_BackHome";
        lbl_BackHome.Size = new Size(91,32);
        lbl_BackHome.TabIndex = 17;
        lbl_BackHome.Text = "BACK";
        lbl_BackHome.Click += lbl_BackHome_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(  135,  30,  53);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0,623);
        panel2.Margin = new Padding(3,4,3,4);
        panel2.Name = "panel2";
        panel2.Size = new Size(873,20);
        panel2.TabIndex = 16;
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
        panel1.Size = new Size(873,93);
        panel1.TabIndex = 15;
        // 
        // lbl_CloseApplication
        // 
        lbl_CloseApplication.AutoSize = true;
        lbl_CloseApplication.Font = new Font("Arial",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_CloseApplication.ForeColor = Color.White;
        lbl_CloseApplication.Location = new Point(830,1);
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
        label1.Location = new Point(360,19);
        label1.Name = "label1";
        label1.Size = new Size(143,42);
        label1.TabIndex = 2;
        label1.Text = "ITI ATM";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label5.ForeColor = Color.FromArgb(  135,  30,  53);
        label5.Location = new Point(288,112);
        label5.Name = "label5";
        label5.Size = new Size(337,35);
        label5.TabIndex = 29;
        label5.Text = "LAST TRANSACTIONS";
        // 
        // dgv_LastTransactions
        // 
        dgv_LastTransactions.AllowUserToAddRows = false;
        dgv_LastTransactions.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        dgv_LastTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(  135,  30,  53);
        dataGridViewCellStyle2.Font = new Font("Arial Narrow",12F,FontStyle.Bold,GraphicsUnit.Point, 0);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(  135,  30,  53);
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgv_LastTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgv_LastTransactions.ColumnHeadersHeight = 30;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI",9F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(  71,  69,  94);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(  231,  229,  255);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(  71,  69,  94);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgv_LastTransactions.DefaultCellStyle = dataGridViewCellStyle3;
        dgv_LastTransactions.GridColor = Color.FromArgb(  231,  229,  255);
        dgv_LastTransactions.Location = new Point(0,177);
        dgv_LastTransactions.Name = "dgv_LastTransactions";
        dgv_LastTransactions.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle4.BackColor = SystemColors.Control;
        dataGridViewCellStyle4.Font = new Font("Segoe UI",9F);
        dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
        dgv_LastTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgv_LastTransactions.RowHeadersVisible = false;
        dgv_LastTransactions.RowHeadersWidth = 51;
        dgv_LastTransactions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv_LastTransactions.RowsDefaultCellStyle = dataGridViewCellStyle5;
        dgv_LastTransactions.Size = new Size(873,373);
        dgv_LastTransactions.TabIndex = 30;
        dgv_LastTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        dgv_LastTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
        dgv_LastTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        dgv_LastTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        dgv_LastTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        dgv_LastTransactions.ThemeStyle.BackColor = Color.White;
        dgv_LastTransactions.ThemeStyle.GridColor = Color.FromArgb(  231,  229,  255);
        dgv_LastTransactions.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(  135,  30,  53);
        dgv_LastTransactions.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
        dgv_LastTransactions.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI",9F);
        dgv_LastTransactions.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        dgv_LastTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgv_LastTransactions.ThemeStyle.HeaderStyle.Height = 30;
        dgv_LastTransactions.ThemeStyle.ReadOnly = true;
        dgv_LastTransactions.ThemeStyle.RowsStyle.BackColor = Color.White;
        dgv_LastTransactions.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgv_LastTransactions.ThemeStyle.RowsStyle.Font = new Font("Segoe UI",9F);
        dgv_LastTransactions.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(  71,  69,  94);
        dgv_LastTransactions.ThemeStyle.RowsStyle.Height = 29;
        dgv_LastTransactions.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(  231,  229,  255);
        dgv_LastTransactions.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(  71,  69,  94);
        // 
        // LastTransactions
        // 
        AutoScaleDimensions = new SizeF(8F,20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(873,643);
        Controls.Add(dgv_LastTransactions);
        Controls.Add(label5);
        Controls.Add(lbl_BackHome);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3,4,3,4);
        Name = "LastTransactions";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LastTransactions";
        Load += LastTransactions_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) dgv_LastTransactions).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl_BackHome;
    private Panel panel2;
    private Panel panel1;
    private Label lbl_CloseApplication;
    private Label label1;
    private Label label5;
    private Guna.UI2.WinForms.Guna2DataGridView dgv_LastTransactions;
}