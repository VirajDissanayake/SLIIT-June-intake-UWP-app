﻿#pragma checksum "C:\Users\Hp\Downloads\Compressed\SSB_Softwares-20180621T111427Z-001\SSB_Softwares\SSB_Softwares\google.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9EDF5C1769DF41C3C09343C66DD26CDE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSB_Softwares
{
    partial class google : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // google.xaml line 16
                {
                    this.w2 = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 2: // google.xaml line 22
                {
                    this.menu1 = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // google.xaml line 24
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element3 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element3).PointerEntered += this.On_Hover;
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element3).PointerExited += this.Off_Hover;
                }
                break;
            case 4: // google.xaml line 25
                {
                    this.menu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.menu).Click += this.Menu;
                }
                break;
            case 5: // google.xaml line 33
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.Modules;
                }
                break;
            case 6: // google.xaml line 28
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.Home;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

