﻿#pragma checksum "C:\Users\84985\source\c#\Splitview\Splitview\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A75B88EE9877C2F1B371DEC0FF4C9A4A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Splitview
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 11
                {
                    this.splitview = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // MainPage.xaml line 14
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element3 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element3).Tapped += this.ToggleMenu_Click;
                }
                break;
            case 4: // MainPage.xaml line 18
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element4 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element4).Click += this.ChangeContent;
                }
                break;
            case 5: // MainPage.xaml line 19
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element5 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element5).Click += this.ChangeContent;
                }
                break;
            case 6: // MainPage.xaml line 25
                {
                    this.MainContent = (global::Windows.UI.Xaml.Controls.Frame)(target);
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
            return returnValue;
        }
    }
}

