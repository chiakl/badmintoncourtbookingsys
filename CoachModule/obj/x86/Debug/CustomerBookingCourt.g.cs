#pragma checksum "C:\Users\JustJasonn\Desktop\CoachModule\CoachModule\CustomerBookingCourt.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "85832915B32882108F857A0EAE56515E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BadmintonCourtBookingSystem
{
    partial class CustomerBookingCourt : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CustomerBookingCourt_obj16_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICustomerBookingCourt_Bindings
        {
            private global::BadmintonCourtBookingSystem.Court dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj16;
            private global::Windows.UI.Xaml.Controls.TextBlock obj18;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj18TextDisabled = false;

            public CustomerBookingCourt_obj16_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 71 && columnNumber == 64)
                {
                    isobj18TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 16: // CustomerBookingCourt.xaml line 62
                        this.obj16 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 18: // CustomerBookingCourt.xaml line 71
                        this.obj18 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj16.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::BadmintonCourtBookingSystem.Court) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ICustomerBookingCourt_Bindings

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
                    this.dataRoot = (global::BadmintonCourtBookingSystem.Court)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BadmintonCourtBookingSystem.Court obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_CourtId(obj.CourtId, phase);
                    }
                }
            }
            private void Update_CourtId(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // CustomerBookingCourt.xaml line 71
                    if (!isobj18TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj18, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CustomerBookingCourt_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICustomerBookingCourt_Bindings
        {
            private global::BadmintonCourtBookingSystem.CustomerBookingCourt dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj20;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj20IsEnabledDisabled = false;

            private CustomerBookingCourt_obj1_BindingsTracking bindingsTracking;

            public CustomerBookingCourt_obj1_Bindings()
            {
                this.bindingsTracking = new CustomerBookingCourt_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 30 && columnNumber == 29)
                {
                    isobj20IsEnabledDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 20: // CustomerBookingCourt.xaml line 28
                        this.obj20 = (global::Windows.UI.Xaml.Controls.Button)target;
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

            // ICustomerBookingCourt_Bindings

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
                    this.dataRoot = (global::BadmintonCourtBookingSystem.CustomerBookingCourt)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BadmintonCourtBookingSystem.CustomerBookingCourt obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Frame(obj.Frame, phase);
                    }
                }
            }
            private void Update_Frame(global::Windows.UI.Xaml.Controls.Frame obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Frame(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Frame_CanGoBack(obj.CanGoBack, phase);
                    }
                }
            }
            private void Update_Frame_CanGoBack(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // CustomerBookingCourt.xaml line 28
                    if (!isobj20IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj20, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class CustomerBookingCourt_obj1_BindingsTracking
            {
                private global::System.WeakReference<CustomerBookingCourt_obj1_Bindings> weakRefToBindingObj; 

                public CustomerBookingCourt_obj1_BindingsTracking(CustomerBookingCourt_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<CustomerBookingCourt_obj1_Bindings>(obj);
                }

                public CustomerBookingCourt_obj1_Bindings TryGetBindingObject()
                {
                    CustomerBookingCourt_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_(null);
                    UpdateChildListeners_Frame(null);
                }

                public void DependencyPropertyChanged_Frame(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    CustomerBookingCourt_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::BadmintonCourtBookingSystem.CustomerBookingCourt obj = sender as global::BadmintonCourtBookingSystem.CustomerBookingCourt;
                        if (obj != null)
                        {
                            bindings.Update_Frame(obj.Frame, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Frame = 0;
                public void UpdateChildListeners_(global::BadmintonCourtBookingSystem.CustomerBookingCourt obj)
                {
                    CustomerBookingCourt_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Page.FrameProperty, tokenDPC_Frame);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Frame = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Page.FrameProperty, DependencyPropertyChanged_Frame);
                        }
                    }
                }
                public void DependencyPropertyChanged_Frame_CanGoBack(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    CustomerBookingCourt_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Windows.UI.Xaml.Controls.Frame obj = sender as global::Windows.UI.Xaml.Controls.Frame;
                        if (obj != null)
                        {
                            bindings.Update_Frame_CanGoBack(obj.CanGoBack, DATA_CHANGED);
                        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.Frame cache_Frame = null;
                private long tokenDPC_Frame_CanGoBack = 0;
                public void UpdateChildListeners_Frame(global::Windows.UI.Xaml.Controls.Frame obj)
                {
                    if (obj != cache_Frame)
                    {
                        if (cache_Frame != null)
                        {
                            cache_Frame.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Frame.CanGoBackProperty, tokenDPC_Frame_CanGoBack);
                            cache_Frame = null;
                        }
                        if (obj != null)
                        {
                            cache_Frame = obj;
                            tokenDPC_Frame_CanGoBack = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Frame.CanGoBackProperty, DependencyPropertyChanged_Frame_CanGoBack);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // CustomerBookingCourt.xaml line 144
                {
                    this.confirmOrder = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.confirmOrder).Click += this.confirmOrder_Click;
                }
                break;
            case 3: // CustomerBookingCourt.xaml line 141
                {
                    this.qrcode = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // CustomerBookingCourt.xaml line 133
                {
                    this.calcFee = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.calcFee).Click += this.calcFee_Click;
                }
                break;
            case 5: // CustomerBookingCourt.xaml line 134
                {
                    this.UploadReceipt = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.UploadReceipt).Click += this.lnkUploadImage_Click_1;
                }
                break;
            case 6: // CustomerBookingCourt.xaml line 135
                {
                    this.feees = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // CustomerBookingCourt.xaml line 123
                {
                    this.userEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // CustomerBookingCourt.xaml line 120
                {
                    this.userName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // CustomerBookingCourt.xaml line 90
                {
                    this.AddedList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 11: // CustomerBookingCourt.xaml line 111
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.deleteButton_Click_1;
                }
                break;
            case 12: // CustomerBookingCourt.xaml line 85
                {
                    this.ViewBookCourt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // CustomerBookingCourt.xaml line 44
                {
                    this.ViewCourt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // CustomerBookingCourt.xaml line 47
                {
                    this.CourtList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 17: // CustomerBookingCourt.xaml line 74
                {
                    global::Windows.UI.Xaml.Controls.Button element17 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element17).Click += this.addButton_Click_1;
                }
                break;
            case 19: // CustomerBookingCourt.xaml line 39
                {
                    this.ModuleDesc = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // CustomerBookingCourt.xaml line 28
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // CustomerBookingCourt.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    CustomerBookingCourt_obj1_Bindings bindings = new CustomerBookingCourt_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 16: // CustomerBookingCourt.xaml line 62
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element16 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    CustomerBookingCourt_obj16_Bindings bindings = new CustomerBookingCourt_obj16_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element16.DataContext);
                    element16.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element16, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element16, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

