namespace IS_lab8.Model;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

public class AuthenticationRequest
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}