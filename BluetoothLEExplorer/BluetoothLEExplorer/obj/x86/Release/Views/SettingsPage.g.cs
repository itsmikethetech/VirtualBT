﻿#pragma checksum "C:\Users\alisa\Documents\GitHub\VirtualBT\BluetoothLEExplorer\BluetoothLEExplorer\Views\SettingsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A91FED87ABBA6C0A6E4BBCCEA019DC91153AC065E1B75940CB122B3D142C9093"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BluetoothLEExplorer.Views
{
    partial class SettingsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Template10_Controls_PageHeader_Frame(global::Template10.Controls.PageHeader obj, global::Windows.UI.Xaml.Controls.Frame value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Controls.Frame) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Controls.Frame), targetNullValue);
                }
                obj.Frame = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SettingsPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISettingsPage_Bindings
        {
            private global::BluetoothLEExplorer.Views.SettingsPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Template10.Controls.PageHeader obj7;

            public SettingsPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // Views\SettingsPage.xaml line 50
                        this.obj7 = (global::Template10.Controls.PageHeader)target;
                        break;
                    default:
                        break;
                }
            }

            // ISettingsPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::BluetoothLEExplorer.Views.SettingsPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BluetoothLEExplorer.Views.SettingsPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Frame(obj.Frame, phase);
                    }
                }
            }
            private void Update_Frame(global::Windows.UI.Xaml.Controls.Frame obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\SettingsPage.xaml line 50
                    XamlBindingSetters.Set_Template10_Controls_PageHeader_Frame(this.obj7, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\SettingsPage.xaml line 14
                {
                    this.ViewModel = (global::BluetoothLEExplorer.ViewModels.SettingsPageViewModel)(target);
                }
                break;
            case 3: // Views\SettingsPage.xaml line 21
                {
                    this.AdaptiveVisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4: // Views\SettingsPage.xaml line 22
                {
                    this.VisualStateNarrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5: // Views\SettingsPage.xaml line 30
                {
                    this.VisualStateNormal = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6: // Views\SettingsPage.xaml line 38
                {
                    this.VisualStateWide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7: // Views\SettingsPage.xaml line 50
                {
                    this.pageHeader = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 8: // Views\SettingsPage.xaml line 57
                {
                    this.MyPivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 9: // Views\SettingsPage.xaml line 109
                {
                    this.LogoImage = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 10: // Views\SettingsPage.xaml line 121
                {
                    this.DisplayNameTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Views\SettingsPage.xaml line 127
                {
                    this.PublisherTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\SettingsPage.xaml line 132
                {
                    this.VersionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Views\SettingsPage.xaml line 69
                {
                    this.UseShellDrawnBackButtonToggleSwtich = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 14: // Views\SettingsPage.xaml line 77
                {
                    this.UseLightThemeToggleSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 15: // Views\SettingsPage.xaml line 83
                {
                    this.UseCachingToggleSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 16: // Views\SettingsPage.xaml line 89
                {
                    this.CloseConnectionsToggleSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\SettingsPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SettingsPage_obj1_Bindings bindings = new SettingsPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

