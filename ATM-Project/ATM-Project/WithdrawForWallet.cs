using ATM_Project.Helper;

namespace ATM_Project;
public partial class WithdrawForWallet:Form
{
    public WithdrawForWallet()
    {
        InitializeComponent();
    }

    private void lbl_CloseApplication_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private void lbl_BackHome_Click(object sender,EventArgs e)
    {
        MainPageForWallets mainPageForWallets = new MainPageForWallets();
        this.Hide();
        mainPageForWallets.Show();
    }

    private void txt_Withdraw_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }

    private void btn_Withdraw_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrEmpty(txt_Withdraw.Text))
        {
            MessageBoxes.MissingData();
            return;
        }
        FinalPage finalPage = new FinalPage();
        LoginWithoutCards.withoutCard = true;
        this.Hide();
        finalPage.Show();
    }
}
