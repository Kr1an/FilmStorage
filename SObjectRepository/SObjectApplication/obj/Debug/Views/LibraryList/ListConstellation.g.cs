﻿#pragma checksum "..\..\..\..\Views\LibraryList\ListConstellation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3826E8F4473DD90BB2B946AE2E945569"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SObjectApplication.Views.LibraryList;
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


namespace SObjectApplication.Views.LibraryList {
    
    
    /// <summary>
    /// ListConstellation
    /// </summary>
    public partial class ListConstellation : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 33 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgBack;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgNext;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btn_delete;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btn_info;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btn_add;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn colShortName;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn colName;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn colStarNum;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn colPosition;
        
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
            System.Uri resourceLocater = new System.Uri("/SObjectApplication;component/views/librarylist/listconstellation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
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
            this.imgBack = ((System.Windows.Controls.Image)(target));
            
            #line 33 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
            this.imgBack.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.imgBack_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgNext = ((System.Windows.Controls.Image)(target));
            
            #line 36 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
            this.imgNext.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.imgNext_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_delete = ((System.Windows.Controls.Image)(target));
            
            #line 39 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
            this.btn_delete.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_delete_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_info = ((System.Windows.Controls.Image)(target));
            
            #line 40 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
            this.btn_info.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_info_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_add = ((System.Windows.Controls.Image)(target));
            
            #line 41 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
            this.btn_add.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_add_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listView = ((System.Windows.Controls.ListView)(target));
            
            #line 45 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
            this.listView.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.GridViewColumnHeaderClickedHandler));
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
            this.listView.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.listView_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.colShortName = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 9:
            this.colName = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 10:
            this.colStarNum = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 11:
            this.colPosition = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 7:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 48 "..\..\..\..\Views\LibraryList\ListConstellation.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.listViewItem_MouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

