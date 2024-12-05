namespace CVAppMobile.Pages.Skills;

public partial class SkillsPage : ContentPage
{
	public SkillsPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        this.BindingContext = App.ServiceProvider.GetServices<ViewModel.Skills.SkillsViewModel>().FirstOrDefault();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ((ViewModel.Skills.SkillsViewModel)this.BindingContext).Initialize();
    }
}