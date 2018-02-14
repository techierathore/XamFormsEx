using Xamarin.Forms;
using XamFormsEx.CustomCells;
using XamFormsEx.ViewModel;

namespace XamFormsEx.Templates
{
    public partial class DataTempChatEx : ContentPage
	{
		public DataTempChatEx ()
		{
			InitializeComponent ();
            Title = "Xam Chat";
            BindingContext = new ChatViewModel();
        }
        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MessagesListView.SelectedItem = null;
        }

        private void MyListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            MessagesListView.SelectedItem = null;

        }
    }

    public class MyDataTemplateSelector : DataTemplateSelector
    {
        public MyDataTemplateSelector()
        {
            // Retain instances!
            incomingDataTemplate = new DataTemplate(typeof(ChatIncoming));
            outgoingDataTemplate = new DataTemplate(typeof(ChatOutgoing));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as MessageViewModel;
            if (messageVm == null)
                return null;
            return messageVm.IsIncoming ? incomingDataTemplate : outgoingDataTemplate;
        }

        private readonly DataTemplate incomingDataTemplate;
        private readonly DataTemplate outgoingDataTemplate;
    }

}