using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.DirectoryServices.AccountManagement;

public struct Credentials
{
    public string Username;
    public string Password;
}

public class LoginManager
{
    public Credentials Credentials;

    public LoginManager(string Username, string Password)
    {
        Credentials.Username = Username;
        Credentials.Password = Password;
    }

    public bool IsValid
    {
        get
        {
            using (PrincipalContext pc = new PrincipalContext(ContextType.Machine))
            {
                // validate the credentials
                return pc.ValidateCredentials(Credentials.Username, Credentials.Password);
            }
        }
    }
}
