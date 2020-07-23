using PracticeLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seller
{
    public class Seller
    {
        private int moneyEarrend;

        public void SellNewspaper(Newspaper newspaper)
        {
            this.moneyEarrend = Convert.ToInt32(this.moneyEarrend + newspaper.GetPrice());
            Console.WriteLine($"Money Earned: {this.moneyEarrend}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Money earned: {this.moneyEarrend}";
        }
    }
}
