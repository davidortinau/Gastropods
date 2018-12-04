using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Gastropod
{
    public partial class FeedPage : ContentPage
    {
        public ObservableCollection<Seashell> Items { get; set; } = App.Seashells;

        public FeedPage()
        {
            InitializeComponent();
            Shell.SetShellTitleColor(this, Color.Blue);
            Shell.SetSearchHandler(this, new FeedSearchHandler());
            Shell.SetFlyoutBehavior(this, FlyoutBehavior.Disabled);
            Title = "Gastropods";
            BindingContext = this;
        }
    }

    public class FeedSearchHandler : SearchHandler
    {
        public FeedSearchHandler()
        {
            SearchBoxVisibility = SearchBoxVisiblity.Expanded;
            IsSearchEnabled = true;
            ShowsResults = true;
            Placeholder = "Find a seashell...";
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            if (string.IsNullOrEmpty(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                var results = new List<string>();
                results = App.Seashells.Where(x => x.Text.IndexOf(newValue, StringComparison.InvariantCultureIgnoreCase) > -1).Select(x => x.Text).ToList<string>();
                ItemsSource = results;
            }
        }
    }

    public class Seashell
    {
        public string Text { get; set; }
        public string Description { get; set; }
    }
}
