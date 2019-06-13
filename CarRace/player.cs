using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrace
{
    class player
    {
        public int amt;
        public int car_racer;
        public cars bet_money;

      
        public string BetStatus()
        {
            if(amt > 0) return bet_money.Bettername + "place bets " + amt + " $ on car no" + car_racer;
            return bet_money.Bettername + " not placed a bet";
        }
        public player(cars bet_race)
        {
            bet_money = bet_race;
        }
        public int Winner(int win)
        {
            if (car_racer == win)
                return amt;
            return -amt;
        }
    }
}
