namespace MauiAppTest.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetail1DetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
