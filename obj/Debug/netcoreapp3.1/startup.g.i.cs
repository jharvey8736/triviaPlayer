﻿#pragma checksum "..\..\..\Startup.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A3BCD563E096400BEF8D446B94E56A686206B54B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Jonathan;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock David;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock body;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textType;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox gameIDEntered;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label textLabel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button storeButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox johnScore;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox davidScore;
        
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
            System.Uri resourceLocater = new System.Uri("/triviaGame;component/startup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Startup.xaml"
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
            this.Jonathan = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.David = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.body = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.startButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Startup.xaml"
            this.startButton.Click += new System.Windows.RoutedEventHandler(this.startButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textType = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.gameIDEntered = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\Startup.xaml"
            this.gameIDEntered.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.gameIDEntered_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.storeButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Startup.xaml"
            this.storeButton.Click += new System.Windows.RoutedEventHandler(this.storeButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.johnScore = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.davidScore = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

