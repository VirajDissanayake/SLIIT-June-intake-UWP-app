﻿#pragma checksum "C:\Users\Viraj Dissanayake\source\repos\SSB_Softwares\SSB_Softwares\Entertainment.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A25697488A0DFA5E96E78AA9E6A5382E"
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
    partial class Entertainment : 
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
            case 1: // Entertainment.xaml line 15
                {
                    this.menu1 = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2: // Entertainment.xaml line 28
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.Kdrama;
                }
                break;
            case 3: // Entertainment.xaml line 37
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.Google;
                }
                break;
            case 4: // Entertainment.xaml line 42
                {
                    this.spd = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.spd).Click += this.Tv;
                }
                break;
            case 5: // Entertainment.xaml line 17
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element5 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element5).PointerEntered += this.On_Hover;
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element5).PointerExited += this.Off_Hover;
                }
                break;
            case 6: // Entertainment.xaml line 18
                {
                    this.menu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.menu).Click += this.Menu;
                }
                break;
            case 7: // Entertainment.xaml line 21
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.Home;
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

