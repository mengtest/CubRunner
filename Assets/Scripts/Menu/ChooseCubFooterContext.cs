using UnityEngine;
using System.Collections;
using EZData;

public class ChooseCubFooterContext : Context
{
    private readonly MainContext _mainContext;

    public ChooseCubFooterContext(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    public void OnWhiteCubeClick()
    {
        Singleton.Instance._currentCube = "WhiteCube";
        _mainContext.ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedWhiteCube;
        Singleton.Instance._currentSpeedCube = Singleton.Instance._currentSpeedWhiteCube;
    }

    public void OnGreenCubeClick()
    {
        Singleton.Instance._currentCube = "GreenCube";
        _mainContext.ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedGreenCube;
        Singleton.Instance._currentSpeedCube = Singleton.Instance._currentSpeedGreenCube;
    }

    public void OnRedCubeClick()
    {
        Singleton.Instance._currentCube = "RedCube";
        _mainContext.ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedRedCube;
        Singleton.Instance._currentSpeedCube = Singleton.Instance._currentSpeedRedCube;
    }

    public void OnBlueCubeClick()
    {
        Singleton.Instance._currentCube = "BlueCube";
        _mainContext.ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedBlueCube;
        Singleton.Instance._currentSpeedCube = Singleton.Instance._currentSpeedBlueCube;
    }
}
