using MyContactModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContactDAL
{
    public class GroupService
    {
        public IList<Group> GetGroups()
        {
            string strsql = "SELECT * FROM [Group]";
            DBHelper dBHelper = new DBHelper();
            DataTable groupTable = dBHelper.GetDataTable(strsql);
            List<Group> result = new List<Group>();
            for (int i = 0; i < groupTable.Rows.Count; i++)
            {
                Group group = new Group
                {
                    GroupId = (int)groupTable.Rows[i][0],
                    GroupName = groupTable.Rows[i][1].ToString()
                };
                result.Add(group);
            }
            return result;
        }
        public int Insert(Group group)
        {
            string strsql = "INSERT INTO [GROUP] VALUES(@Groupid,@GroupName)";
            DBHelper dB = new DBHelper();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@GroupName",SqlDbType.NVarChar)
            };
            return dB.ExecuteNonQuery(strsql, parm);
        }

    }
}
