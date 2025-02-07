namespace ATM_Project;
public partial class WithdrawForWalletAr:Form
{
    public WithdrawForWalletAr()
    {
        InitializeComponent();
    }

    private void label6_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private void button1_Click(object sender,EventArgs e)
    {
        FinalPage.isArabicForWallet = true;
        FinalPage finalPage = new FinalPage();
        this.Hide();
        finalPage.Show();
    }

    private void label10_Click(object sender,EventArgs e)
    {
        MainPageForWalletsAr mainPageForWalletsAr = new MainPageForWalletsAr();
        this.Hide();
        mainPageForWalletsAr.Show();
    }
}
