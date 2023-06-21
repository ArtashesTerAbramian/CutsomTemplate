using Template.DTO;

namespace Template.BLL.Services.ErrorService;
public interface IErrorService
{
    Task<ErrorModelDto> GetById(long id);
}