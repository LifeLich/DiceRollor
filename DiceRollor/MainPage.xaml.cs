using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiceRollor
{
    public partial class MainPage : ContentPage
    {
        private int i;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnButtonClicked_button1(object sender, EventArgs e)
        {
            if (tbMultiLine.Text == null)
            {
                tbMultiLine.Text = "0";
            }
            int num =Int32.Parse(tbMultiLine.Text);

            await Navigation.PushAsync(new DicePage(num));
        }
    }
}
