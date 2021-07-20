using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Illustration
{
    class BasePlayer : IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }  
        public decimal Salary { get; set; }
        public virtual void ShouldHePlay(int fouls, int minutesPlayed)
        {
            if(minutesPlayed > 40)
            {
                Console.WriteLine("Take me out, coach");
            }
            
            else if(fouls > 5)
            {
                Console.WriteLine("I fouled out, coach");
            }

            else if(minutesPlayed < 20 && fouls > 3)
            {
                Console.WriteLine("I played too hard, coach");
            }
            else
            {
                Console.WriteLine("Put me in, coach!");
            }
        }
    }
}
