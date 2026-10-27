namespace BankAPI.Models
{
    public class Account
    {
        public Guid AccountId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
