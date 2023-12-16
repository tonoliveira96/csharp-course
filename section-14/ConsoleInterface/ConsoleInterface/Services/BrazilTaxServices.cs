﻿namespace ConsoleInterface.Services
{
    class BrazilTaxServices: ITaxService
    {

        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.20;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
