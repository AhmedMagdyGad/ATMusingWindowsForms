namespace ATM_Project;
public partial class MainPage:Form
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void btn_Deposit_Click(object sender,EventArgs e)
    {
        Deposit deposit = new Deposit();
        this.Hide();
        deposit.Show();
    }

    private void btn_Withdraw_Click(object sender,EventArgs e)
    {
        Withdraw withdraw = new Withdraw();
        this.Hide();
        withdraw.Show();
    }

    private void btn_FastCash_Click(object sender,EventArgs e)
    {
        FastCash fastCash = new FastCash();
        this.Hide();
        fastCash.Show();
    }

    private void btn_LastTransaction_Click(object sender,EventArgs e)
    {
        LastTransactions lastTransactions = new LastTransactions();
        this.Hide();
        lastTransactions.Show();
    }

    private void btn_ChangePIN_Click(object sender,EventArgs e)
    {
        ChangePIN changePIN = new ChangePIN();
        this.Hide();
        changePIN.Show();
    }

    private void btn_Balance_Click(object sender,EventArgs e)
    {
        Balance balance = new Balance();
        this.Hide();
        balance.Show();
    }

    private void lbl_Logout_Click(object sender,EventArgs e)
    {
        Login login = new Login();
        this.Hide();
        login.Show();
    }

    private void lbl_CloseApplication_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }
}
