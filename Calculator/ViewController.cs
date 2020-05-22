using System;
using System.Collections.Generic;
using AppKit;
using Foundation;

namespace Calculator
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
            operands = new List<double>();
        }

        List<double> operands;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void DecimalClick(NSObject sender)
        {
            if(!OutputScreen.StringValue.Contains("."))
                OutputScreen.StringValue += ".";
        }

        partial void OneClick(NSObject sender)
        {
            OutputScreen.StringValue += "1";
        }
        partial void TwoClick(NSObject sender)
        {
            OutputScreen.StringValue += "2";
        }
        partial void ThreeClick(NSObject sender)
        {
            OutputScreen.StringValue += "3";
        }
        partial void FourClick(NSObject sender)
        {
            OutputScreen.StringValue += "4";
        }
        partial void FiveClick(NSObject sender)
        {
            OutputScreen.StringValue += "5";
        }
        partial void SixClick(NSObject sender)
        {
            OutputScreen.StringValue += "6";
        }
        partial void SevenClick(NSObject sender)
        {
            OutputScreen.StringValue += "7";
        }
        partial void EightClick(NSObject sender)
        {
            OutputScreen.StringValue += "8";
        }
        partial void NineClick(NSObject sender)
        {
            OutputScreen.StringValue += "9";
        }
        partial void ZeroClick(NSObject sender)
        {
            OutputScreen.StringValue += "0";
        }

        partial void PlusClick(NSObject sender)
        {
            double ans = 0;
            foreach(double op in operands)
            {
                ans += op;
            }

            operands.Clear();

            OutputScreen.StringValue = Convert.ToString(ans);
        }
        partial void MinusClick(NSObject sender)
        {
            if(operands.Count > 1)
            {
                double ans = operands[0];
                for(int i = 1; i < operands.Count; i++)
                {
                    ans -= operands[i];
                }
                OutputScreen.StringValue = Convert.ToString(ans);

                operands.Clear();
            }
            else
            {
                double ans = 0;
                foreach(double op in operands)
                {
                    ans -= op;
                }
                OutputScreen.StringValue = Convert.ToString(ans);
                operands.Clear();
            }
        }
        partial void TimesClick(NSObject sender)
        {
            if (operands.Count > 0)
            {
                double ans = 1;
                foreach (double op in operands)
                {
                    ans *= op;
                }
                operands.Clear();

                OutputScreen.StringValue = Convert.ToString(ans);
            }
        }
        partial void DivideClick(NSObject sender)
        {
            if (operands.Count > 1)
            {
                double ans = operands[0];
                for (int i = 1; i < operands.Count; i++)
                {
                    ans /= operands[i];
                }
                operands.Clear();

                OutputScreen.StringValue = Convert.ToString(ans);
            }
        }

        // This is the ENT key...
        partial void EqualsClick(NSObject sender)
        {
            operands.Add(Convert.ToDouble(OutputScreen.StringValue));
            OutputScreen.StringValue = "";
        }
    }
}
