namespace CVAppMobile.CustomViews;

public partial class SimpleHeader : ContentView
{
    public SimpleHeader()
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
    public static readonly BindableProperty ProcessingProperty = BindableProperty.Create(nameof(Processing), typeof(bool), typeof(SimpleHeader), default(bool),
    propertyChanged: (bindable, oldValue, newValue) =>
    {
        var me = (SimpleHeader)bindable;
        me.GridLoading.IsVisible = (bool)newValue;
    });

    public string ProcessingMessage
    {
        get { return (string)GetValue(ProcessingMessageProperty); }
        set { SetValue(ProcessingMessageProperty, value); }
    }

    public static readonly BindableProperty ProcessingMessageProperty = BindableProperty.Create(nameof(ProcessingMessage), typeof(string), typeof(SimpleHeader), default(string),
    propertyChanged: (bindable, oldValue, newValue) =>
    {
        var me = (SimpleHeader)bindable;
        me.LabelProcessing.Text = newValue.ToString();
    });

    public bool ShowFlag
    {
        get { return (bool)GetValue(ShowFlagProperty); }
        set { SetValue(ShowFlagProperty, value); }
    }

    public static readonly BindableProperty ShowFlagProperty = BindableProperty.Create(nameof(ShowFlag), typeof(bool), typeof(SimpleHeader), default(bool),
    propertyChanged: (bindable, oldValue, newValue) =>
    {
        var me = (SimpleHeader)bindable;
        me.Flag.IsVisible = (bool)newValue;
    });
}