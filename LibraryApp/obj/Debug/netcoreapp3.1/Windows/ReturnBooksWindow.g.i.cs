﻿#pragma checksum "..\..\..\..\Windows\ReturnBooksWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0F905DAA0C2341806E936A22050673298C9B7A75"
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
    /// ReturnBooksWindow
    /// </summary>
    public partial class ReturnBooksWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Windows\ReturnBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblCustomerSearch;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Windows\ReturnBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCustomerSearch;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Windows\ReturnBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgvOrders;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Windows\ReturnBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbBooks;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Windows\ReturnBooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReturnBook;
        
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
            System.Uri resourceLocater = new System.Uri("/LibraryApp;component/windows/returnbookswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\ReturnBooksWindow.xaml"
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
            this.LblCustomerSearch = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TxtCustomerSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\..\Windows\ReturnBooksWindow.xaml"
            this.TxtCustomerSearch.KeyUp += new System.Windows.Input.KeyEventHandler(this.TxtCustomerSearch_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DgvOrders = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\..\..\Windows\ReturnBooksWindow.xaml"
            this.DgvOrders.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgvOrders_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TbBooks = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.BtnReturnBook = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Windows\ReturnBooksWindow.xaml"
            this.BtnReturnBook.Click += new System.Windows.RoutedEventHandler(this.BtnReturnBook_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

