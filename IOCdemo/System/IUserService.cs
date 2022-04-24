using IOCdemo.Models;

namespace IOCdemo.System
{
    public interface IUserService
    {
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns>用户Id</returns>
        int CreateUser(User user);

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        void UpdateUser(User user);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        void DeleteUser(int id);

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User GetUser(int id);

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="loginUserName"></param>
        /// <returns></returns>
        User GetUser(string loginUserName);

        /// <summary>
        /// 获取组织机构下的用户
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        //IEnumerable<User> GetUsers(int deptId);
    }
}
