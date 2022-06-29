using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class CustomerManager : ICustomerService//Microservice customermanager içine dışardan bi servis gelirse customermanager microservis olur
    {
        IUserValidationService _userValidationService;

        public CustomerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Customer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " Nice to See You!!!");
            }
            else
            {
                Console.WriteLine("Geçerli kişi bulunamadı kayıt başarısız");
            }
        }

        public void Delete(Customer gamer)
        {
            
        }

        public void Update(Customer gamer)
        {
           
        }
    }
}
