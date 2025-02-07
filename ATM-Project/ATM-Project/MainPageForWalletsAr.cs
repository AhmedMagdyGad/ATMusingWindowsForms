namespace ATM_Project;
public partial class MainPageForWalletsAr:Form
{
    public MainPageForWalletsAr()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender,EventArgs e)
    {
        WithdrawForWalletAr withdrawForWalletAr = new WithdrawForWalletAr();
        this.Hide();
        withdrawForWalletAr.Show();
    }

    private void button1_Click(object sender,EventArgs e)
    {
        DepositForWalletAr depositForWalletAr = new DepositForWalletAr();
        this.Hide();
        depositForWalletAr.Show();
    }

    private void label3_Click(object sender,EventArgs e)
    {
        LoginWithoutCards loginWithoutCards = new LoginWithoutCards();
        this.Hide();
        loginWithoutCards.Show();
    }

    private void label2_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }
}
