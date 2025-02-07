using ATM_Project.Models;

namespace ATM_Project;
public partial class Balance:Form
{
    ApplicationDbContext _context;
    public Balance()
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

    private void Balance_Load(object sender,EventArgs e)
    {
        var account = _context.Accounts
            .Where(a => a.AccountNumber == Login.AccountNumber)
            .FirstOrDefault();
        lbl_AccountNumber.Text = Login.AccountNumber;
        lbl_AccountBalance.Text = $"{account!.Balance} E£";
    }
}
