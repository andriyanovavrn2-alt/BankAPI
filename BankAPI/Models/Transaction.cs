namespace BankAPI.Models
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        public decimal Sum { get; set; }
        public Guid TypeOperationId { get; set; }
        public TypeOperation TypeOperation { get; set; }
        public DateTime Time { get; set; }

    }
}
