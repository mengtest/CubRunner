using UnityEngine;
using System.Collections;
using EZData;

public class ChooseCubBodyContext : Context
{
    private readonly MainContext _mainContext;

    public ChooseCubBodyContext(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    #region Property VisibleChooseCubBody
    private readonly EZData.Property<bool> _privateVisibleChooseCubBodyProperty = new EZData.Property<bool>();
    public EZData.Property<bool> VisibleChooseCubBodyProperty { get { return _privateVisibleChooseCubBodyProperty; } }
    public bool VisibleChooseCubBody
    {
        get { return VisibleChooseCubBodyProperty.GetValue(); }
        set { VisibleChooseCubBodyProperty.SetValue(value); }
    }
    #endregion

    #region Property CurrentSpeed
    private readonly EZData.Property<int> _privateCurrentSpeedProperty = new EZData.Property<int>();
    public EZData.Property<int> CurrentSpeedProperty { get { return _privateCurrentSpeedProperty; } }
    public int CurrentSpeed
    {
        get { return CurrentSpeedProperty.GetValue(); }
        set { CurrentSpeedProperty.SetValue(value); }
    }
    #endregion

    public void OnUpgradeSpeedClick()
    {
        if (Singleton.Instance._currentCube == "WhiteCube")
        {
            Singleton.Instance._currentSpeedWhiteCube += 1;
            _mainContext.ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedWhiteCube;
        }
        if (Singleton.Instance._currentCube == "GreenCube")
        {
            Singleton.Instance._currentSpeedGreenCube += 1;
            _mainContext.ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedGreenCube;
        }
        if (Singleton.Instance._currentCube == "RedCube")
        {
            Singleton.Instance._currentSpeedRedCube += 1;
            _mainContext.ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedRedCube;
        }
        if (Singleton.Instance._currentCube == "BlueCube")
        {
            Singleton.Instance._currentSpeedBlueCube += 1;
            _mainContext.ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedBlueCube;
        }
    }

}
