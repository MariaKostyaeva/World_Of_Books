#pragma checksum "..\..\..\UI\Page_Statistics.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "69459775C0F7D6338F7E5E63BB1963E60DED49DD65E5482E4C688654F483B931"
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.Integration;
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
using World_of_Books_.UI;


namespace World_of_Books_.UI {
    
    
    /// <summary>
    /// Page_Statistics
    /// </summary>
    public partial class Page_Statistics : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\UI\Page_Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker periodFrom;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UI\Page_Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker periodFor;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\UI\Page_Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboChartTypes;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\UI\Page_Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
        
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
            System.Uri resourceLocater = new System.Uri("/World_of_Books+;component/ui/page_statistics.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\Page_Statistics.xaml"
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
            this.periodFrom = ((System.Windows.Controls.DatePicker)(target));
            
            #line 27 "..\..\..\UI\Page_Statistics.xaml"
            this.periodFrom.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.UpdateChart);
            
            #line default
            #line hidden
            return;
            case 2:
            this.periodFor = ((System.Windows.Controls.DatePicker)(target));
            
            #line 36 "..\..\..\UI\Page_Statistics.xaml"
            this.periodFor.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.UpdateChart);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboChartTypes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 50 "..\..\..\UI\Page_Statistics.xaml"
            this.comboChartTypes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UpdateChart);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chartStatistics = ((System.Windows.Forms.DataVisualization.Charting.Chart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

