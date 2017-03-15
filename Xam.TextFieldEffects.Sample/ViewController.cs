using System;

using UIKit;

namespace Xam.TextFieldEffects.Sample
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


			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
			AkiraTextField akiraTextField = new AkiraTextField();
			akiraTextField.Placeholder = "Akira";
			akiraTextField.TextColor = Colors.DarkBlue;
			akiraTextField.BorderColor = Colors.Blue;
			akiraTextField.Frame = akiraView.Bounds;
			this.akiraView.AddSubview(akiraTextField);

			HoshiTextField hoshiTextField = new HoshiTextField();
			hoshiTextField.Placeholder = "Hoshi";
			hoshiTextField.PlaceholderColor = Colors.DarkGray;
			hoshiTextField.TextColor = Colors.DarkGray;
			hoshiTextField.BorderActiveColor = Colors.Green;
			hoshiTextField.BorderInactiveColor = Colors.DarkGray;
			hoshiTextField.Frame = hoshiView.Bounds;
			this.hoshiView.AddSubview(hoshiTextField);

			KaedeTextField kaedeTextField = new KaedeTextField();
			kaedeTextField.Placeholder = "Kaede";
			kaedeTextField.PlaceholderColor = Colors.DarkGray;
			kaedeTextField.TextColor = Colors.DarkGray;
			kaedeTextField.Frame = KaedeView.Bounds;
			this.KaedeView.AddSubview(kaedeTextField);

			YoshikoTextField yoshikoTextField = new YoshikoTextField();
			yoshikoTextField.Placeholder = "Yoshiko";
			yoshikoTextField.PlaceholderColor = Colors.DarkGray;
			yoshikoTextField.ActiveBorderColor = Colors.Orange;
			yoshikoTextField.InactiveBorderColor = Colors.NearLightGray;
			yoshikoTextField.TextColor = Colors.Orange;
			yoshikoTextField.Frame = YoshikoView.Bounds;
			this.YoshikoView.AddSubview(yoshikoTextField);

			MinoruTextField minoruTextField = new MinoruTextField();
			minoruTextField.Placeholder = "Minoru";
			minoruTextField.BackgroundColor = Colors.NearLightGray;
			minoruTextField.PlaceholderColor = Colors.DarkGray;
			minoruTextField.TextColor = Colors.Green;
			minoruTextField.Frame = minoruView.Bounds;
			this.minoruView.AddSubview(minoruTextField);

			JiroTextField jiroTextField = new JiroTextField();
			jiroTextField.Placeholder = "Jiro";
			jiroTextField.BorderColor = Colors.Gray;
			jiroTextField.TextColor = Colors.Black;
			jiroTextField.PlaceholderColor = Colors.Red;
			jiroTextField.Frame = JiroView.Bounds;
			this.JiroView.AddSubview(jiroTextField);

			MadokaTextField madokaTextField = new MadokaTextField();
			madokaTextField.Placeholder = "Madoka";
			madokaTextField.BorderColor = Colors.Blue;
			madokaTextField.TextColor = Colors.Black;
			madokaTextField.PlaceholderColor = Colors.DarkGray;
			madokaTextField.Frame = MadokaView.Bounds;
			this.MadokaView.AddSubview(madokaTextField);

			IsaoTextField isaoTextField = new IsaoTextField();
			isaoTextField.Placeholder = "Isao";
			isaoTextField.ActiveColor = Colors.Purple;
			isaoTextField.InactiveColor = Colors.Gray;
			isaoTextField.Frame = IsaoView.Bounds;
			this.IsaoView.AddSubview(isaoTextField);


		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
