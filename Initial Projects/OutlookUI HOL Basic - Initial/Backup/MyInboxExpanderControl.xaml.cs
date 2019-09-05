using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace OutlookUI_HOL
{
    public partial class MyInboxExpanderControl
    {
        public MyInboxExpanderControl()
        {
            this.InitializeComponent();

            // Insert code required on object creation below this point.
        }

        private void ComboBox_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ComboBox cbx = ((ComboBox)sender);

            if ((bool)e.NewValue && cbx.Text == (string)cbx.ToolTip)
            {
                cbx.Text = "";
                cbx.Foreground = Brushes.Black;
            }
            else if (cbx.Text == "")
            {
                cbx.Text = (string)cbx.ToolTip;
                cbx.Foreground = Brushes.LightGray;
            }
        }
    }
}