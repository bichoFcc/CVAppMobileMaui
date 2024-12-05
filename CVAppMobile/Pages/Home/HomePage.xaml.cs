namespace CVAppMobile.Pages.Home;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        this.BindingContext = App.ServiceProvider.GetServices<ViewModel.Home.HomeViewModel>().FirstOrDefault();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ((ViewModel.Home.HomeViewModel)this.BindingContext).Initialize();
    }
}