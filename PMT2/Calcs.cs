using System;
namespace PMT2
{
    public class Calcs
    {
		public static double CalcPayment(double price, double moneyDown,
										 double gap, double registration,
										 double title, double tax,
										 double interest, double term)
		{
			double discountFactor;
			double periodInterest;
			double nper;
			double loan;
			double payment;
			double taxConvert;
			double interestConvert;

			interestConvert = interest / 100;
			periodInterest = interestConvert / 12;
			nper = term * 12;

			taxConvert = tax / 100;
			loan = (((price - moneyDown) + (gap + registration + title)) * (1 + taxConvert));
			discountFactor = (Math.Pow(1 + periodInterest, nper) - 1) / (periodInterest *
																		 Math.Pow(1 + periodInterest, nper));

			payment = loan / discountFactor;

			return payment;

		}

		public static double CalcSuggestedDown(double loan)
		{
            //20% is the suggested amount to put down on a car loan
            //Home loans to be added later.
			double sugDown = loan * .3;

			return sugDown;
		}
    }
}
