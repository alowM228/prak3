﻿#pragma checksum "..\..\Page1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C7E14FD2A9A8C85C8FA48EBBB491A73D144902CEB24CBD91CFF9C965E6BCDF4F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// Page1
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Aqw;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx2;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Aqw = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.bt = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Page1.xaml"
            this.bt.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NameTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.NameTbx1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.NameTbx2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.bt1 = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Page1.xaml"
            this.bt1.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

