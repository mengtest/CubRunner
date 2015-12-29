using System;

public class Singleton
{
    private static Singleton instance;

    public string PlayerName;
    public int _currentCoin;
    public int _currentCrystal;
    public int _currentDeath;
    public int _currentDistance;
    public string _chooseMap;
    public int _currentSpeedWhiteCube = 6;
    public int _currentSpeedGreenCube = 6;
    public int _currentSpeedRedCube = 6;
    public int _currentSpeedBlueCube = 6;
    public float _currentSpeedCube = 6.0f;
    public string _currentCube;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }


}
