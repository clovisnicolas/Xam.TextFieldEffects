using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UIKit;

namespace Xam.TextFieldEffects.Sample
{
	public static class Colors
	{
		public static UIColor Orange => Get(0xF39C12);

		public static UIColor Blue => Get(0x3498DB);

		public static UIColor Yellow => Get(0xF1C40F);

		public static UIColor Green => Get(0x2ECC71);

		public static UIColor Purple => Get(0x9B59B6);

		public static UIColor Red => Get(0xE74C3C);

		public static UIColor DarkBlue => Get(0x34495E);

		public static UIColor Black => Get(0x000000);

		public static UIColor DarkGray => Get(0x666666);

		public static UIColor NearDarkGray => Get(0x999999);

		public static UIColor SemiDarkGray => Get(0xCCCCCC);

		public static UIColor Gray => Get(0xDDDDDD);

		public static UIColor SemiLightGray => Get(0xEEEEEE);

		public static UIColor NearLightGray => Get(0xF6F6F6);

		public static UIColor LightGray => Get(0xFAFAFA);

		public static UIColor White => Get(0xFFFFFF);

		private static Dictionary<string, UIColor> colors = new Dictionary<string, UIColor>();

		private static UIColor Get(uint value, [CallerMemberName] string name = null)
		{
			UIColor result;
			if (colors.TryGetValue(name, out result)) return result;

			var r = ((nfloat)((value & 0xFF00000) >> 16)) / 255.0f;
			var g = ((nfloat)((value & 0x00FF00) >> 8)) / 255.0f;
			var b = ((nfloat)(value & 0x0000FF)) / 255.0f;
			result = UIColor.FromRGB(r, g, b);
			colors[name] = result;
			return result;
		}

	}
}
