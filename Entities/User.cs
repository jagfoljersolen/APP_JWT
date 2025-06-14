namespace IS_lab8.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class User
{
    public int Id { get; set; }
    public string? Username { get; set; }
    [JsonIgnore]
    public string? Password { get; set; }

    public List<Role>? Roles;
}