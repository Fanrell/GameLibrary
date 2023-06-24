namespace GameLibrary.Domain;

public class Profile
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public string Email { get; set; }

}
