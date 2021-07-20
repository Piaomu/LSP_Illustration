using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Illustration
{
    interface IPlayer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set;  }

        void ShouldHePlay(int fouls, int minutesPlayed);
    }
}
