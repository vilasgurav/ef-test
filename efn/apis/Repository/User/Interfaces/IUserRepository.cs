using user = Domain.Layer.User;

namespace Repository
{
    public interface IUserRepository
    {
        /// <summary>
        /// The method to create user.
        /// </summary>
        /// <param name="user">The domain user object.</param>
        /// <returns>Return true or false; true indicates user creation is successful.</returns>
        bool CreateUser(user.User user);

        /// <summary>
        /// The method to get user.
        /// </summary>
        /// <param name="userId">The user id param.</param>
        /// <returns>Returns the domain user.</returns>
        user.User GetUser(short userId);
    }
}
