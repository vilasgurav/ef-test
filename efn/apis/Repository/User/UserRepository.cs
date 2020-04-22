using System;
using user = Domain.Layer.User;

namespace Repository
{
    /// <summary>
    /// The user repository class.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        efn_testEntities3 dbContext = new efn_testEntities3();
        /// <summary>
        /// The method to create user.
        /// </summary>
        /// <param name="user">The domain user object.</param>
        /// <returns>Return true or false; true indicates user creation is successful.</returns>
        public bool CreateUser(user.User user)
        {

            dbContext.Users.Add(MapUser(user));
            var result = dbContext.SaveChanges();
            return result > 0 ? true : false;
        }

        private User MapUser(user.User user)
        {
            return new User()
            {
                Name = user.Name,
                Password = user.Password,
                UpdateDate = DateTime.Today,
                CreateDate = DateTime.Today,
                UsersTotalProductQuantity = user.UsersTotalProductQuantity,
                UserName = user.UserName
            };
        }

        /// <summary>
        /// The method to get user.
        /// </summary>
        /// <param name="userId">The user id param.</param>
        /// <returns>Returns the domain user.</returns>
        public user.User GetUser(short userId)
        {
            return new user.User();
        }
    }
}
