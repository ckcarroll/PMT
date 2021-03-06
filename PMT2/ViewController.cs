﻿using System;

using UIKit;

namespace PMT2
{
    public partial class ViewController : UIViewController
    {

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


		}

	

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton446_TouchUpInside(UIButton sender)
        {
            //UIAlertView _error = new UIAlertView("My Title Text", "This is my main text", null, "Ok", null);
            //_error.Show();
            try
            {
                double loanAmount;
                double moneyDown;
                double gapIns;
                double regis;
                double title;
                double tax;
                double interest;
                double loanTerm;

                loanAmount = Convert.ToDouble(loan.Text);
                moneyDown = Convert.ToDouble(mnyDwn.Text);
                gapIns = Convert.ToDouble(gap.Text);
                regis = Convert.ToDouble(registration.Text);
                title = Convert.ToDouble(titleFee.Text);
                tax = Convert.ToDouble(stateTax.Text);
                interest = Convert.ToDouble(interestRate.Text);
                loanTerm = Convert.ToDouble(term.Text);



                suggestDown.Text = Calcs.CalcSuggestedDown((loanAmount)).ToString("###,###.##");
                estPMT.Text = Calcs.CalcPayment(loanAmount, moneyDown, gapIns, regis, title, tax, interest, loanTerm).ToString("###,###.##");
            }
            catch(Exception){
				UIAlertView _error = new UIAlertView("You done messed up A-aron!", "Something went wrong.", null, "Ok", null);
				_error.Show();

			}
           
		}

    }
}
