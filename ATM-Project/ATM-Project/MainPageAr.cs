namespace ATM_Project;
public partial class MainPageAr:Form
{
    public MainPageAr()
    {
        InitializeComponent();
    }

    private void lbl_CloseApplication_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private void btn_Deposit_Click(object sender,EventArgs e)
    {
        DepositAr depositAr = new DepositAr();
        this.Hide();
        depositAr.Show();
    }

    private void btn_Withdraw_Click(object sender,EventArgs e)
    {
        WithdrawAr withdrawAr = new WithdrawAr();
        this.Hide();
        withdrawAr.Show();
    }

    private void btn_FastCash_Click(object sender,EventArgs e)
    {
        FastCashAr fastCashAr = new FastCashAr();
        this.Hide();
        fastCashAr.Show();
    }

    private void btn_LastTransactions_Click(object sender,EventArgs e)
    {
        LastTransactionAr lastTransactionAr = new LastTransactionAr();
        this.Hide();
        lastTransactionAr.Show();
    }

    private void btn_ChangePIN_Click(object sender,EventArgs e)
    {
        ChangePINAr changePINAr = new ChangePINAr();
        this.Hide();
        changePINAr.Show();
    }

    private void btn_Balance_Click(object sender,EventArgs e)
    {
        BalanceAr balanceAr = new BalanceAr();
        this.Hide();
        balanceAr.Show();
    }

    private void lbl_Logout_Click(object sender,EventArgs e)
    {
        Login login = new Login();
        this.Hide();
        login.Show();
    }
}
