using MyContactDAL;
using MyContactModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContactBLL
{
   public class GroupManager
    {
        private GroupService groupSeervice = new GroupService();

        public IList<Group> GetGroups()
        {
            return groupSeervice.GetGroups();
        }
        public int Insert(Group group)
        {
            return groupSeervice.Insert(group);
        }
    }
}
