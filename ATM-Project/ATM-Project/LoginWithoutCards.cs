using ATM_Project.Helper;
using System.Text.RegularExpressions;

namespace ATM_Project;
public partial class LoginWithoutCards:Form
{
    public static bool withoutCard = false;
    public LoginWithoutCards()
    {
        InitializeComponent();
    }

    private void lbl_CloseApplication_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private void btn_Login_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(txt_AccountNumber.Text))
        {
            MessageBoxes.MissingData();
            return;
        }
        string phonePattern = @"^01\d{9}$";
        if(!Regex.IsMatch(txt_AccountNumber.Text,phonePattern))
        {
            MessageBox.Show(
                "Please enter a valid phone number starting with 01 and followed by 9 digits.",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }
        withoutCard = true;
        ChooseLanguage chooseLanguage = new ChooseLanguage();
        this.Hide();
        chooseLanguage.Show();
    }

    private void txt_AccountNumber_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }

    private void txt_AccountNumber_Leave(object sender,EventArgs e)
    {

    }
}
