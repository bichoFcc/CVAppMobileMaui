namespace CVAppMobile.CustomViews;

public partial class SimpleNoHeader : ContentView
{
	public SimpleNoHeader()
	{
		InitializeComponent();
	}

    public View MainContent
    {
        get { return PageContent.Content; }
        set { PageContent.Content = value; }
    }
    public bool Processing
    {
        get { return (bool)GetValue(ProcessingProperty); }
        set { SetValue(ProcessingProperty, value); }
    }
    public static readonly BindableProperty ProcessingProperty = BindableProperty.Create(nameof(Processing), typeof(bool), typeof(SimpleNoHeader), default(bool),
    propertyChanged: (bindable, oldValue, newValue) =>
    {
        var me = (SimpleNoHeader)bindable;
        me.GridLoading.IsVisible = (bool)newValue;
    });

    public string ProcessingMessage
    {
        get { return (string)GetValue(ProcessingMessageProperty); }
        set { SetValue(ProcessingMessageProperty, value); }
    }

    public static readonly BindableProperty ProcessingMessageProperty = BindableProperty.Create(nameof(ProcessingMessage), typeof(string), typeof(SimpleNoHeader), default(string),
    propertyChanged: (bindable, oldValue, newValue) =>
    {
        var me = (SimpleNoHeader)bindable;
        me.LabelProcessing.Text = newValue.ToString();
    });
}