using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsEx.CustomCells
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChatOutgoing : ViewCell
	{
		public ChatOutgoing ()
		{
			InitializeComponent ();
		}
	}
}