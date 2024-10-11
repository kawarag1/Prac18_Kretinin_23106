namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn1_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage1());
        }
    }

}
