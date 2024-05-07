using LedumCAD.Localization;
using Volo.Abp.Application.Services;

namespace LedumCAD.Services;

/* Inherit your application services from this class. */
public abstract class LedumCADAppService : ApplicationService
{
    protected LedumCADAppService()
    {
        LocalizationResource = typeof(LedumCADResource);
    }
}