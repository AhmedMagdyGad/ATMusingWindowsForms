using ATM_Project.Helper;
using ATM_Project.Models;
using System.Text.RegularExpressions;

namespace ATM_Project;
public partial class Account:Form
{
    ApplicationDbContext _context;
    public Account()
    {
        InitializeComponent();
        _context = new ApplicationDbContext();
    }

    private void lbl_GoLoginPage_Click(object sender,EventArgs e)
    {
        Login login = new Login();
        this.Hide();
        login.Show();
    }

    private void lbl_CloseApplication_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private void btn_Submit_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(txt_AccountNumber.Text)
        || string.IsNullOrWhiteSpace(txt_AccountName.Text)
        || string.IsNullOrWhiteSpace(txt_AccountFName.Text)
        || string.IsNullOrWhiteSpace(txt_AccountAddress.Text)
        || string.IsNullOrWhiteSpace(txt_AccountPhone.Text)
        || string.IsNullOrWhiteSpace(txt_AccountPIN.Text)
        || string.IsNullOrWhiteSpace(cb_AccountEducation.Text))
        {
            MessageBoxes.MissingData();
        }
        else if(_context.Accounts.Any(A => A.AccountNumber == txt_AccountNumber.Text))
        {
            MessageBox.Show(
                "Account number is already exists",
                "Done",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        else
        {
            Models.Account account = new()
            {
                AccountNumber = txt_AccountNumber.Text,
                Name = txt_AccountName.Text,
                FamilyName = txt_AccountFName.Text,
                Address = txt_AccountAddress.Text,
                Phone = txt_AccountPhone.Text,
                BirthDate = DTP_AccountDateOfBirth.Value.Date,
                Education = cb_AccountEducation.SelectedItem!.ToString()!,
                PINCode = int.Parse(txt_AccountPIN.Text),
                Balance = 0,
                WalletBalance = 0
            };
            _context.Accounts.Add(account);
            _context.SaveChanges();
            MessageBox.Show(
                "Account has been created successfully",
                "Done",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }

    private void Account_Load(object sender,EventArgs e)
    {
        txt_AccountNumber.Select();
        txt_AccountNumber.TabIndex = 0;
        txt_AccountName.TabIndex = 1;
        txt_AccountFName.TabIndex = 2;
        txt_AccountAddress.TabIndex = 3;
        txt_AccountPIN.TabIndex = 4;
        txt_AccountPhone.TabIndex = 5;
        cb_AccountEducation.TabIndex = 6;
        DTP_AccountDateOfBirth.TabIndex = 7;
        btn_Submit.TabIndex = 8;
    }

    private void txt_AccountNumber_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }

    private void txt_AccountPIN_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }

    private void txt_AccountPhone_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }

    private void txt_AccountPhone_Leave(object sender,EventArgs e)
    {
        string phonePattern = @"^01\d{9}$";
        if(!Regex.IsMatch(txt_AccountPhone.Text,phonePattern))
        {
            MessageBox.Show(
                "Please enter a valid phone number starting with 01 and followed by 9 digits.",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txt_AccountPhone.Focus();
        }
    }
}
