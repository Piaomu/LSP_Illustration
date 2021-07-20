using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Illustration
{
    class BillMurray : Player
    {
        public override void Substitution(Player teammate)
        {
            throw new InvalidOperationException("Bill Murray? Really?");
        }
    }
}
