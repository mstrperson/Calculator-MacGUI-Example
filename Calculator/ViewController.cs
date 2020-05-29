using System;

using AppKit;
using Foundation;

namespace Calculator
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public double answer
        {
            get;
            protected set;
        }

        // The first number entered (set by pressing an operation key)
        public double leftOperand
        {
            get;
            protected set;
        }
        public double? rightOperand
        {
            get;
            protected set;
        }

        public Operation doThis
        {
            get;
            protected set;
        }

        public enum Operation
        {
            Plus,
            Minus,
            Times,
            Divide
        }


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
            leftOperand = Convert.ToDouble(OutputScreen.StringValue);
            doThis = Operation.Plus;
            OutputScreen.StringValue = "";
        }
        partial void MinusClick(NSObject sender)
        {
            leftOperand = Convert.ToDouble(OutputScreen.StringValue);
            doThis = Operation.Minus;
            OutputScreen.StringValue = "";
        }
        partial void TimesClick(NSObject sender)
        {
            leftOperand = Convert.ToDouble(OutputScreen.StringValue);
            doThis = Operation.Times;
            OutputScreen.StringValue = "";
        }
        partial void DivideClick(NSObject sender)
        {
            leftOperand = Convert.ToDouble(OutputScreen.StringValue);
            doThis = Operation.Divide;
            OutputScreen.StringValue = "";
        }

        partial void EqualsClick(NSObject sender)
        {
            if (!rightOperand.HasValue)
            {
                rightOperand = Convert.ToDouble(OutputScreen.StringValue);
            }

            //double answer;
            switch(doThis)
            {
                case Operation.Plus:
                    answer = leftOperand + rightOperand.Value;
                    break;
                case Operation.Minus:
                    answer = leftOperand - rightOperand.Value;
                    break;
                case Operation.Times:
                    answer = leftOperand * rightOperand.Value;
                    break;
                case Operation.Divide:
                    answer = leftOperand / rightOperand.Value;
                    break;
                default: answer = 0; break;
            }
            leftOperand = answer;
            OutputScreen.StringValue = string.Format("{0}", answer);
        }

        partial void ClearClick(NSObject sender)
        {
            answer = default;
            leftOperand = default;
            rightOperand = null;
            OutputScreen.StringValue = "";
        }
    }
}
