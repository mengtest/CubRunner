using EZData;

public class MapStartFooterContext : Context
{
    private readonly MainContext _mainContext;

    public MapStartFooterContext(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    #region Property VisibleMapStartFooter
    private readonly EZData.Property<bool> _privateVisibleMapStartFooterProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleMapStartFooterProperty { get { return _privateVisibleMapStartFooterProperty; } }
    public bool VisibleMapStartFooter
    {
        get { return VisibleMapStartFooterProperty.GetValue(); }
        set { VisibleMapStartFooterProperty.SetValue(value); }
    }
    #endregion

}
