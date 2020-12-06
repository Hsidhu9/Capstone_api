using Shift_Picker_Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shift_Picker_Api.Services
{
    /// <summary>
    /// Abstraction of User Service
    /// </summary>
    public interface IUserService
    {
        void ActivateUser(UserModel userModel);
        void AddUser(UserModel user);
        void DeactivateUser(UserModel userModel);
        Task<List<UserModel>> GetAllEmployees();
        Task<UserModel> GetUserByUsername(string username);
        Task<List<UserModel>> GetAllSupervisors();

        Task<List<UserModel>> GetAllManagers();
        Task<UserModel> GetUser(int Id);
        Task<UserModel> GetUserByIdAsync(int Id);
        void UpdateUser(UserModel user);
        UserModel GetUserById(int Id);
    }
}