﻿#pragma checksum "..\..\..\PixelDrawer\PixelDrawer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A4216C8176A6FDA8D894B12A79549048C6A644A8EE4686F61E1BF7805ADA535"
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


namespace DDrop.Controls.PixelDrawer {
    
    
    /// <summary>
    /// PixelDrawer
    /// </summary>
    public partial class PixelDrawer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\PixelDrawer\PixelDrawer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DDrop.Controls.PixelDrawer.PixelDrawer pd;
        
        #line default
        #line hidden
        
        /// <summary>
        /// CanDrawing Name Field
        /// </summary>
        
        #line 20 "..\..\..\PixelDrawer\PixelDrawer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Canvas CanDrawing;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\PixelDrawer\PixelDrawer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image;
        
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
            System.Uri resourceLocater = new System.Uri("/DDrop.Controls;component/pixeldrawer/pixeldrawer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PixelDrawer\PixelDrawer.xaml"
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
            this.pd = ((DDrop.Controls.PixelDrawer.PixelDrawer)(target));
            return;
            case 2:
            this.CanDrawing = ((System.Windows.Controls.Canvas)(target));
            
            #line 21 "..\..\..\PixelDrawer\PixelDrawer.xaml"
            this.CanDrawing.MouseMove += new System.Windows.Input.MouseEventHandler(this.canDrawing_MouseMove_NotDown);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\PixelDrawer\PixelDrawer.xaml"
            this.CanDrawing.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.canDrawing_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Image = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

