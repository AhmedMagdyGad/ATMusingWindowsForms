using ATM_Project.Helper;

namespace ATM_Project;
public partial class DepositForWalletAr:Form
{
    public DepositForWalletAr()
    {
        InitializeComponent();
    }

    private void label6_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private void button1_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(textBox1.Text))
        {
            MessageBoxes.MissingData();
            return;
        }
        FinalPage finalPage = new FinalPage();
        FinalPage.isArabicForWallet = true;
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
