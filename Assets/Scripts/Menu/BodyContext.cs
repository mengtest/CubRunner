using EZData;

public class BodyContext : Context
{
    private readonly MainContext _mainContext;

    public BodyContext(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    #region Property VisibleBody
    private readonly EZData.Property<bool> _privateVisibleBodyProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleBodyProperty { get { return _privateVisibleBodyProperty; } }
    public bool VisibleBody
    {
        get { return VisibleBodyProperty.GetValue(); }
        set { VisibleBodyProperty.SetValue(value); }
    }
    #endregion

}
