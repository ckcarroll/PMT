// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace PMT2
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel estPMT { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField gap { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField interestRate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField loan { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView LoanPMT { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField mnyDwn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField registration { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView Scroll { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField stateTax { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel suggestDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField term { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField titleFee { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel warningMessage { get; set; }

        [Action ("UIButton446_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton446_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (estPMT != null) {
                estPMT.Dispose ();
                estPMT = null;
            }

            if (gap != null) {
                gap.Dispose ();
                gap = null;
            }

            if (interestRate != null) {
                interestRate.Dispose ();
                interestRate = null;
            }

            if (loan != null) {
                loan.Dispose ();
                loan = null;
            }

            if (LoanPMT != null) {
                LoanPMT.Dispose ();
                LoanPMT = null;
            }

            if (mnyDwn != null) {
                mnyDwn.Dispose ();
                mnyDwn = null;
            }

            if (registration != null) {
                registration.Dispose ();
                registration = null;
            }

            if (Scroll != null) {
                Scroll.Dispose ();
                Scroll = null;
            }

            if (stateTax != null) {
                stateTax.Dispose ();
                stateTax = null;
            }

            if (suggestDown != null) {
                suggestDown.Dispose ();
                suggestDown = null;
            }

            if (term != null) {
                term.Dispose ();
                term = null;
            }

            if (titleFee != null) {
                titleFee.Dispose ();
                titleFee = null;
            }

            if (warningMessage != null) {
                warningMessage.Dispose ();
                warningMessage = null;
            }
        }
    }
}