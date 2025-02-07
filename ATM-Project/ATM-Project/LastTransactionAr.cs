using ATM_Project.Helper;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ATM_Project;
public partial class LastTransactionAr:Form
{
    SqlConnection con;
    public LastTransactionAr()
    {
        InitializeComponent();
        con = new SqlConnection("Server=DESKTOP-0GT95GR\\SQLEXPRESS;Database=ATM;Integrated Security=True;Trust Server Certificate = true;");
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

    private void LastTransactionAr_Load(object sender,EventArgs e)
    {
        dgv_LastTransactions.DataSource =
            con.Query<TransactionDataGridView>("select AccountNumber, TransactionType, TransactionAmount, TransactionDate, Phone from transactions where AccountNumber = @accNum order by TransactionDate desc",new { accNum = Login.AccountNumber });
    }
}
