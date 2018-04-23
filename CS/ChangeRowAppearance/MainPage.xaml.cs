using System;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using DevExpress.Xpf.Core.WPFCompatibility;
using DevExpress.Xpf.Grid;

namespace ChangeRowAppearance {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = new ProductList();
        }
    }

    public class ValToClrConverter : MarkupExtension, IValueConverter {

        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if ((int)value  < 10)
                return new SolidColorBrush(Colors.Red);
            if ((int)value > 100)
                return new SolidColorBrush(Colors.Green);
            return new SolidColorBrush(Colors.LightGray);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }

        #endregion
    }
}
