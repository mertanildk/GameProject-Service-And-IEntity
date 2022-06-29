using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class OrderManager : IOrderService
    {
        public void Sell(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine(customer.FirstName+" "+customer.LastName+" "+game.GameName+" oyununu "+campaign.Name+" ile %"+campaign.IndirimOrani+" indirimle aldınız....");
            Console.WriteLine("ürünün fiyatı "+game.GamePrice);
            Console.WriteLine("ürünün indirimli fiyatı: "+(game.GamePrice-((double)game.GamePrice*campaign.IndirimOrani)/100));
        }
    }
}

