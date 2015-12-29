using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Reward : MonoBehaviour {

    public static Reward Instance;

    public int _currentCoin;
    public int _currentCrystal;
    public float _timeHelper;

    public Text Coin;
    public Text Crystal;
    public Text PlayerName;
    public Text TimeLeft;

    public Text CoinAfter;
    public Text CrystalAfter;
    public GameObject PanelContinue;
    public Transform StartCubSpawn;

    void Start () {
        
        Instance = this;
        Instantiate((GameObject)Resources.Load("Prefabs/" + Singleton.Instance._currentCube), StartCubSpawn.position, Quaternion.identity);
    }

    void Update () {

        Coin.text = "Coin: " + _currentCoin;
        Crystal.text = "Crystal: " + _currentCrystal;
        PlayerName.text = "Player: " + Singleton.Instance.PlayerName;
        TimeLeft.text = _timeHelper.ToString("00");
    }

    public void AdjustCoin(int num)
    {
        _currentCoin += num;
    }

    public void AdjustCrystal(int num)
    {
        _currentCrystal += num;
    }

    public void ResultGame()
    {
        PanelContinue.SetActive(true);
        CoinAfter.text = "Coin: " + _currentCoin;
        CrystalAfter.text = "Crystal: " + _currentCrystal;
    }

    public void OnContinueClick()
    {
        Application.LoadLevel("TestForWindows");
    }
}
