#pragma checksum "C:\Users\JustJasonn\Desktop\CoachModule\CoachModule\CoachAdminUser.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BD3222116ABDC421F33460C100577DF9"
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
    partial class CoachAdminUser : 
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
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CoachAdminUser_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICoachAdminUser_Bindings
        {
            private global::BadmintonCourtBookingSystem.CoachAdminUser dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj7;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj7IsEnabledDisabled = false;

            private CoachAdminUser_obj1_BindingsTracking bindingsTracking;

            public CoachAdminUser_obj1_Bindings()
            {
                this.bindingsTracking = new CoachAdminUser_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 19 && columnNumber == 25)
                {
                    isobj7IsEnabledDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // CoachAdminUser.xaml line 17
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Button)target;
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

            // ICoachAdminUser_Bindings

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
                    this.dataRoot = (global::BadmintonCourtBookingSystem.CoachAdminUser)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BadmintonCourtBookingSystem.CoachAdminUser obj, int phase)
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
                    // CoachAdminUser.xaml line 17
                    if (!isobj7IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj7, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class CoachAdminUser_obj1_BindingsTracking
            {
                private global::System.WeakReference<CoachAdminUser_obj1_Bindings> weakRefToBindingObj; 

                public CoachAdminUser_obj1_BindingsTracking(CoachAdminUser_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<CoachAdminUser_obj1_Bindings>(obj);
                }

                public CoachAdminUser_obj1_Bindings TryGetBindingObject()
                {
                    CoachAdminUser_obj1_Bindings bindingObject = null;
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
                    CoachAdminUser_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::BadmintonCourtBookingSystem.CoachAdminUser obj = sender as global::BadmintonCourtBookingSystem.CoachAdminUser;
                        if (obj != null)
                        {
                            bindings.Update_Frame(obj.Frame, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Frame = 0;
                public void UpdateChildListeners_(global::BadmintonCourtBookingSystem.CoachAdminUser obj)
                {
                    CoachAdminUser_obj1_Bindings bindings = TryGetBindingObject();
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
                    CoachAdminUser_obj1_Bindings bindings = TryGetBindingObject();
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
            case 2: // CoachAdminUser.xaml line 24
                {
                    this.myHire = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 3: // CoachAdminUser.xaml line 58
                {
                    this.refreshButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.refreshButton).Click += this.refreshButton_Click;
                }
                break;
            case 6: // CoachAdminUser.xaml line 51
                {
                    global::Windows.UI.Xaml.Controls.Image element6 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element6).PointerPressed += this.deleteCButton_Click;
                }
                break;
            case 7: // CoachAdminUser.xaml line 17
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
                }
                break;
            case 8: // CoachAdminUser.xaml line 21
                {
                    this.welcomeCustomer = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
            case 1: // CoachAdminUser.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    CoachAdminUser_obj1_Bindings bindings = new CoachAdminUser_obj1_Bindings();
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

