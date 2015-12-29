using EZData;
using Ninject;
using UnityEngine;

public class MenuFooterContext : Context
{
    readonly MainContext _mainContext;

    public MenuFooterContext(MainContext mainContext)
    {
        Debug.Log("Visible = footer");
        _mainContext = mainContext;
    }

    #region Property VisibleMenuFooter
    private readonly EZData.Property<bool> _privateVisibleMenuFooterProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleMenuFooterProperty { get { return _privateVisibleMenuFooterProperty; } }

    public bool VisibleMenuFooter
    {
        get { return VisibleMenuFooterProperty.GetValue(); }
        set { VisibleMenuFooterProperty.SetValue(value); }
    }
    #endregion

    #region Property VisibleMatchScoreScreen
    private readonly EZData.Property<bool> _privateVisibleMatchScoreScreenProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleMatchScoreScreenProperty { get { return _privateVisibleMatchScoreScreenProperty; } }

    public bool VisibleMatchScoreScreen
    {
        get { return VisibleMatchScoreScreenProperty.GetValue(); }
        set { VisibleMatchScoreScreenProperty.SetValue(value); }
    }
    #endregion

    public void OnChooseCubClick()
    {
        _mainContext.VisibleChooseCub();
    }

    public void OnMapAndStartClick()
    {
        _mainContext.VisibleMapStartFooter();
    }

}
