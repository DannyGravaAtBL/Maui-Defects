using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Simple_M10
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            TimeSpan duration = TimeSpan.FromMilliseconds(6000);
            var font = Microsoft.Maui.Font.OfSize("OpenSans-Regular", 10);

            var snackbarOptions = new SnackbarOptions
            {
                BackgroundColor = Colors.Red,
                TextColor = Colors.Black,
                ActionButtonTextColor = Colors.Blue,
                Font = font,
                ActionButtonFont = font
            };

            var snackbar = Snackbar.Make("Hello Snackbar", () => { }, "Close", duration,
                snackbarOptions, this);

            await snackbar.Show();
        }
    }
}
