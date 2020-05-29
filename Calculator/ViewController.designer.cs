// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Calculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField OutputScreen { get; set; }

		[Action ("ClearClick:")]
		partial void ClearClick (Foundation.NSObject sender);

		[Action ("DecimalClick:")]
		partial void DecimalClick (Foundation.NSObject sender);

		[Action ("DivideClick:")]
		partial void DivideClick (Foundation.NSObject sender);

		[Action ("EightClick:")]
		partial void EightClick (Foundation.NSObject sender);

		[Action ("EqualsClick:")]
		partial void EqualsClick (Foundation.NSObject sender);

		[Action ("FiveClick:")]
		partial void FiveClick (Foundation.NSObject sender);

		[Action ("FourClick:")]
		partial void FourClick (Foundation.NSObject sender);

		[Action ("MinusClick:")]
		partial void MinusClick (Foundation.NSObject sender);

		[Action ("NineClick:")]
		partial void NineClick (Foundation.NSObject sender);

		[Action ("OneClick:")]
		partial void OneClick (Foundation.NSObject sender);

		[Action ("PlusClick:")]
		partial void PlusClick (Foundation.NSObject sender);

		[Action ("SevenClick:")]
		partial void SevenClick (Foundation.NSObject sender);

		[Action ("SixClick:")]
		partial void SixClick (Foundation.NSObject sender);

		[Action ("ThreeClick:")]
		partial void ThreeClick (Foundation.NSObject sender);

		[Action ("TimesClick:")]
		partial void TimesClick (Foundation.NSObject sender);

		[Action ("TwoClick:")]
		partial void TwoClick (Foundation.NSObject sender);

		[Action ("ZeroClick:")]
		partial void ZeroClick (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (OutputScreen != null) {
				OutputScreen.Dispose ();
				OutputScreen = null;
			}
		}
	}
}
