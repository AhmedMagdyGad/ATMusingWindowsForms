namespace ATM_Project.Models;
internal class Transaction
{
    public int TransactionID { get; set; }
    public string TransactionType { get; set; } = string.Empty;
    public int TransactionAmount { get; set; }
    public DateTime TransactionDate { get; set; } = DateTime.Now;
    public string Phone { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
}
