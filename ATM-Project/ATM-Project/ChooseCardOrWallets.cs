namespace ATM_Project;
public partial class ChooseCardOrWallets:Form
{
    public ChooseCardOrWallets()
    {
        InitializeComponent();
    }

    private void ChooseCardOrWallets_Load(object sender,EventArgs e)
    {
        btn_WithoutCard.Text = "خدمات بدون بطاقة\nWithout Card";
        btn_WithCard.Text = "بطاقة\nWith Card";
    }

    private void lbl_CloseApplication_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private void btn_WithCard_Click(object sender,EventArgs e)
    {
        Login login = new Login();
        this.Hide();
        login.Show();
    }

    private void btn_WithoutCard_Click(object sender,EventArgs e)
    {
        LoginWithoutCards loginWithout = new LoginWithoutCards();
        this.Hide();
        loginWithout.Show();
    }
}
