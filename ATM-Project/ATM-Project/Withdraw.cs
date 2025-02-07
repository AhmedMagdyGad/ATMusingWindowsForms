using ATM_Project.Helper;
using ATM_Project.Models;

namespace ATM_Project;
public partial class Withdraw:Form
{
    ApplicationDbContext _context;
    public Withdraw()
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
        MainPage mainPage = new MainPage();
        this.Hide();
        mainPage.Show();
    }

    private void Withdraw_Load(object sender,EventArgs e)
    {
        txt_Withdraw.Select();
        var account = _context.Accounts
            .Where(a => a.AccountNumber == Login.AccountNumber)
            .FirstOrDefault();
        lbl_BalanceViewer.Text = $"Balance : {account!.Balance} E£";
    }

    private void txt_Withdraw_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }

    private void btn_Withdraw_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(txt_Withdraw.Text))
        {
            MessageBoxes.MissingData();
            return;
        }
        var account = _context.Accounts
            .Where(a => a.AccountNumber == Login.AccountNumber)
            .FirstOrDefault();
        if(account!.Balance < int.Parse(txt_Withdraw.Text))
        {
            MessageBoxes.BalanceCanNotBeNegative();
            return;
        }
        account!.Balance -= int.Parse(txt_Withdraw.Text);
        Transaction transaction = new()
        {
            AccountNumber = Login.AccountNumber,
            TransactionAmount = int.Parse(txt_Withdraw.Text),
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
