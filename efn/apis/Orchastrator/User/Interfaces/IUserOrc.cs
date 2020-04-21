using user = Domain.Layer.User;

namespace Orchastrator.User
{
    /// <summary>
    /// The user orchastrator interface.
    /// </summary>
    public interface IUserOrc
    {
        /// <summary>
        /// The create user method.
        /// </summary>
        /// <param name="user">The user domain object</param>
        /// <returns>True or false; if true then user is created successfully.</returns>
        bool CreateUser(user.User user);

        /// <summary>
        /// The get user method.
        /// </summary>
        /// <param name="userId"> The user id.</param>
        /// <returns>The user object.</returns>
        user.User GetUser(short userId);
    }
}
