using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface IUserValidationService // interfaceleri oluşturrr gereksinimlere göre 
    {
        bool Validate(Customer gamer);
    }
}
