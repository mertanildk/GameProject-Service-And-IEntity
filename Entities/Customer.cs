using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public class Customer:IEntity // ÖNCE VARLIKLARIMIZI BULMAMIZ GEREKİYOR... 
                                  // DAHA SONRASINDA OPERASYONLARI BULMAMIZ GEREKİYOR OPERASYON SINIFLARINI INTERFACE İLE BAŞLA
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public int DateOfBirh { get; set; }

        //public Customer(string firstName, int ıd, string lastName, string nationalityId, int dateOfBirh)
        //{
        //    FirstName = firstName;
        //    Id = ıd;
        //    LastName = lastName;
        //    NationalityId = nationalityId;        //BOŞ GİRİŞİ ENGELLEMEK İÇİN KOYULABİLİRRRR
        //    DateOfBirh = dateOfBirh;
        //}

    }
}
