using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" başarıyla eklendi");
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.GameName + "silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " başarıyla güncellendi");
        }
    }
}
