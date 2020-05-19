using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace RR_Game
{
    public class GameRR
    {
        /*defining varibles  choosebullet for choosing the bullet, totshot  is for total shot you got,
        bullet out is for 2 chances for shoot away
        */
        public int choosebullet;
        public int totshot = 6;
        public int bulletout = 2;
       
        //inscrement of the bullet placement
        public int changechamper(int trun)
        {
            {
                if (trun == 6)
                {
                    trun = 1;
                }
                else
                {
                    trun++;
                }
                return trun;
            }
        }
        public int shootaway()
        {

            int points = 0;
           
                //if the bullet is in champer and fired out your score is 10
                if (totshot > 0 && choosebullet == 1 && bulletout == 2)
                {
                    points = 10;
                }
                // if the bullet is fired in 2nd chance then your score is 5
                if (totshot > 0 && choosebullet == 1 && bulletout == 1)
                {
                    points = 5;
                }
                // if the champer not contain bullet then your score us 0
                else if (totshot > 0 && choosebullet != 1)
                {
                    points = 0;
                    totshot = totshot - 1;
                    choosebullet = changechamper(choosebullet);
                }
                bulletout--;
              
            
            return points;
        }

    }

}
