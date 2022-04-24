using IOCdemo.Models;
using IOCdemo.Service;
using IOCdemo.System;

namespace IOCdemo.BLL
{
    public class UserBLL
    {
        private IUserService userService;

        public UserBLL(IUserService _userService)
        {
            this.userService = _userService;//通过在类的构造中注入，就不用每次用到接口就去选择实现，但如果想用NewUserService中的方法呢？每一个用到IUserService接口的类(xxxBLL..)都去改吗?所以现在体现出依赖注入框架的便捷性
        }

        public int CreateUser(User user)
        {
            IUserService userService = new UserService();//如果想用NewUserService中的方法呢？每一个用到IUserService接口的方法都去改吗?所以在构造函数注入，在类的内部就不用每次调用服务都去选择实现。
            userService.CreateUser(user);
            return user.Id;
        }

        //更新用户信息
        public void UpdateUser(User user)
        {
            userService.UpdateUser(user);//在构造函数注入后，就不用再去选择实现了
        }

        //获取用户信息
        public User GetUser(int id)
        {
            return userService.GetUser(id);
        }
    }
}
