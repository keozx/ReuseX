using System;
using System.Globalization;
using System.Windows;
#if WINDOWS_PHONE
using System.Windows.Data;

#else
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml;
#endif

namespace Reuse.Common.Converters {
	/// <summary>
	/// Converts a bool to Visibility and viceversa, add a parameter to inverse the result.
	/// </summary>
	public class BooleanToVisibilityConverter : IValueConverter {
				
		#if WINDOWS_PHONE
		public object Convert( object value, Type targetType, object parameter, CultureInfo culture ) {
			var boolValue = System.Convert.ToBoolean( value );

			if ( parameter != null )
				boolValue = !boolValue;

			return boolValue ? Visibility.Visible : Visibility.Collapsed;
		}

		public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture ) {
			return value.Equals( Visibility.Visible );
		}
		#else
		public object Convert( object value, Type targetType, object parameter, string language ) {
			var boolValue = System.Convert.ToBoolean( value );

			if ( parameter != null )
				boolValue = !boolValue;

			return boolValue ? Visibility.Visible : Visibility.Collapsed;
		}

		public object ConvertBack( object value, Type targetType, object parameter, string language ) {
			return value.Equals( Visibility.Visible );
		}
		#endif
	}
}
