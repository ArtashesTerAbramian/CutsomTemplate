using Template.DAL;

namespace Template.BLL.Services.ContextModificatorService;

public class ContextModificatorService : IContextModificatorService
{
    public bool IsGlobalQueryFiltersEnable { get; } = true;
}