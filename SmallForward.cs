using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Illustration
{
    class SmallForward : BasePlayer, IPlayer
    {
        public string[] Skills { get; set; } = new string[3] { "shooting", "dribbling", "blocking" };
    }
}
