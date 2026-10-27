namespace BankAPI.Models
{
    public class TypeOperation
    {
        public Guid TypeOperationId { get; set; }
        public string TypeOperationName { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
