namespace GameLibrary.Core.Requests;

interface ILoginRequest
{
    /// <summary>
    /// Profile login / username
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// Profile's password
    /// </summary>
    public string Password { get; set; }
}

public class LoginRequest : ILoginRequest
{
    /// <inheritdoc/>
    public string UserName { get; set; }

    /// <inheritdoc/>
    public string Password { get; set; }
}
