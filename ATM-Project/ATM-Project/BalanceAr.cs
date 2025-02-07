using ATM_Project.Models;

namespace ATM_Project;
public partial class BalanceAr:Form
{
    ApplicationDbContext _context;
    public BalanceAr()
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

    private void BalanceAr_Load(object sender,EventArgs e)
    {
        var account = _context.Accounts
            .Where(a => a.AccountNumber == Login.AccountNumber)
            .FirstOrDefault();
        lbl_AccountNumber.Text = Login.AccountNumber;
        lbl_AccountBalance.Text = $"{account!.Balance} ج.م";
    }
}
