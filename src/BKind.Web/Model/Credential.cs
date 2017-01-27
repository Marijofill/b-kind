namespace BKind.Web.Model
{
    public class Credential : Entity
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
<<<<<<< HEAD
=======
        public string Salt { get; set; }
>>>>>>> refs/remotes/hudo/work
        public bool IsActive { get; set; }
    }
}