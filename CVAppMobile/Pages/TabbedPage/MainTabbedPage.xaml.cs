using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace CVAppMobile.Pages.TabbedPage;

public partial class MainTabbedPage : Microsoft.Maui.Controls.TabbedPage
{
	public MainTabbedPage()
	{
		InitializeComponent();

        NavigationPage.SetHasNavigationBar(this, false);

        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSmoothScrollEnabled(false);
        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);
    }
}