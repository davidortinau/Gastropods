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

            Shell.SetTitleColor(this, Color.Blue);
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
            SearchBoxVisibility = SearchBoxVisibility.Expanded;
            IsSearchEnabled = true;
            ShowsResults = true;
            Placeholder = "Find a seashell...";
            CancelButtonColor = Color.White;
            TextColor = Color.White;
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
        public string Image
        {
            get
            {
                return $"https://loremflickr.com/320/240/{Text}%20shell";
            }
        }
    }
}
