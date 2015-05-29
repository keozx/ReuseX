using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#if WINDOWS_PHONE
using System.Windows.Data;
#else
using Windows.UI.Xaml.Data;
#endif

namespace Reuse.Common.Converters {
	public class LowerToUpperConverter : IValueConverter {
		#if WINDOWS_PHONE
		public object Convert( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture ) {
			if ( parameter == null ) {
				return ( value as string ).ToUpper();
			}
			return ( value as string ).ToLower();
		}
		
		public object ConvertBack( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture ) {
			throw new NotImplementedException();
		}
		#else

		object IValueConverter.Convert( object value, Type targetType, object parameter, string language ) {
			if ( parameter == null ) {
				return ( value as string ).ToUpper();
			}
			return ( value as string ).ToLower();
		}

		object IValueConverter.ConvertBack( object value, Type targetType, object parameter, string language ) {
			throw new NotImplementedException();
		}
		#endif
	}
}
