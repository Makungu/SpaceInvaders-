﻿#pragma checksum "..\..\StartScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE58F65906C66DC52E3A4D24CB690BB603EDB4FC1F7E1879F337F8382482C4EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SpaceInvaders;
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


namespace SpaceInvaders {
    
    
    /// <summary>
    /// StartScreen
    /// </summary>
    public partial class StartScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\StartScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\StartScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button highscoreBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\StartScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button leaderBoardBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/SpaceInvaders;component/startscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StartScreen.xaml"
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
            this.playBtn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\StartScreen.xaml"
            this.playBtn.Click += new System.Windows.RoutedEventHandler(this.playBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.highscoreBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\StartScreen.xaml"
            this.highscoreBtn.Click += new System.Windows.RoutedEventHandler(this.playBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.leaderBoardBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\StartScreen.xaml"
            this.leaderBoardBtn.Click += new System.Windows.RoutedEventHandler(this.leaderBoardBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

