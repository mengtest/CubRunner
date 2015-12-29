using EZData;

public class MatchScoreScreenBodyContext : Context
{
    private readonly MainContext _mainContext;

    public MatchScoreScreenBodyContext(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    #region Property VisibleMatchScoreScreenBody
    private readonly EZData.Property<bool> _privateVisibleMatchScoreScreenBodyProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleMatchScoreScreenBodyProperty { get { return _privateVisibleMatchScoreScreenBodyProperty; } }
    public bool VisibleMatchScoreScreenBody
    {
        get { return VisibleMatchScoreScreenBodyProperty.GetValue(); }
        set { VisibleMatchScoreScreenBodyProperty.SetValue(value); }
    }
    #endregion

    #region Property MatchCoin
    private readonly EZData.Property<int> _privateMatchCoinProperty = new EZData.Property<int>();
    public EZData.Property<int> MatchCoinProperty { get { return _privateMatchCoinProperty; } }
    public int MatchCoin
    {
        get { return MatchCoinProperty.GetValue(); }
        set { MatchCoinProperty.SetValue(value); }
    }
    #endregion

    #region Property MatchCrystal
    private readonly EZData.Property<int> _privateMatchCrystalProperty = new EZData.Property<int>();
    public EZData.Property<int> MatchCrystalProperty { get { return _privateMatchCrystalProperty; } }
    public int MatchCrystal
    {
        get { return MatchCrystalProperty.GetValue(); }
        set { MatchCrystalProperty.SetValue(value); }
    }
    #endregion

    #region Property MatchDeath
    private readonly EZData.Property<int> _privateMatchDeathProperty = new EZData.Property<int>();
    public EZData.Property<int> MatchDeathProperty { get { return _privateMatchDeathProperty; } }
    public int MatchDeath
    {
        get { return MatchDeathProperty.GetValue(); }
        set { MatchDeathProperty.SetValue(value); }
    }
    #endregion

    #region Property MatchDistance
    private readonly EZData.Property<int> _privateMatchDistanceProperty = new EZData.Property<int>();
    public EZData.Property<int> MatchDistanceProperty { get { return _privateMatchDistanceProperty; } }
    public int MatchDistance
    {
        get { return MatchDistanceProperty.GetValue(); }
        set { MatchDistanceProperty.SetValue(value); }
    }
    #endregion

    public void OnMatchScoreScreenBodyClick()
    {
        _mainContext.VisibleMatchScoreScreenBody();
    }
}
