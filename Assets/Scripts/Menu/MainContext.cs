using UnityEngine;
using System.Collections;
using EZData;
using Ninject;

public class MainContext : Context {

    private static bool _mapDefault = true;
    private static bool _cubDefault = true;
    [Inject]
    public EnterPlayerNameContext EnterPlayerName { get; set; }
    [Inject]
    public HeaderContext Header { get; set; }
    [Inject]
    public BodyContext Body { get; set; }
    [Inject]
    public MenuFooterContext MenuFooter { get; set; }
    [Inject]
    public ChooseCubContext ChooseCub { get; set; }
    [Inject]
    public ChooseCubBodyContext ChooseCubBody { get; set; }
    [Inject]
    public ChooseCubFooterContext ChooseCubFooter { get; set; }
    [Inject]
    public MapStartFooterContext MapStartFooter { get; set; }
    [Inject]
    public MapStartBodyContext MapStartBody { get; set; }
    [Inject]
    public MatchScoreScreenBodyContext MatchScoreScreenBody { get; set; }

    public MainContext()
    {
    }

    public void GoToEnterPlayerName()
    {
        EnterPlayerName.VisiblePlayerName = true;
    }

    public void VisibleMenu()
    {
        EnterPlayerName.VisiblePlayerName = false;
        MenuFooter.VisibleMatchScoreScreen = false;
        Header.VisibleHeader = true;
        Body.VisibleBody = true;
        MenuFooter.VisibleMenuFooter = true;
        Header.PlaeyrName = Singleton.Instance.PlayerName;
        Header.Coin = Singleton.Instance._currentCoin;
        Header.Crystal = Singleton.Instance._currentCrystal;
    }

    public void VisibleChooseCub()
    {
        Body.VisibleBody = false;
        MenuFooter.VisibleMenuFooter = false;
        Header.IsShowButtonBack = true;

        ChooseCub.VisibleChooseCub = true;
        ChooseCubBody.VisibleChooseCubBody = true;

        DefaultCub();

        if (Singleton.Instance._currentCube == "WhiteCube")
            ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedWhiteCube;
        if (Singleton.Instance._currentCube == "GreenCube")
            ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedWhiteCube;
        if (Singleton.Instance._currentCube == "RedCube")
            ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedWhiteCube;
        if (Singleton.Instance._currentCube == "BlueCube")
            ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedWhiteCube;
    }

    public void VisibleMapStartFooter()
    {
        Body.VisibleBody = false;
        MenuFooter.VisibleMenuFooter = false;
        Header.IsShowButtonBack = true;

        MapStartBody.VisibleMapStartBody = true;
        MapStartFooter.VisibleMapStartFooter = true;

        DefaultCub();

        if (_mapDefault)
        {
            MapStartBody.VisibleFirstMap = true;
            Singleton.Instance._chooseMap = "StartGameLevel1";
            _mapDefault = false;
        }
        if(Singleton.Instance._chooseMap == "StartGameLevel1")
            MapStartBody.VisibleFirstMap = true;
        if (Singleton.Instance._chooseMap == "StartGameLevel2")
            MapStartBody.VisibleSecondMap = true;
    }

    public void VisibleMatchScoreScreenBody()
    {
        Body.VisibleBody = false;
        MenuFooter.VisibleMenuFooter = false;
        Header.VisibleHeader = false;

        MatchScoreScreenBody.VisibleMatchScoreScreenBody = true;

        MatchScoreScreenBody.MatchCoin = Reward.Instance._currentCoin;
        MatchScoreScreenBody.MatchCrystal = Reward.Instance._currentCrystal;
        MatchScoreScreenBody.MatchDeath = Singleton.Instance._currentDeath;
        MatchScoreScreenBody.MatchDistance = Singleton.Instance._currentDistance;
    }

    public void HelpOnBackMenuClick()
    {
        EnterPlayerName.VisiblePlayerName = false;
        Header.IsShowButtonBack = false;
        ChooseCub.VisibleChooseCub = false;
        ChooseCubBody.VisibleChooseCubBody = false;
        MapStartFooter.VisibleMapStartFooter = false;
        MapStartBody.VisibleMapStartBody = false;
        MatchScoreScreenBody.VisibleMatchScoreScreenBody = false;

        Body.VisibleBody = true;
        MenuFooter.VisibleMenuFooter = true;
        Header.VisibleHeader = true;
    }

    private void DefaultCub()
    {
        if (_cubDefault)
        {
            Singleton.Instance._currentCube = "WhiteCube";
            ChooseCubBody.CurrentSpeed = Singleton.Instance._currentSpeedWhiteCube;
            Singleton.Instance._currentSpeedCube = Singleton.Instance._currentSpeedWhiteCube;
            _cubDefault = false;
        }
    }
}
