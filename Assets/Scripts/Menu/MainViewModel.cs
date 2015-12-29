using UnityEngine;
using System.Collections;
using Ninject;
using Ninject.Modules;

public class MainViewModel : MonoBehaviour {

    public NguiDataContext View;
    public static bool flag = false;
    public IKernel _kernel;

    void Awake()
    {
        var settings = new NinjectSettings();
       settings.LoadExtensions = false;
        _kernel = new StandardKernel(settings, new INinjectModule[] { new MenuModule()});

        var mainContext = _kernel.Get<MainContext>();
        View.SetContext(mainContext);
        if (flag)
        {
            mainContext.VisibleMenu();
            mainContext.MenuFooter.VisibleMatchScoreScreen = true;
        }
        else {
            mainContext.GoToEnterPlayerName();
            flag = true;
        }
    }

}
