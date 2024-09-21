﻿#pragma checksum "E:\GitHub\VirtualBT\BluetoothLEExplorer\BluetoothLEExplorer\Views\Services\BatteryServicePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "11672F065F61A32541DC6063C0413F7C83915CD7731F7D5605E410AD8933224F"
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
    partial class BatteryServicePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Template10_Controls_PageHeader_Text(global::Template10.Controls.PageHeader obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_BluetoothLEExplorer_CustomControls_GattLocalCharacteristicControl_Characteristic(global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl obj, global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel), targetNullValue);
                }
                obj.Characteristic = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(global::Windows.UI.Xaml.Controls.ToggleSwitch obj, global::System.Boolean value)
            {
                obj.IsOn = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class BatteryServicePage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IBatteryServicePage_Bindings
        {
            private global::BluetoothLEExplorer.Views.BatteryServicePage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Template10.Controls.PageHeader obj8;
            private global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl obj9;
            private global::Windows.UI.Xaml.Controls.ToggleSwitch obj10;
            private global::Windows.UI.Xaml.Controls.ToggleSwitch obj11;
            private global::Windows.UI.Xaml.Controls.ToggleSwitch obj12;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj13;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj14;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj15;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj13Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj14Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj15Click;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8TextDisabled = false;
            private static bool isobj9CharacteristicDisabled = false;
            private static bool isobj10IsOnDisabled = false;
            private static bool isobj11IsOnDisabled = false;
            private static bool isobj12IsOnDisabled = false;

            private BatteryServicePage_obj1_BindingsTracking bindingsTracking;

            public BatteryServicePage_obj1_Bindings()
            {
                this.bindingsTracking = new BatteryServicePage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 92 && columnNumber == 69)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 113 && columnNumber == 60)
                {
                    isobj9CharacteristicDisabled = true;
                }
                else if (lineNumber == 106 && columnNumber == 31)
                {
                    isobj10IsOnDisabled = true;
                }
                else if (lineNumber == 108 && columnNumber == 31)
                {
                    isobj11IsOnDisabled = true;
                }
                else if (lineNumber == 110 && columnNumber == 31)
                {
                    isobj12IsOnDisabled = true;
                }
                else if (lineNumber == 96 && columnNumber == 31)
                {
                    this.obj13.Click -= obj13Click;
                }
                else if (lineNumber == 97 && columnNumber == 31)
                {
                    this.obj14.Click -= obj14Click;
                }
                else if (lineNumber == 98 && columnNumber == 31)
                {
                    this.obj15.Click -= obj15Click;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8: // Views\Services\BatteryServicePage.xaml line 90
                        this.obj8 = (global::Template10.Controls.PageHeader)target;
                        break;
                    case 9: // Views\Services\BatteryServicePage.xaml line 113
                        this.obj9 = (global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl)target;
                        break;
                    case 10: // Views\Services\BatteryServicePage.xaml line 105
                        this.obj10 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)target;
                        this.bindingsTracking.RegisterTwoWayListener_10(this.obj10);
                        break;
                    case 11: // Views\Services\BatteryServicePage.xaml line 107
                        this.obj11 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)target;
                        this.bindingsTracking.RegisterTwoWayListener_11(this.obj11);
                        break;
                    case 12: // Views\Services\BatteryServicePage.xaml line 109
                        this.obj12 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)target;
                        this.bindingsTracking.RegisterTwoWayListener_12(this.obj12);
                        break;
                    case 13: // Views\Services\BatteryServicePage.xaml line 96
                        this.obj13 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj13Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoSettings();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj13Click;
                        break;
                    case 14: // Views\Services\BatteryServicePage.xaml line 97
                        this.obj14 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj14Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoPrivacy();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj14Click;
                        break;
                    case 15: // Views\Services\BatteryServicePage.xaml line 98
                        this.obj15 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj15Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoAbout();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj15Click;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IBatteryServicePage_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::BluetoothLEExplorer.Views.BatteryServicePage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BluetoothLEExplorer.Views.BatteryServicePage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::BluetoothLEExplorer.ViewModels.BatteryServicePageViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Service(obj.Service, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_BatteryLevel(obj.BatteryLevel, phase);
                        this.Update_ViewModel_ServiceVM(obj.ServiceVM, phase);
                    }
                }
            }
            private void Update_ViewModel_Service(global::GattServicesLibrary.Services.BatteryService obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Service_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_ViewModel_Service_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Services\BatteryServicePage.xaml line 90
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Template10_Controls_PageHeader_Text(this.obj8, obj, null);
                    }
                }
            }
            private void Update_ViewModel_BatteryLevel(global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_BatteryLevel(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Services\BatteryServicePage.xaml line 113
                    if (!isobj9CharacteristicDisabled)
                    {
                        XamlBindingSetters.Set_BluetoothLEExplorer_CustomControls_GattLocalCharacteristicControl_Characteristic(this.obj9, obj, null);
                    }
                }
            }
            private void Update_ViewModel_ServiceVM(global::BluetoothLEExplorer.ViewModels.GenericGattServiceViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_ServiceVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_ServiceVM_IsConnectable(obj.IsConnectable, phase);
                        this.Update_ViewModel_ServiceVM_IsDiscoverable(obj.IsDiscoverable, phase);
                        this.Update_ViewModel_ServiceVM_IsPublishing(obj.IsPublishing, phase);
                    }
                }
            }
            private void Update_ViewModel_ServiceVM_IsConnectable(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Services\BatteryServicePage.xaml line 105
                    if (!isobj10IsOnDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(this.obj10, obj);
                    }
                }
            }
            private void Update_ViewModel_ServiceVM_IsDiscoverable(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Services\BatteryServicePage.xaml line 107
                    if (!isobj11IsOnDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(this.obj11, obj);
                    }
                }
            }
            private void Update_ViewModel_ServiceVM_IsPublishing(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Services\BatteryServicePage.xaml line 109
                    if (!isobj12IsOnDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(this.obj12, obj);
                    }
                }
            }
            private void UpdateTwoWay_10_IsOn()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            if (this.dataRoot.ViewModel.ServiceVM != null)
                            {
                                this.dataRoot.ViewModel.ServiceVM.IsConnectable = this.obj10.IsOn;
                            }
                        }
                    }
                }
            }
            private void UpdateTwoWay_11_IsOn()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            if (this.dataRoot.ViewModel.ServiceVM != null)
                            {
                                this.dataRoot.ViewModel.ServiceVM.IsDiscoverable = this.obj11.IsOn;
                            }
                        }
                    }
                }
            }
            private void UpdateTwoWay_12_IsOn()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            if (this.dataRoot.ViewModel.ServiceVM != null)
                            {
                                this.dataRoot.ViewModel.ServiceVM.IsPublishing = this.obj12.IsOn;
                            }
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class BatteryServicePage_obj1_BindingsTracking
            {
                private global::System.WeakReference<BatteryServicePage_obj1_Bindings> weakRefToBindingObj; 

                public BatteryServicePage_obj1_BindingsTracking(BatteryServicePage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<BatteryServicePage_obj1_Bindings>(obj);
                }

                public BatteryServicePage_obj1_Bindings TryGetBindingObject()
                {
                    BatteryServicePage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_BatteryLevel(null);
                    UpdateChildListeners_ViewModel_ServiceVM(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    BatteryServicePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::BluetoothLEExplorer.ViewModels.BatteryServicePageViewModel obj = sender as global::BluetoothLEExplorer.ViewModels.BatteryServicePageViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_BatteryLevel(obj.BatteryLevel, DATA_CHANGED);
                                bindings.Update_ViewModel_ServiceVM(obj.ServiceVM, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "BatteryLevel":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_BatteryLevel(obj.BatteryLevel, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ServiceVM":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_ServiceVM(obj.ServiceVM, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::BluetoothLEExplorer.ViewModels.BatteryServicePageViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::BluetoothLEExplorer.ViewModels.BatteryServicePageViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_BatteryLevel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    BatteryServicePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel obj = sender as global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel cache_ViewModel_BatteryLevel = null;
                public void UpdateChildListeners_ViewModel_BatteryLevel(global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel obj)
                {
                    if (obj != cache_ViewModel_BatteryLevel)
                    {
                        if (cache_ViewModel_BatteryLevel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_BatteryLevel).PropertyChanged -= PropertyChanged_ViewModel_BatteryLevel;
                            cache_ViewModel_BatteryLevel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_BatteryLevel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_BatteryLevel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_ServiceVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    BatteryServicePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::BluetoothLEExplorer.ViewModels.GenericGattServiceViewModel obj = sender as global::BluetoothLEExplorer.ViewModels.GenericGattServiceViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_ServiceVM_IsConnectable(obj.IsConnectable, DATA_CHANGED);
                                bindings.Update_ViewModel_ServiceVM_IsDiscoverable(obj.IsDiscoverable, DATA_CHANGED);
                                bindings.Update_ViewModel_ServiceVM_IsPublishing(obj.IsPublishing, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsConnectable":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_ServiceVM_IsConnectable(obj.IsConnectable, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsDiscoverable":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_ServiceVM_IsDiscoverable(obj.IsDiscoverable, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsPublishing":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_ServiceVM_IsPublishing(obj.IsPublishing, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::BluetoothLEExplorer.ViewModels.GenericGattServiceViewModel cache_ViewModel_ServiceVM = null;
                public void UpdateChildListeners_ViewModel_ServiceVM(global::BluetoothLEExplorer.ViewModels.GenericGattServiceViewModel obj)
                {
                    if (obj != cache_ViewModel_ServiceVM)
                    {
                        if (cache_ViewModel_ServiceVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_ServiceVM).PropertyChanged -= PropertyChanged_ViewModel_ServiceVM;
                            cache_ViewModel_ServiceVM = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_ServiceVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_ServiceVM;
                        }
                    }
                }
                public void RegisterTwoWayListener_10(global::Windows.UI.Xaml.Controls.ToggleSwitch sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ToggleSwitch.IsOnProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_10_IsOn();
                        }
                    });
                }
                public void RegisterTwoWayListener_11(global::Windows.UI.Xaml.Controls.ToggleSwitch sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ToggleSwitch.IsOnProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_11_IsOn();
                        }
                    });
                }
                public void RegisterTwoWayListener_12(global::Windows.UI.Xaml.Controls.ToggleSwitch sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ToggleSwitch.IsOnProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_12_IsOn();
                        }
                    });
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
            case 2: // Views\Services\BatteryServicePage.xaml line 18
                {
                    this.ViewModel = (global::BluetoothLEExplorer.ViewModels.BatteryServicePageViewModel)(target);
                }
                break;
            case 3: // Views\Services\BatteryServicePage.xaml line 52
                {
                    this.AdaptiveVisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4: // Views\Services\BatteryServicePage.xaml line 53
                {
                    this.VisualStateDisplayType = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5: // Views\Services\BatteryServicePage.xaml line 62
                {
                    this.VisualStateNarrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6: // Views\Services\BatteryServicePage.xaml line 71
                {
                    this.VisualStateNormal = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7: // Views\Services\BatteryServicePage.xaml line 79
                {
                    this.VisualStateWide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 8: // Views\Services\BatteryServicePage.xaml line 90
                {
                    this.pageHeader = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 10: // Views\Services\BatteryServicePage.xaml line 105
                {
                    this.ConnectableSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 11: // Views\Services\BatteryServicePage.xaml line 107
                {
                    this.DiscoverableSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 12: // Views\Services\BatteryServicePage.xaml line 109
                {
                    this.PublishingSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
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
            case 1: // Views\Services\BatteryServicePage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    BatteryServicePage_obj1_Bindings bindings = new BatteryServicePage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

