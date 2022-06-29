using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer musteri1 = new Customer();
            musteri1.Id = 1;
            musteri1.FirstName = "Enes";
            musteri1.LastName = "Kırış";
            musteri1.DateOfBirh = 1998;
            musteri1.NationalityId = "123562311";
            CustomerManager customerManager = new CustomerManager(new UserValidationManager());
            customerManager.Add(musteri1);
            
            Game gTa5 = new Game();
            gTa5.GameName = "gta5";
            gTa5.Id = 1;
            gTa5.GamePrice = 100;
            GameManager gameManager = new GameManager();
            gameManager.Add(gTa5);



            Campaign yazKampanyasi = new Campaign();
            yazKampanyasi.Id = 1;
            yazKampanyasi.IndirimOrani = 10;
            yazKampanyasi.Name = "yaz kampanyasi";
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(yazKampanyasi);


            OrderManager orderManager = new OrderManager();
            orderManager.Sell(musteri1, gTa5, yazKampanyasi);
            //    CustomerManager customerManager = new CustomerManager(new UserValidationManager());
            //    customerManager.Add(new Customer
            //    {
            //        Id = 1,
            //        FirstName = "Mert",
            //        LastName="Anıl",
            //        NationalityId="234112333"

            //    });

            //    GameManager gameManager = new
            //    CampaignManager campaignManager = new CampaignManager();
            //    campaignManager.Add(new Campaign { Id = 1, IndirimOrani = 10,Name="indirimcik" }) ;
            //    OrderManager orderManager = new OrderManager();
            //    //orderManager.Sell(customerManager,);
            //}
        }
    }
}