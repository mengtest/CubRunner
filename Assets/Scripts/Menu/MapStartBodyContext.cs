using EZData;

public class MapStartBodyContext : Context
{
    private readonly MainContext _mainContext;

    public MapStartBodyContext(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    #region Property VisibleMapStartBody
    private readonly EZData.Property<bool> _privateVisibleMapStartBodyProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleMapStartBodyProperty { get { return _privateVisibleMapStartBodyProperty; } }
    public bool VisibleMapStartBody
    {
        get { return VisibleMapStartBodyProperty.GetValue(); }
        set { VisibleMapStartBodyProperty.SetValue(value); }
    }
    #endregion

    #region Property VisibleFirstMap
    private readonly EZData.Property<bool> _privateVisibleFirstMapProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleFirstMapProperty { get { return _privateVisibleFirstMapProperty; } }
    public bool VisibleFirstMap
    {
        get { return VisibleFirstMapProperty.GetValue(); }
        set { VisibleFirstMapProperty.SetValue(value); }
    }
    #endregion

    #region Property VisibleSecondMap
    private readonly EZData.Property<bool> _privateVisibleSecondMapProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleSecondMapProperty { get { return _privateVisibleSecondMapProperty; } }
    public bool VisibleSecondMap
    {
        get { return VisibleSecondMapProperty.GetValue(); }
        set { VisibleSecondMapProperty.SetValue(value); }
    }
    #endregion

    public void OnFirstMapClick()
    {
        VisibleFirstMap = true;
        VisibleSecondMap = false;
        Singleton.Instance._chooseMap = "StartGameLevel1";
    }

    public void OnSeconMapClick()
    {
        VisibleFirstMap = false;
        VisibleSecondMap = true;
        Singleton.Instance._chooseMap = "StartGameLevel2";
    }
}
