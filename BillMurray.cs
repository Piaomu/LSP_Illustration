using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Illustration
{
    class BillMurray : BasePlayer, IBillMurray
    {
        string[] IBillMurray.Skills { get; set; } = new string[2] { "Moral Support", "Joke-telling" };
    }
}
