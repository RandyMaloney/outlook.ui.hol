//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OutlookUI_HOL;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace OutlookUI_HOL {
    
    
    /// <summary>
    /// MySidebarControl
    /// </summary>
    public partial class MySidebarControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        internal OutlookUI_HOL.MySidebarControl mySidebarControl;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DockPanel mySidebarDockPanel;
        
        internal System.Windows.Controls.Button myNavigationPaneButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OutlookUI_HOL;component/mysidebarcontrol.xaml", System.UriKind.Relative);
            System.Windows.Application.LoadComponent(this, resourceLocater);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mySidebarControl = ((OutlookUI_HOL.MySidebarControl)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.mySidebarDockPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 4:
            this.myNavigationPaneButton = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\MySidebarControl.xaml"
            this.myNavigationPaneButton.Click += new System.Windows.RoutedEventHandler(this.myNavigationPaneButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
