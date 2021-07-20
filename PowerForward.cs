using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Illustration
{
    class PowerForward : Player
    {
        public override void Substitution(Player teammate)
        {
            if (teammate is PowerForward)
            {
                Console.WriteLine($"You're in for {teammate}");
            }
            else
            {
                Console.WriteLine($"{teammate} is not a Power Forward");
            }
        }
    }
}
