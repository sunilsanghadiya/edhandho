namespace edhandho.Entities
{
    public class Users
    {
        public int Id { get; set;}
        public string FirstName { get; set;} = string.Empty;
        public string? MiddleName { get; set;}
        public string LastName { get; set;} = string.Empty;
        public DateTime DateOfBirth {get; set;}
        public int Gender {get; set;}
        public string Email {get; set;}
        public string PasswordHash {get; set;}
        public bool IsAdmin {get; set;}
        public bool IsActive {get; set;}
        public bool IsVerified {get; set;}
        public DateTime Created {get; set;}
    }
}