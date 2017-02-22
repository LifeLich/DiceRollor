using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DiceRollor
{
    public partial class DicePage : ContentPage
    {
        private Random rnd = new Random();
        private List<Dice> Dices = new List<Dice>();

        public DicePage(int num)
        {
            InitializeComponent();
            for (int i = 0; i < num; i++)
            {
                int dice = rnd.Next(1, 6);
                Dice D = new Dice() { Side = dice, time = DateTime.Now };
                Dices.Add(D);
            }
            LvDices.ItemsSource = Dices;
        }

        private async void OnButtonClicked_buttonBack(object sender, EventArgs e)
        {
        await Navigation.PushAsync(new MainPage());
        }
    }
}
