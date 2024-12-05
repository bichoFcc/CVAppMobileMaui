namespace CVAppMobile.Pages.Projects;

public partial class ProjectsPage : ContentPage
{
	public ProjectsPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        this.BindingContext = App.ServiceProvider.GetServices<ViewModel.Projects.ProjectsViewModel>().FirstOrDefault();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ((ViewModel.Projects.ProjectsViewModel)this.BindingContext).Initialize();
    }
}