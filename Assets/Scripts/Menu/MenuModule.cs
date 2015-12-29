using System;
using Ninject.Modules;

public class MenuModule : NinjectModule
{
    public override void Load()
    {
        Bind<MainContext>().ToSelf().InSingletonScope();
    }
}
