﻿#pragma checksum "..\..\..\2_DoughnutChart\PULineChart.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B6A2AEFB560C7556728C1DA7B81FC5FAF35F7BE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Panuon.UI.Charts;
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


namespace Panuon.UI.Charts {
    
    
    /// <summary>
    /// PULineChart
    /// </summary>
    public partial class PULineChart : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\2_DoughnutChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Panuon.UI.Charts.PULineChart chart;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\2_DoughnutChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\2_DoughnutChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvasYAxis;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\2_DoughnutChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvasXAxis;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\2_DoughnutChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvasContainer;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\2_DoughnutChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path pathGrid;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\2_DoughnutChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Polyline polyline;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\2_DoughnutChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Polygon polygon;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\2_DoughnutChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvasPoints;
        
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
            System.Uri resourceLocater = new System.Uri("/Panuon.UI.Charts;component/2_doughnutchart/pulinechart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\2_DoughnutChart\PULineChart.xaml"
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
            this.chart = ((Panuon.UI.Charts.PULineChart)(target));
            
            #line 11 "..\..\..\2_DoughnutChart\PULineChart.xaml"
            this.chart.SizeChanged += new System.Windows.SizeChangedEventHandler(this.chart_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.canvasYAxis = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.canvasXAxis = ((System.Windows.Controls.Canvas)(target));
            return;
            case 5:
            this.canvasContainer = ((System.Windows.Controls.Canvas)(target));
            return;
            case 6:
            this.pathGrid = ((System.Windows.Shapes.Path)(target));
            return;
            case 7:
            this.polyline = ((System.Windows.Shapes.Polyline)(target));
            return;
            case 8:
            this.polygon = ((System.Windows.Shapes.Polygon)(target));
            return;
            case 9:
            this.canvasPoints = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

