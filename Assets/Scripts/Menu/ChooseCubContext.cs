using EZData;

public class ChooseCubContext : Context {

    private readonly MainContext _mainContext;

    public ChooseCubContext(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    #region Property VisibleChooseCub
    private readonly EZData.Property<bool> _privateVisibleChooseCubProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleChooseCubProperty { get { return _privateVisibleChooseCubProperty; } }
    public bool VisibleChooseCub
    {
        get { return VisibleChooseCubProperty.GetValue(); }
        set { VisibleChooseCubProperty.SetValue(value); }
    }
    #endregion

    #region Property VisibleWhiteCub
    private readonly EZData.Property<bool> _privateVisibleWhiteCubProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleWhiteCubProperty { get { return _privateVisibleWhiteCubProperty; } }
    public bool VisibleWhiteCub
    {
        get { return VisibleWhiteCubProperty.GetValue(); }
        set { VisibleWhiteCubProperty.SetValue(value); }
    }
    #endregion

}
