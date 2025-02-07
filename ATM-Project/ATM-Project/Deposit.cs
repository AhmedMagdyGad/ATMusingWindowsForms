using ATM_Project.Helper;
using ATM_Project.Models;

namespace ATM_Project;
public partial class Deposit:Form
{
    ApplicationDbContext _context;
    public Deposit()
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

    private void btn_Deposit_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(txt_Amount.Text))
        {
            MessageBoxes.MissingData();
            return;
        }
        var account = _context.Accounts
            .Where(a => a.AccountNumber == Login.AccountNumber)
            .FirstOrDefault();
        account!.Balance += int.Parse(txt_Amount.Text);
        Transaction transaction = new()
        {
            AccountNumber = Login.AccountNumber,
            TransactionAmount = int.Parse(txt_Amount.Text),
            TransactionType = TransactionTypes.Deposite.ToString(),
            Phone = account.Phone,
        };
        _context.Transactions.Add(transaction);
        _context.SaveChanges();
        MainPage mainPage = new MainPage();
        this.Hide();
        mainPage.Show();
    }

    private void txt_Amount_KeyPress(object sender,KeyPressEventArgs e)
    {
        if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        {
            e.Handled = true;
        }
    }

    private void Deposit_Load(object sender,EventArgs e)
    {

    }
}
