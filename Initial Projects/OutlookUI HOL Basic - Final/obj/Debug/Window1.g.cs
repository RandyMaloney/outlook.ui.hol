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
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        internal OutlookUI_HOL.Window1 Window;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ColumnDefinition myMainGridFirstColumn;
        
        internal System.Windows.Controls.GridSplitter myMainGridFirstColumnSplitter;
        
        internal System.Windows.Controls.StackPanel StackPanel;
        
        internal OutlookUI_HOL.MyFoldersExpandersControl myFoldersExpandersControl;
        
        internal System.Windows.Controls.DockPanel dp1;
        
        internal System.Windows.Controls.Primitives.ToggleButton myMainGridToggleButton;
        
        internal OutlookUI_HOL.MySidebarControl mySidebarControl;
        
        internal System.Windows.Controls.DockPanel dp2;
        
        internal System.Windows.Controls.DockPanel dp3;
        
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
            System.Uri resourceLocater = new System.Uri("/OutlookUI_HOL;component/window1.xaml", System.UriKind.Relative);
            System.Windows.Application.LoadComponent(this, resourceLocater);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Window = ((OutlookUI_HOL.Window1)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.myMainGridFirstColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 4:
            this.myMainGridFirstColumnSplitter = ((System.Windows.Controls.GridSplitter)(target));
            
            #line 35 "..\..\Window1.xaml"
            this.myMainGridFirstColumnSplitter.DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.myMainGridFirstColumnSplitter_DragDelta);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.myFoldersExpandersControl = ((OutlookUI_HOL.MyFoldersExpandersControl)(target));
            return;
            case 7:
            this.dp1 = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 8:
            this.myMainGridToggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 79 "..\..\Window1.xaml"
            this.myMainGridToggleButton.Checked += new System.Windows.RoutedEventHandler(this.myMainGridToggleButton_Checked);
            
            #line default
            #line hidden
            
            #line 79 "..\..\Window1.xaml"
            this.myMainGridToggleButton.Unchecked += new System.Windows.RoutedEventHandler(this.myMainGridToggleButton_Unchecked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.mySidebarControl = ((OutlookUI_HOL.MySidebarControl)(target));
            return;
            case 10:
            this.dp2 = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 11:
            this.dp3 = ((System.Windows.Controls.DockPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
