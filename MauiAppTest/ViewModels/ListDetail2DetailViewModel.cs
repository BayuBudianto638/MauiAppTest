namespace MauiAppTest.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetail2DetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
