namespace CVAppMobile.Pages.Home;

public partial class AboutUsPage : ContentPage
{
	public AboutUsPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        this.BindingContext = App.ServiceProvider.GetServices<ViewModel.Home.AboutUsViewmodel>().FirstOrDefault();
    }
}