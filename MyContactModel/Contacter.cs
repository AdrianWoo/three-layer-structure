using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyContactModel
{
  public  class Contacter
    {
        private int id;
        private string nickName;
        private string passWord;
        private string realName;
        private string phone;
        private string mobile;
        private string email;
        private string qQ;
        private int gruop;
        private Image photo;
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get => nickName; set => nickName = value; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get => passWord; set => passWord = value; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get => realName; set => realName = value; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Phone { get => phone; set => phone = value; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get => mobile; set => mobile = value; }
        /// <summary>
        /// 电子邮件
        /// </summary>
        public string Email { get => email; set => email = value; }
        /// <summary>
        /// QQ号码
        /// </summary>
        public string QQ { get => qQ; set => qQ = value; }
        /// <summary>
        /// 组
        /// </summary>
        public int Gruop { get => gruop; set => gruop = value; }
        /// <summary>
        /// 照片
        /// </summary>
        public Image Photo { get => photo; set => photo = value; }
    }
}
