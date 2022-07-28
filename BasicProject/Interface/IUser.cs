using BasicProject.Models;
using System.Threading.Tasks;

namespace BasicProject.Interface
{
    public interface IUser
    {
        Task<string> createUser(UserModel user);
    }
}