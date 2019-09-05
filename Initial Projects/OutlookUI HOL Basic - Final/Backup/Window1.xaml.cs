using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Input;
using System.Data;
using System.ComponentModel;
using System.Xml;

namespace OutlookUI_HOL
{
    public partial class Window1
    {

        public Window1()
        {
            this.InitializeComponent();
        }

        private GridLength gridLength;

        private void myMainGridToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (myMainGridFirstColumn.ActualWidth > myMainGridFirstColumn.MinWidth)
                gridLength = myMainGridFirstColumn.Width;

            myMainGridFirstColumn.Width = new GridLength(myMainGridFirstColumn.MinWidth);
            myFoldersExpandersControl.Visibility = Visibility.Hidden;
            mySidebarControl.Visibility = Visibility.Visible;
        }

        private void myMainGridToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!myMainGridFirstColumnSplitter.IsDragging)
                myMainGridFirstColumn.Width = gridLength;

            myFoldersExpandersControl.Visibility = Visibility.Visible;
            mySidebarControl.Visibility = Visibility.Hidden;
        }

        private void myMainGridFirstColumnSplitter_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            if (myMainGridFirstColumn.ActualWidth <= myMainGridFirstColumn.MinWidth)
                myMainGridToggleButton.IsChecked = true;
            else
                myMainGridToggleButton.IsChecked = false;
        }


    }

    [ValueConversion(typeof(string), typeof(string))]
    public class MyFrameSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string file = System.IO.Path.GetFullPath("..\\..\\.") + "\\resources\\" + (string)value;
            return file;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }

}