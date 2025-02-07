using ATM_Project.Helper;
using ATM_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ATM_Project;
public partial class Login:Form
{
    ApplicationDbContext _context;
    public static string AccountNumber;
    public Login()
    {
        InitializeComponent();
        _context = new ApplicationDbContext();
    }

    private void Login_Load(object sender,EventArgs e)
    {
        txt_AccountNumber.Select();
        txt_AccountNumber.TabIndex = 0;
        txt_AccountPINCode.TabIndex = 1;
        btn_Login.TabIndex = 2;
        lbl_SignIn.TabIndex = 3;
    }

    private void lbl_SignIn_Click(object sender,EventArgs e)
    {
        Account account = new Account();
        this.Hide();
        account.Show();
    }

    private void lbl_CloseApplication_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private async void btn_Login_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrEmpty(txt_AccountNumber.Text) || string.IsNullOrEmpty(txt_AccountPINCode.Text))
        {
            MessageBoxes.MissingData();
            return;
        }
        var account = await _context.Accounts
                                    .Where(a => a.AccountNumber == txt_AccountNumber.Text)
                                    .FirstOrDefaultAsync();

        if(account == null)
        {
            MessageBoxes.InvalidCredentials();
            return;
        }
        if(account.isLocked)
        {
            LockedScreen lockedScreen = new LockedScreen();
            this.Hide();
            lockedScreen.Show();
            return;
        }

        if(account.PINCode.ToString() != txt_AccountPINCode.Text)
        {
            account.WrongTrails++;
            if(account.WrongTrails >= 3)
            {
                account.WrongTrails = 0;
                account.isLocked = true;
                await _context.SaveChangesAsync();
                MessageBoxes.InvalidCredentials();
                return;
            }
            await _context.SaveChangesAsync();
            MessageBoxes.InvalidCredentials();
            return;
        }

        AccountNumber = txt_AccountNumber.Text;
        ChooseLanguage chooseLanguage = new ChooseLanguage();
        this.Hide();
        chooseLanguage.Show();
        return;
    }

    private void txt_AccountNumber_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }

    private void txt_AccountPINCode_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }
}
