namespace ATM_Project.Helper;
internal class TransactionDataGridView
{
    public string AccountNumber { get; set; } = string.Empty;
    public string TransactionType { get; set; } = string.Empty;
    public int TransactionAmount { get; set; }
    public DateTime TransactionDate { get; set; }
    public string Phone { get; set; } = string.Empty;
}
