﻿#pragma checksum "..\..\..\..\Windows\DashboardWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ED358C8348153C49AF4434661297709385E030D"
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
    /// DashboardWindow
    /// </summary>
    public partial class DashboardWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCreateOrder;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReturnBook;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReturnBookFollow;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBook;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnManager;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCustomer;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnManager_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/LibraryApp;component/windows/dashboardwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\DashboardWindow.xaml"
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
            this.BtnCreateOrder = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnCreateOrder.Click += new System.Windows.RoutedEventHandler(this.BtnCreateOrder_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnReturnBook = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnReturnBook.Click += new System.Windows.RoutedEventHandler(this.BtnReturnBook_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnReturnBookFollow = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.BtnBook = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnBook.Click += new System.Windows.RoutedEventHandler(this.BtnBook_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnManager = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnManager.Click += new System.Windows.RoutedEventHandler(this.BtnManager_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnCustomer.Click += new System.Windows.RoutedEventHandler(this.BtnCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnManager_Copy = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

