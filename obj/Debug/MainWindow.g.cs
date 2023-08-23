﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E85F180AF3892A227BCEE20BEC90929FEFDEB723EF477C7A88A812A96DEF0ACF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HalconDotNet;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using Visiomex.Projects.LabelingTool;


namespace Visiomex.Projects.LabelingTool {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateNewProjectButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadProjectButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseApplicationButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HalconDotNet.HSmartWindowControlWPF LabellingHWindow;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DrawTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LabelTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddDeleteLabelTypeButton;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border DropFilesPathBorder;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addPhoto;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AllImagesListView;
        
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
            System.Uri resourceLocater = new System.Uri("/Visiomex.Projects.LabelingTool;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.CreateNewProjectButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.CreateNewProjectButton.Click += new System.Windows.RoutedEventHandler(this.CreateNewProjectButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoadProjectButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\MainWindow.xaml"
            this.LoadProjectButton.Click += new System.Windows.RoutedEventHandler(this.LoadProjectButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CloseApplicationButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\MainWindow.xaml"
            this.CloseApplicationButton.Click += new System.Windows.RoutedEventHandler(this.CloseApplicationButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LabellingHWindow = ((HalconDotNet.HSmartWindowControlWPF)(target));
            
            #line 76 "..\..\MainWindow.xaml"
            this.LabellingHWindow.HMouseDown += new HalconDotNet.HSmartWindowControlWPF.HMouseEventHandlerWPF(this.LabellingHWindow_HMouseDown);
            
            #line default
            #line hidden
            
            #line 76 "..\..\MainWindow.xaml"
            this.LabellingHWindow.HMouseMove += new HalconDotNet.HSmartWindowControlWPF.HMouseEventHandlerWPF(this.LabellingHWindow_HMouseMove);
            
            #line default
            #line hidden
            
            #line 76 "..\..\MainWindow.xaml"
            this.LabellingHWindow.HMouseUp += new HalconDotNet.HSmartWindowControlWPF.HMouseEventHandlerWPF(this.LabellingHWindow_HMouseUp);
            
            #line default
            #line hidden
            
            #line 76 "..\..\MainWindow.xaml"
            this.LabellingHWindow.HMouseDoubleClick += new HalconDotNet.HSmartWindowControlWPF.HMouseEventHandlerWPF(this.LabellingHWindow_HMouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 76 "..\..\MainWindow.xaml"
            this.LabellingHWindow.HMouseWheel += new HalconDotNet.HSmartWindowControlWPF.HMouseEventHandlerWPF(this.LabellingHWindow_HMouseWheel);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 79 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddROIMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DrawTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 97 "..\..\MainWindow.xaml"
            this.DrawTypeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DrawTypeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LabelTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 108 "..\..\MainWindow.xaml"
            this.LabelTypeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LabelTypeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddDeleteLabelTypeButton = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\MainWindow.xaml"
            this.AddDeleteLabelTypeButton.Click += new System.Windows.RoutedEventHandler(this.AddDeleteLabelTypeButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DropFilesPathBorder = ((System.Windows.Controls.Border)(target));
            
            #line 124 "..\..\MainWindow.xaml"
            this.DropFilesPathBorder.Drop += new System.Windows.DragEventHandler(this.DropFilesPathBorder_Drop);
            
            #line default
            #line hidden
            
            #line 124 "..\..\MainWindow.xaml"
            this.DropFilesPathBorder.DragOver += new System.Windows.DragEventHandler(this.DropFilesPathBorder_DragOver);
            
            #line default
            #line hidden
            
            #line 124 "..\..\MainWindow.xaml"
            this.DropFilesPathBorder.DragLeave += new System.Windows.DragEventHandler(this.DropFilesPathBorder_DragLeave);
            
            #line default
            #line hidden
            return;
            case 10:
            this.addPhoto = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\MainWindow.xaml"
            this.addPhoto.Click += new System.Windows.RoutedEventHandler(this.addPhoto_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.AllImagesListView = ((System.Windows.Controls.ListView)(target));
            
            #line 155 "..\..\MainWindow.xaml"
            this.AllImagesListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AllImagesListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

