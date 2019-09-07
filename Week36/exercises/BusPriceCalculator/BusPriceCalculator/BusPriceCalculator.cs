using System;

namespace BusPriceCalculator
{
    public class BusCalculator
    {
        private int InitialFee = 2500;
        public int Calculate(int kilometers)
        {
            if (kilometers > 0)
            {
                int rate = InitialFee;
                if (kilometers < 100)
                    rate += kilometers * 10;
                else if (kilometers >= 100 && kilometers <= 500)
                    rate += (99 * 10) + (kilometers - 99) * 8;
                else if (kilometers > 500)
                    rate += (99 * 10) + (401 * 8) + (kilometers - 500) * 6;
                return rate;
            } else
            {
                return 0;
            }
        }
    }
}
