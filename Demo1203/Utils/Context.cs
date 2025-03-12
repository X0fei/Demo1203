using Demo1203.Context;
using Demo1203.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1203.Utils
{
    public static class Context
    {
        public static User18Context DbContext { get; set; } = new();
        public static List<User> users = [.. DbContext.Users.Include(user => user.RoleNavigation)];
    }
}
