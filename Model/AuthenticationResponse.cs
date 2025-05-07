namespace IS_lab8.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IS_lab8.Entities;

public class AuthenticationResponse
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Token { get; set; }
    
    public AuthenticationResponse(User user, string
        token)
    {
        Id = user.Id;
        Username = user.Username;
        Token = token;
    }

}