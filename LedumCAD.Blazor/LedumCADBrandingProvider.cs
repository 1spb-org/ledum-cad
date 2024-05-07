using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LedumCAD;

[Dependency(ReplaceServices = true)]
public class LedumCADBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LedumCAD";
}
