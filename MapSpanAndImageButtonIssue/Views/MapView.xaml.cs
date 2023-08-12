using MapSpanAndImageButtonIssue.ViewModels;

namespace MapSpanAndImageButtonIssue.Views;

public partial class MapView : BaseContentPage
{
	public MapView(MapViewModel mapViewModel)
	{
		BindingContext= mapViewModel;
		InitializeComponent();
	}
}