using ClassLibrary1.Abstract;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Concreate
{
    public class UserRepository:BaseRepo<User>
    {
        public UserRepository():base(nameof(User))
        {
                
        }
    }
}
