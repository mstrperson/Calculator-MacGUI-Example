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

        private string answerStr;

        public double answer
        {
            get;
            protected set;
        }

        private string leftStr;

        // The first number entered (set by pressing an operation key)
        public double leftOperand
        {
            get;
            protected set;
        }

        private string rightStr;

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

        protected string Input;

        protected string Output
        {
            get
            {
                return string.Format("{0}{1}{2}\t{3}",
                    leftStr,
                    Environment.NewLine,
                    doThis == Operation.Plus ? "+" :
                       doThis == Operation.Minus ? "-" :
                         doThis == Operation.Times ? "*" :
                           doThis == Operation.Divide ? "÷" : "",
                    rightStr
                    );
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Input = leftStr;
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
            if(!Input.Contains("."))
                Input += ".";

            OutputScreen.StringValue = Output;
        }

        partial void OneClick(NSObject sender)
        {
            Input += "1";
            OutputScreen.StringValue = Output;
        }
        partial void TwoClick(NSObject sender)
        {
            Input += "2";
            OutputScreen.StringValue = Output;
        }
        partial void ThreeClick(NSObject sender)
        {
            Input += "3";
            OutputScreen.StringValue = Output;
        }
        partial void FourClick(NSObject sender)
        {
            Input += "4";
            OutputScreen.StringValue = Output;
        }
        partial void FiveClick(NSObject sender)
        {
            Input += "5";
            OutputScreen.StringValue = Output;
        }
        partial void SixClick(NSObject sender)
        {
            Input += "6";
            OutputScreen.StringValue = Output;
        }
        partial void SevenClick(NSObject sender)
        {
            Input += "7";
            OutputScreen.StringValue = Output;
        }
        partial void EightClick(NSObject sender)
        {
            Input += "8";
            OutputScreen.StringValue = Output;
        }
        partial void NineClick(NSObject sender)
        {
            Input += "9";
            OutputScreen.StringValue = Output;
        }
        partial void ZeroClick(NSObject sender)
        {
            Input += "0";
            OutputScreen.StringValue = Output;
        }

        partial void PlusClick(NSObject sender)
        {
            leftOperand = Convert.ToDouble(Input);
            doThis = Operation.Plus;
            Input = rightStr;
            OutputScreen.StringValue = Output;
        }
        partial void MinusClick(NSObject sender)
        {
            leftOperand = Convert.ToDouble(Input);
            doThis = Operation.Minus;

            Input = rightStr;
            OutputScreen.StringValue = Output;
        }
        partial void TimesClick(NSObject sender)
        {
            leftOperand = Convert.ToDouble(Input);
            doThis = Operation.Times;
            Input = rightStr;
            OutputScreen.StringValue = Output;
        }
        partial void DivideClick(NSObject sender)
        {
            leftOperand = Convert.ToDouble(Input);
            doThis = Operation.Divide;
            Input = rightStr;
            OutputScreen.StringValue = Output;
        }

        partial void EqualsClick(NSObject sender)
        {
            if (!rightOperand.HasValue)
            {
                rightOperand = Convert.ToDouble(rightStr);
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
            answerStr = string.Format("{0}", answer);

            OutputScreen.StringValue = string.Format("{0}{1}__________________________{1}{2}", Output, Environment.NewLine, answerStr);
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
