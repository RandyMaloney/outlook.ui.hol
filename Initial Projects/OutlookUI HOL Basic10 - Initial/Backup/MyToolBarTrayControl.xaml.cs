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

namespace OutlookUI_HOL
{
    public partial class MyToolBarTrayControl
    {
        public MyToolBarTrayControl()
        {
            this.InitializeComponent();
            contextMenuClosedHandler = new RoutedEventHandler(ContextMenu_Closed);
        }

        /** 
         * Event handlers for MyImageTextMenuButton controls.
         */
        private RoutedEventHandler contextMenuClosedHandler;
        private Border buttonBorder;
        private void triangleButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                buttonBorder = ((Grid)((Control)sender).Parent).Parent as Border;
                if (buttonBorder != null)
                {
                    buttonBorder.ContextMenu.PlacementTarget = buttonBorder;
                    buttonBorder.ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
                    ContextMenuService.SetPlacement(buttonBorder, System.Windows.Controls.Primitives.PlacementMode.Bottom);
                    buttonBorder.ContextMenu.IsOpen = true;
                    buttonBorder.Background = (Brush)MyApp.Current.Resources["MyBlueGradientBrush"];
                    buttonBorder.BorderBrush = (Brush)MyApp.Current.Resources["MyDarkBlueSolidBrush"];
                    buttonBorder.ContextMenu.Closed += contextMenuClosedHandler;
                }
            }
        }

        private void ContextMenu_Closed(object sender, RoutedEventArgs e)
        {
            buttonBorder.ClearValue(Border.BackgroundProperty);
            buttonBorder.ClearValue(Border.BorderBrushProperty);
            buttonBorder.ContextMenu.Closed -= contextMenuClosedHandler;
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

    public class MyImageTextMenuButton : Button
    {
        public ImageSource MyButtonImageSource
        {
            get { return base.GetValue(MyButtonImageSourceProperty) as ImageSource; }
            set { base.SetValue(MyButtonImageSourceProperty, value); }
        }

        public String MyButtonText
        {
            get { return base.GetValue(MyButtonTextProperty) as String; }
            set { base.SetValue(MyButtonTextProperty, value); }
        }
        public static readonly DependencyProperty MyButtonImageSourceProperty = DependencyProperty.Register("MyButtonImageSource", typeof(ImageSource), typeof(MyImageTextMenuButton));

        public static readonly DependencyProperty MyButtonTextProperty = DependencyProperty.Register("MyButtonText", typeof(String), typeof(MyImageTextMenuButton));
    }

    public class MyImageTextButton : Button
    {
        public ImageSource MySource
        {
            get { return base.GetValue(MySourceProperty) as ImageSource; }
            set { base.SetValue(MySourceProperty, value); }
        }

        public String MyText
        {
            get { return base.GetValue(MyTextProperty) as String; }
            set { base.SetValue(MyTextProperty, value); }
        }
        public static readonly DependencyProperty MySourceProperty = DependencyProperty.Register("MySource", typeof(ImageSource), typeof(MyImageTextButton));

        public static readonly DependencyProperty MyTextProperty = DependencyProperty.Register("MyText", typeof(String), typeof(MyImageTextButton));
    }
}