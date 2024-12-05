namespace CVAppMobile.Pages.Experience;

public partial class ExperiencePage : ContentPage
{
	public ExperiencePage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        this.BindingContext = App.ServiceProvider.GetServices<ViewModel.Experience.ExperienceViewModel>().FirstOrDefault();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ((ViewModel.Experience.ExperienceViewModel)this.BindingContext).Initialize();
    }
}