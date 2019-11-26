using System.Threading.Tasks;
using DocumentProcessing.Srk.ViewModels.Roles;

namespace DocumentProcessing.Srk.Mappers
{
    public interface IUserRolesMapper
    {
        Task<EditRoleViewModel> GetEditRoleViewModel(string userId);
    }
}