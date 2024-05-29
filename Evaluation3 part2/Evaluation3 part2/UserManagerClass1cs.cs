using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation3_part2
{
   public static class UserManagerClass1cs
    {
        public delegate void  Even(string s1,string s2,string s3,string s4);
        public static  event Even EEvents;
        public static List<UserDetailsClass> list = new List<UserDetailsClass>();
        public static event Even DEvents;

        public static void AddDetails(UserDetailsClass userDetails)
        {
            list.Add(userDetails);
            EEvents?.Invoke(userDetails.Names, userDetails.Username, userDetails.Password, userDetails.UserLevell+"");
        }
        public static void Delete(string username)
        {
            for(int i=0;i<list.Count;i++)
            {
                if(list[i].Username==username)
                {
                    DEvents?.Invoke(list[i].Names,list[i].Username,list[i].Password,list[i].UserLevell+"");
                    list.RemoveAt(i);
                }
            }
           
        }
        public static void  Update(string username,string name,string password)
        {
            foreach (var item in list)
            {
                if (item.Username == name)
                {
                    item.Names = name;
                    item.Password = password;
                }
            }
        }
    }
}
