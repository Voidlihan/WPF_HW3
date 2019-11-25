using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProfileWin
{
    public class Service
    {
        private readonly Context context;
        public Service(Context context)
        {

            this.context = context;
        }
        public void Add(User user)
        {
            context.profileUser.Add(user);
            context.SaveChanges();
        }
        public User GetUser(User user)
        {
            user = context.profileUser.SingleOrDefault();
            return user;
        }
        public void UpdateProfile(User userUpdate)
        {
            var user = context.profileUser.SingleOrDefault();

            user.Login = userUpdate.Login;
            user.Password = userUpdate.Password;
            user.ImagePath = userUpdate.ImagePath;
            context.Update(user);
            context.SaveChanges();
        }
        public void UpdateImage(string imagePath)
        {
            var shortQuery = from us in context.profileUser
                             select us;
            var thisUser = shortQuery.First();

            thisUser.ImagePath = imagePath;

            context.Update(thisUser);
            context.SaveChanges();
        }
    }
}
