namespace CVAppMobile.Pages.Mopups;

public partial class GeneralMopup : ContentPage
{
	public GeneralMopup(params object[] parameters)
	{
		InitializeComponent();
        this.BindingContext = App.ServiceProvider.GetServices<ViewModel.Mopup.MopupViewModel>().FirstOrDefault();
        if (parameters != null && parameters.Length > 0)
        {
            ((ViewModel.Mopup.MopupViewModel)this.BindingContext).GenericText = (string)parameters[0];
        }
    }
}