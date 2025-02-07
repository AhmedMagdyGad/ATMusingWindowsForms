using ATM_Project.Helper;
using ATM_Project.Models;

namespace ATM_Project;
public partial class FastCashAr:Form
{
    ApplicationDbContext _context;
    public FastCashAr()
    {
        InitializeComponent();
        _context = new ApplicationDbContext();
    }

    private void lbl_CloseApplication_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }

    private void lbl_BackHome_Click(object sender,EventArgs e)
    {
        MainPageAr mainPageAr = new MainPageAr();
        this.Hide();
        mainPageAr.Show();
    }

    private void btn_FastCash100_Click(object sender,EventArgs e)
    {
        excuteFastTransactions(100);
    }

    private void btn_FastCash500_Click(object sender,EventArgs e)
    {
        excuteFastTransactions(500);
    }

    private void btn_FastCash1000_Click(object sender,EventArgs e)
    {
        excuteFastTransactions(1000);
    }

    private void btn_FastCash2000_Click(object sender,EventArgs e)
    {
        excuteFastTransactions(2000);
    }

    private void btn_FastCash5000_Click(object sender,EventArgs e)
    {
        excuteFastTransactions(5000);
    }

    private void btn_FastCash10000_Click(object sender,EventArgs e)
    {
        excuteFastTransactions(10000);
    }

    private void excuteFastTransactions(int amount)
    {
        var account = _context.Accounts
            .Where(a => a.AccountNumber == Login.AccountNumber)
            .FirstOrDefault();
        if(account!.Balance < amount)
        {
            MessageBoxes.BalanceCanNotBeNegative();
            return;
        }
        account!.Balance -= amount;
        Transaction transaction = new()
        {
            AccountNumber = Login.AccountNumber,
            TransactionAmount = amount,
            TransactionType = TransactionTypes.Withdraw.ToString(),
            Phone = account.Phone,
        };
        _context.Transactions.Add(transaction);
        _context.SaveChanges();
        FinalPage finalPage = new FinalPage();
        this.Hide();
        finalPage.Show();
    }
}
