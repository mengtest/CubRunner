using EZData;

public class HeaderContext : Context
{
    private readonly MainContext _mainContext;

    public HeaderContext(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    #region Property PlaeyrName
    private readonly EZData.Property<string> _privatePlaeyrNameProperty = new EZData.Property<string>();
    public EZData.Property<string> PlaeyrNameProperty { get { return _privatePlaeyrNameProperty; } }
    public string PlaeyrName
    {
        get { return PlaeyrNameProperty.GetValue(); }
        set { PlaeyrNameProperty.SetValue(value); }
    }
    #endregion

    #region Property Coin
    private readonly EZData.Property<int> _privateCoinProperty = new EZData.Property<int>();
    public EZData.Property<int> CoinProperty { get { return _privateCoinProperty; } }
    public int Coin
    {
        get { return CoinProperty.GetValue(); }
        set { CoinProperty.SetValue(value); }
    }
    #endregion

    #region Property Crystal
    private readonly EZData.Property<int> _privateCrystalProperty = new EZData.Property<int>();
    public EZData.Property<int> CrystalProperty { get { return _privateCrystalProperty; } }
    public int Crystal
    {
        get { return CrystalProperty.GetValue(); }
        set { CrystalProperty.SetValue(value); }
    }
    #endregion

    #region Property IsShowButtonBack
    private readonly EZData.Property<bool> _privateIsShowButtonBackProperty = new EZData.Property<bool>();
    public EZData.Property<bool> IsShowButtonBackProperty { get { return _privateIsShowButtonBackProperty; } }
    public bool IsShowButtonBack
    {
        get { return IsShowButtonBackProperty.GetValue(); }
        set { IsShowButtonBackProperty.SetValue(value); }
    }
    #endregion

    #region Property VisibleHeader
    private readonly EZData.Property<bool> _privateVisibleHeaderProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleHeaderProperty { get { return _privateVisibleHeaderProperty; } }
    public bool VisibleHeader
    {
        get { return VisibleHeaderProperty.GetValue(); }
        set { VisibleHeaderProperty.SetValue(value); }
    }
    #endregion

    public void OnBackMenuClick()
    {
        _mainContext.HelpOnBackMenuClick();
    }
}
