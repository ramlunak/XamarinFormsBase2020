using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsBase.Library
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XFBContextPage : ContentPage
    {
        public XFBContextPage(ContentView contentView)
        {
            InitializeComponent();
        }
    }
}