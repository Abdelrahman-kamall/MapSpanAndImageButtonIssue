using MapSpanAndImageButtonIssue.ViewModels;

namespace MapSpanAndImageButtonIssue.Views;

public partial class ButtonsView : BaseContentPage
{
	public ButtonsView(ButtonsViewModel buttonsViewModel)
	{
		BindingContext = buttonsViewModel;
		InitializeComponent();
	}
}