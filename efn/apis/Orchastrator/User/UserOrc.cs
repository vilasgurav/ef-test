using Repository;
using product = Domain.Layer.Product;

namespace Orchastrator.User
{
    public class UserOrc : IUserOrc
    {
        IUserRepository userRep;

        /// <summary>
        /// The create user method.
        /// </summary>
        /// <param name="user">The user domain object</param>
        /// <returns>True or false; if true then user is created successfully.</returns>
        public bool CreateUser(Domain.Layer.User.User user)
        {
            userRep = new UserRepository();
            return userRep.CreateUser(user);
        }

        /// <summary>
        /// The get user method.
        /// </summary>
        /// <param name="userId"> The user id.</param>
        /// <returns>The user object.</returns>
        public Domain.Layer.User.User GetUser(short userId)
        {
            userRep = new UserRepository();
            return userRep.GetUser(userId);
        }
    }
}
