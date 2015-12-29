using UnityEngine;
using System.Collections;
using System;
using EZData;

public class EnterPlayerNameContext
{
    private readonly MainContext _mainContext;

    public EnterPlayerNameContext(MainContext mainContext)
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

    #region Property VisiblePlayerName
    private readonly EZData.Property<bool> _privateVisiblePlayerNameProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisiblePlayerNameProperty { get { return _privateVisiblePlayerNameProperty; } }
    public bool VisiblePlayerName
    {
        get { return VisiblePlayerNameProperty.GetValue(); }
        set { VisiblePlayerNameProperty.SetValue(value); }
    }
    #endregion

    public void OnSubmitClick()
    {
            Singleton.Instance.PlayerName = PlaeyrName;
            _mainContext.Header.IsShowButtonBack = false;
            _mainContext.VisibleMenu();
    }
}
