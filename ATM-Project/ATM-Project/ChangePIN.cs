using ATM_Project.Helper;
using ATM_Project.Models;

namespace ATM_Project;
public partial class ChangePIN:Form
{
    ApplicationDbContext _context;
    public ChangePIN()
    {
        InitializeComponent();
        _context = new ApplicationDbContext();
    }

    private void lbl_CloseApplication_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private void lbl_BackHome_Click(object sender,EventArgs e)
    {
        MainPage mainPage = new MainPage();
        this.Hide();
        mainPage.Show();
    }

    private void ChangePIN_Load(object sender,EventArgs e)
    {
        txt_NewPIN.Select();
    }

    private void btn_ChangePIN_Click(object sender,EventArgs e)
    {
        var account = _context.Accounts
            .Where(a => a.AccountNumber == Login.AccountNumber)
            .FirstOrDefault();
        if(string.IsNullOrWhiteSpace(txt_NewPIN.Text)
        || string.IsNullOrWhiteSpace(txt_ConfirmPIN.Text))
        {
            MessageBoxes.MissingData();
            return;
        }
        account!.PINCode = int.Parse(txt_NewPIN.Text);
        _context.SaveChanges();
        Login login = new Login();
        this.Hide();
        login.Show();
    }

    private void txt_NewPIN_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }

    private void txt_ConfirmPIN_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }

    private void txt_NewPIN_Leave(object sender,EventArgs e)
    {
        var account = _context.Accounts
            .Where(a => a.AccountNumber == Login.AccountNumber)
            .FirstOrDefault();
        int value;
        int.TryParse(txt_NewPIN.Text,out value);
        if(account!.PINCode == value)
        {
            MessageBox.Show(
                "The New PIN cannot be same as old!!",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txt_NewPIN.Text = string.Empty;
            txt_NewPIN.Select();
            return;
        }
    }

    private void txt_ConfirmPIN_Leave(object sender,EventArgs e)
    {
        if(txt_NewPIN.Text != txt_ConfirmPIN.Text)
        {
            MessageBox.Show(
                "The PINs are not matched!!",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txt_ConfirmPIN.Text = string.Empty;
            txt_ConfirmPIN.Select();
            return;
        }
    }
}
