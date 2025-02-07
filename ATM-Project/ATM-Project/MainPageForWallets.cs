namespace ATM_Project;
public partial class MainPageForWallets:Form
{
    public MainPageForWallets()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private void label3_Click(object sender,EventArgs e)
    {
        LoginWithoutCards loginWithoutCards = new LoginWithoutCards();
        this.Hide();
        loginWithoutCards.Show();
    }

    private void button1_Click(object sender,EventArgs e)
    {
        DepositForWallet depositForWallet = new DepositForWallet();
        this.Hide();
        depositForWallet.Show();
    }

    private void button2_Click(object sender,EventArgs e)
    {
        WithdrawForWallet withdrawForWallet = new WithdrawForWallet();
        this.Hide();
        withdrawForWallet.Show();
    }
}
