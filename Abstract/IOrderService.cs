﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface IOrderService
    {
        void Sell(Customer customer, Game game, Campaign campaign);
    }
}
