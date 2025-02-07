namespace ATM_Project;
public partial class FinalPage:Form
{
    public FinalPage()
    {
        InitializeComponent();
    }
    private int delayCounter = 0;
    public static bool isArabic = false;
    public static bool isArabicForWallet = false;
    private void timer1_Tick(object sender,EventArgs e)
    {
        delayCounter++;
        if(delayCounter >= 3)
        {
            timer1.Stop();
            MyProgressBar.Stop();
            if(isArabic)
            {
                isArabic = false;
                MainPageAr mainPageAr = new MainPageAr();
                this.Hide();
                mainPageAr.Show();
                return;
            }
            if(LoginWithoutCards.withoutCard)
            {
                LoginWithoutCards.withoutCard = false;
                LoginWithoutCards loginWithoutCards = new LoginWithoutCards();
                this.Hide();
                loginWithoutCards.Show();
                return;
            }
            if(isArabicForWallet)
            {
                isArabicForWallet = false;
                LoginWithoutCards loginWithoutCards = new LoginWithoutCards();
                this.Hide();
                loginWithoutCards.Show();
                return;
            }
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }
    }

    private void FinalPage_Load(object sender,EventArgs e)
    {
        MyProgressBar.Start();
        timer1.Interval = 1000;
        timer1.Start();
    }

    private void MyProgressBar_Click(object sender,EventArgs e)
    {

    }
}
