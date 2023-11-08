namespace MauiAppPopupError;

public partial class NewPage1 : ContentPage
{
	public NewPage1(NewPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}