namespace MauiAppTest.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetail3DetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
