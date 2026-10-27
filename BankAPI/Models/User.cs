namespace BankAPI.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }

        public ICollection<Account> Accounts{ get; set; }
    }
}
