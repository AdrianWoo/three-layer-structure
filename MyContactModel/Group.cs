using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContactModel
{
    public class Group
    {
        private int groupId;
        private string groupName;
        /// <summary>
        /// 组名称
        /// </summary>
        public string GroupName { get => groupName; set => groupName = value; }
        /// <summary>
        /// 组ID
        /// </summary>
        public int GroupId { get => groupId; set => groupId = value; }
    }
}
