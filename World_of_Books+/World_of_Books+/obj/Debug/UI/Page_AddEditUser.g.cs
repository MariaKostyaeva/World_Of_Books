#pragma checksum "..\..\..\UI\Page_AddEditUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C0984AEFEF25972E4DBD77EC99404FAE66CF2B82430535F27C311CBF0704CB6B"
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
    /// Page_AddEditUser
    /// </summary>
    public partial class Page_AddEditUser : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\UI\Page_AddEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image user_photo;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UI\Page_AddEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addUserPhoto;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\UI\Page_AddEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteUserPhoto;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\UI\Page_AddEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxName;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\UI\Page_AddEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxSurname;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\UI\Page_AddEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxAddress;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\UI\Page_AddEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxRole;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\UI\Page_AddEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxLogin;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\UI\Page_AddEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\UI\Page_AddEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSave;
        
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
            System.Uri resourceLocater = new System.Uri("/World_of_Books+;component/ui/page_addedituser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\Page_AddEditUser.xaml"
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
            this.user_photo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.addUserPhoto = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\UI\Page_AddEditUser.xaml"
            this.addUserPhoto.Click += new System.Windows.RoutedEventHandler(this.addUserPhoto_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.deleteUserPhoto = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\UI\Page_AddEditUser.xaml"
            this.deleteUserPhoto.Click += new System.Windows.RoutedEventHandler(this.deleteUserPhoto_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBoxSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textBoxAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.comboBoxRole = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.textBoxLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.textBoxPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.buttonSave = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\..\UI\Page_AddEditUser.xaml"
            this.buttonSave.Click += new System.Windows.RoutedEventHandler(this.buttonSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

