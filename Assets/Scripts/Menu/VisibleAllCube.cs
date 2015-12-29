using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VisibleAllCube : MonoBehaviour {

    public GameObject[] Cubes;
    private static GameObject ChooseCube;

    public void OnVisibleWhiteCub()
    {
        HelpCubChoose(0);
    }

    public void OnVisibleGreenCub()
    {
        HelpCubChoose(1);
    }
    public void OnVisibleRedCub()
    {
        HelpCubChoose(2);
    }
    public void OnVisibleBlueCub()
    {
        HelpCubChoose(3);
    }

    public void OnVisibleDefaultOrLastCub()
    {
        if (Singleton.Instance._currentCube == "WhiteCube")
            HelpCubChoose(0);
        else if (Singleton.Instance._currentCube == "GreenCube")
            HelpCubChoose(1);
        else if (Singleton.Instance._currentCube == "RedCube")
            HelpCubChoose(2);
        else if (Singleton.Instance._currentCube == "BlueCube")
            HelpCubChoose(3);
        else
            HelpCubChoose(0);
    }

    private void HelpCubChoose(int choose)
    {
        if (ChooseCube)
            ChooseCube.SetActive(false);

        Cubes[choose].SetActive(true);
        ChooseCube = Cubes[choose];
    }

    public void OnVisibleLastCubeClick()
    {
        if(ChooseCube)
            ChooseCube.SetActive(false);
    }
}
