using System;
namespace Core.Services
{

    public interface ICalculationService
    {
        double TipAmount(double subTotal, int generosity);
    }

    public class CalculatorService : ICalculationService
    {
        public double TipAmount(double subTotal, int generosity)
        {
            return subTotal * ((double)generosity) / 100.0;
        }
    }
}

