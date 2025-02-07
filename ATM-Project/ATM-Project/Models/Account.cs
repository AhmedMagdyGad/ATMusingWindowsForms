using System.ComponentModel.DataAnnotations;

namespace ATM_Project.Models;
internal class Account
{
    [Key]
    public string AccountNumber { get; set; } = string.Empty;
    [Required, StringLength(30)]
    public string Name { get; set; } = string.Empty;
    [Required, StringLength(30)]
    public string FamilyName { get; set; } = string.Empty;
    [Required, StringLength(100)]
    public string Address { get; set; } = string.Empty;
    [Required, StringLength(11), RegularExpression(@"^01\d{9}$")]
    public string Phone { get; set; } = string.Empty;
    [StringLength(30)]
    public string Education { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public int Balance { get; set; }
    public int WalletBalance { get; set; }
    public int PINCode { get; set; }
    public int WrongTrails { get; set; }
    public bool isLocked { get; set; }
}
