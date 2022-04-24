using IOCdemo.Models;
using IOCdemo.System;

namespace IOCdemo.Service
{
    public class NewUserService : IUserService
    {
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="user"></param>
        public int CreateUser(User user)
        {
            return user.Id;
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        public void UpdateUser(User user)
        {
            return;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        public void DeleteUser(int id)
        {
            return;
        }

        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUser(int id)
        {
            User user = new User() { Id = 2, Name = "李四", Pwd = "123" };
            return user;
        }

        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public User GetUser(string loginUserName)
        {
            User user = new User() { Id = 2, Name = "李四", Pwd = "123" };
            return user;
        }
    }
}
