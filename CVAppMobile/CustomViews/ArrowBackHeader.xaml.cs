namespace CVAppMobile.CustomViews;

public partial class ArrowBackHeader : ContentView
{
	public ArrowBackHeader()
	{
		InitializeComponent();
	}

    public View MainContent
    {
        get { return PageContent.Content; }
        set { PageContent.Content = value; }
    }

    public string TitlePage
    {
        get { return (string)GetValue(TitlePageProperty); }
        set { SetValue(TitlePageProperty, value); }
    }

    public static readonly BindableProperty TitlePageProperty = BindableProperty.Create(nameof(TitlePage), typeof(string), typeof(ArrowBackHeader), default(string),
    propertyChanged: (bindable, oldValue, newValue) =>
    {
        var me = (ArrowBackHeader)bindable;
        me.MainTitle.Text = newValue.ToString();
    });
}