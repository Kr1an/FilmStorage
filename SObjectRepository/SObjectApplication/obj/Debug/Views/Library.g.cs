﻿#pragma checksum "..\..\..\Views\Library.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0A69C4E4AAA22D2CC40CF747D345EB57"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SObjectApplication;
using SObjectApplication.Properties;
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


namespace SObjectApplication {
    
    
    /// <summary>
    /// Library
    /// </summary>
    public partial class Library : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Views\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnListCon;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnListFilm;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnListActor;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgBack;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Views\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgNext;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Views\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
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
            System.Uri resourceLocater = new System.Uri("/SObjectApplication;component/views/library.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Library.xaml"
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
            this.btnListCon = ((System.Windows.Controls.Image)(target));
            
            #line 30 "..\..\..\Views\Library.xaml"
            this.btnListCon.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnListCon_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnListFilm = ((System.Windows.Controls.Image)(target));
            
            #line 42 "..\..\..\Views\Library.xaml"
            this.btnListFilm.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnListFilm_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnListActor = ((System.Windows.Controls.Image)(target));
            
            #line 54 "..\..\..\Views\Library.xaml"
            this.btnListActor.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btnListActor_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.imgBack = ((System.Windows.Controls.Image)(target));
            
            #line 71 "..\..\..\Views\Library.xaml"
            this.imgBack.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.imgBack_MouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.imgNext = ((System.Windows.Controls.Image)(target));
            
            #line 74 "..\..\..\Views\Library.xaml"
            this.imgNext.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.imgBack_MouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

