using System;
using System.Windows.Data;
using System.Windows.Markup;

namespace E20031 {
    public class FilterButtonvisibilityConverter : MarkupExtension, IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            string fieldName = value.ToString();
            return fieldName == "Text";
        }
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}