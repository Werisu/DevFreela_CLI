using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserDetailViewModel
    {
        public UserDetailViewModel(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}
