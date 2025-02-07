using ATM_Project.Helper;

namespace ATM_Project;
public partial class DepositForWallet:Form
{
    public DepositForWallet()
    {
        InitializeComponent();
    }

    private void lbl_CloseApplication_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private void lbl_GoHome_Click(object sender,EventArgs e)
    {
        MainPageForWallets mainPageForWallets = new MainPageForWallets();
        this.Hide();
        mainPageForWallets.Show();
    }

    private void btn_Deposit_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(txt_Deposit.Text))
        {
            MessageBoxes.MissingData();
            return;
        }
        FinalPage finalPage = new FinalPage();
        LoginWithoutCards.withoutCard = true;
        this.Hide();
        finalPage.Show();
    }

    private void txt_Deposit_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }
}
