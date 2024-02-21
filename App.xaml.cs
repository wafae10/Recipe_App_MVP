using Xamarin.Forms;
using MagicRecipe; // Make sure to include the correct namespace

namespace MagicRecipe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage(); // Set MainPage to an instance of the MainPage class
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
