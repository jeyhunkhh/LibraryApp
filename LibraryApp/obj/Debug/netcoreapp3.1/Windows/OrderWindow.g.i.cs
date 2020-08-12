﻿#pragma checksum "..\..\..\..\Windows\OrderWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B5B75CEDFEA358154748F962C8B11E5AD546FD62"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryApp.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using System.Windows.Shell;


namespace LibraryApp.Windows {
    
    
    /// <summary>
    /// OrderWindow
    /// </summary>
    public partial class OrderWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblCustomers;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSearchCustomers;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgvCustomers;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblBooks;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBookSearch;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgvBooks;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblCreateDate;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DtpCreateDate;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblDeadline;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DtpDeadline;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOrderCreate;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbSelectedBook;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOrderView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryApp;component/windows/orderwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\OrderWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LblCustomers = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TxtSearchCustomers = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\..\Windows\OrderWindow.xaml"
            this.TxtSearchCustomers.KeyUp += new System.Windows.Input.KeyEventHandler(this.TxtSearchCustomers_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DgvCustomers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\..\..\Windows\OrderWindow.xaml"
            this.DgvCustomers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgvCustomers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LblBooks = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.TxtBookSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\..\Windows\OrderWindow.xaml"
            this.TxtBookSearch.KeyUp += new System.Windows.Input.KeyEventHandler(this.TxtBookSearch_KeyUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DgvBooks = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\..\..\Windows\OrderWindow.xaml"
            this.DgvBooks.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgvBooks_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LblCreateDate = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.DtpCreateDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.LblDeadline = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.DtpDeadline = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 11:
            this.BtnOrderCreate = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Windows\OrderWindow.xaml"
            this.BtnOrderCreate.Click += new System.Windows.RoutedEventHandler(this.BtnOrderCreate_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.TbSelectedBook = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.BtnOrderView = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Windows\OrderWindow.xaml"
            this.BtnOrderView.Click += new System.Windows.RoutedEventHandler(this.BtnOrderView_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

