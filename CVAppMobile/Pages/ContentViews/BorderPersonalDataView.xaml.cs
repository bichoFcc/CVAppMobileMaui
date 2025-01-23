namespace CVAppMobile.Pages.ContentViews;

public partial class BorderPersonalDataView : ContentView
{
	public BorderPersonalDataView()
	{
		InitializeComponent();
	}

    public Color BorderColor
    {
        get { return (Color)GetValue(BorderColorProperty); }
        set { SetValue(BorderColorProperty, value); }
    }

    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(BorderPersonalDataView), default(Color),
    propertyChanged: (bindable, oldValue, newValue) =>
    {
        var me = (BorderPersonalDataView)bindable;
        me.MainBorder.BackgroundColor = (Color)newValue;
    });

    public ImageSource BorderImageSource
    {
        get { return (ImageSource)GetValue(BorderImageSourceProperty); }
        set { SetValue(BorderImageSourceProperty, value); }
    }

    public static readonly BindableProperty BorderImageSourceProperty = BindableProperty.Create(nameof(BorderImageSource), typeof(ImageSource), typeof(BorderPersonalDataView), default(ImageSource),
    propertyChanged: (bindable, oldValue, newValue) =>
    {
        var me = (BorderPersonalDataView)bindable;
        me.MainImage.Source = (ImageSource)newValue;
    });

    public string BorderText
    {
        get { return (string)GetValue(BorderTextProperty); }
        set { SetValue(BorderTextProperty, value); }
    }

    public static readonly BindableProperty BorderTextProperty = BindableProperty.Create(nameof(BorderText), typeof(string), typeof(BorderPersonalDataView), default(string),
    propertyChanged: (bindable, oldValue, newValue) =>
    {
        var me = (BorderPersonalDataView)bindable;
        me.MainLabel.Text = newValue.ToString();
    });
}