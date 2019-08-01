using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFPre4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        List<string> intlst = new List<string>();
        public MainPage()
        {
            InitializeComponent();
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                intlst.Add( $"Item is{i}");
            }
           // cv.ItemsSource = intlst;
        }
    }
}
