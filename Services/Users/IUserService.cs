namespace IS_lab8.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IS_lab8.Entities;
using IS_lab8.Model;

public interface IUserService
{
    AuthenticationResponse
        Authenticate(AuthenticationRequest request);
    IEnumerable<User> GetUsers();
    User GetByUsername(string username);
    User GetById(int id);
}