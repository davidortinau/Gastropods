using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Gastropod
{
    [Preserve]
    [QueryProperty("Payload", "payload")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CameraPage : ContentPage
	{
		public CameraPage ()
		{
			InitializeComponent ();
		}

        private string _payload;
        public string Payload
        {
            get { return _payload; }
            set { _payload = value;
                PayloadLabel.Text = _payload;
            }
        }
	}
}