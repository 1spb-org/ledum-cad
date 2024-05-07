using LedumCAD.Localization;
using Volo.Abp.AspNetCore.Components;

namespace LedumCAD;

public abstract class LedumCADComponentBase : AbpComponentBase
{
    protected LedumCADComponentBase()
    {
        LocalizationResource = typeof(LedumCADResource);
    }
}
