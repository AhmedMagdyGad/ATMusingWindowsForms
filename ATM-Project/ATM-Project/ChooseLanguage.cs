namespace ATM_Project;
public partial class ChooseLanguage:Form
{
    public ChooseLanguage()
    {
        InitializeComponent();
    }

    private void ChooseLanguage_Load(object sender,EventArgs e)
    {

    }

    private void btn_EnglishLanguage_Click(object sender,EventArgs e)
    {
        if(LoginWithoutCards.withoutCard)
        {
            LoginWithoutCards.withoutCard = false;
            MainPageForWallets mainPageForWallets = new MainPageForWallets();
            this.Hide();
            mainPageForWallets.Show();
            return;
        }
        MainPage mainPage = new MainPage();
        this.Hide();
        mainPage.Show();
    }

    private void btn_ArabicLanguage_Click(object sender,EventArgs e)
    {
        if(LoginWithoutCards.withoutCard)
        {
            LoginWithoutCards.withoutCard = false;
            MainPageForWalletsAr mainPageForWalletsAr = new MainPageForWalletsAr();
            this.Hide();
            mainPageForWalletsAr.Show();
            return;
        }
        MainPageAr mainPage = new MainPageAr();
        this.Hide();
        mainPage.Show();
    }

    private void label6_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }
}
