using System.Threading.Tasks;
using DocumentProcessing.Crk.ViewModels.Roles;

namespace DocumentProcessing.Crk.Mappers
{
    public interface IUserRolesMapper
    {
        Task<EditRoleViewModel> GetEditRoleViewModel(string userId);
    }
}