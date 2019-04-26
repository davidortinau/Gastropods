using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Gastropod
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Gastropod.AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static ObservableCollection<Seashell> Seashells = new ObservableCollection<Seashell>{
                new Seashell {
                    Text = "Auger"
                },
                new Seashell {
                    Text = "Abalone"
                },
                new Seashell {
                    Text = "Babylon"
                },
                new Seashell {
                    Text = "Bonnet"
                },
                new Seashell {
                    Text = "Clam"
                },
                new Seashell {
                    Text = "Conch"
                },
                new Seashell {
                    Text = "Cone"
                },
                new Seashell {
                    Text = "Cowrie"
                },
                new Seashell {
                    Text = "Drupe"
                },
                new Seashell {
                    Text = "Egg"
                },
                new Seashell {
                    Text = "Fig"
                },
                new Seashell {
                    Text = "Frog"
                },
                new Seashell {
                    Text = "Harp"
                },
                new Seashell {
                    Text = "Helmet"
                },
                new Seashell {
                    Text = "Land Snail"
                },
                new Seashell {
                    Text = "Limpet"
                },
                new Seashell {
                    Text = "Melon"
                },
                new Seashell {
                    Text = "Melongina"
                },
                new Seashell {
                    Text = "Mitre"
                },
                new Seashell {
                    Text = "Moon Shells"
                },
                new Seashell {
                    Text = "Murex"
                },
                new Seashell {
                    Text = "Nassa"
                },
                new Seashell {
                    Text = "Nautilus"
                },
                new Seashell {
                    Text = "Olive"
                },
                new Seashell {
                    Text = "Operculum"
                },
                new Seashell {
                    Text = "Scallop"
                },
                new Seashell {
                    Text = "Spindle"
                },
                new Seashell {
                    Text = "Strombus"
                },
                new Seashell {
                    Text = "Sundial"
                },
                new Seashell {
                    Text = "Tibia"
                },
                new Seashell {
                    Text = "Tonna"
                },
                new Seashell {
                    Text = "Top"
                },
                new Seashell {
                    Text = "Triton"
                },
                new Seashell {
                    Text = "Turritella"
                },
                new Seashell {
                    Text = "Turbo"
                },
                new Seashell {
                    Text = "Umbonium"
                },
                new Seashell {
                    Text = "Volute"
                }
            };
    }
}
