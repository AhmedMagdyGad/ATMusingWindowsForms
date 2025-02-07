using ATM_Project.Helper;
using ATM_Project.Models;

namespace ATM_Project;
public partial class WithdrawAr:Form
{
    ApplicationDbContext _context;
    public WithdrawAr()
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

    private void WithdrawAr_Load(object sender,EventArgs e)
    {
        txt_Amount.Select();
        var account = _context.Accounts
            .Where(a => a.AccountNumber == Login.AccountNumber)
            .FirstOrDefault();
        lbl_BalanceViewer.Text = $"رصيدك : {account!.Balance} ج.م";
    }

    private void txt_Amount_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }

    private void btn_Withdraw_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(txt_Amount.Text))
        {
            MessageBoxes.MissingData();
            return;
        }
        var account = _context.Accounts
            .Where(a => a.AccountNumber == Login.AccountNumber)
            .FirstOrDefault();
        if(account!.Balance < int.Parse(txt_Amount.Text))
        {
            MessageBoxes.BalanceCanNotBeNegative();
            return;
        }
        account!.Balance -= int.Parse(txt_Amount.Text);
        Transaction transaction = new()
        {
            AccountNumber = Login.AccountNumber,
            TransactionAmount = int.Parse(txt_Amount.Text),
            TransactionType = TransactionTypes.Withdraw.ToString(),
            Phone = account.Phone,
        };
        _context.Transactions.Add(transaction);
        _context.SaveChanges();
        FinalPage finalPage = new FinalPage();
        FinalPage.isArabic = true;
        this.Hide();
        finalPage.Show();
    }
}
