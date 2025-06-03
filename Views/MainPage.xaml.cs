using GuevaraGExamenProg2.Views;
namespace GuevaraGExamenProg2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoChistes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chistes());
        }

        private void GoAbout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }

}
