using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace DAL
{
    public class LoginDAL
    {
        public static Personal_Information_vo_ Login()
        {
            using(projectEntities db=new projectEntities())
            {

                var mit = db.Personal_Information_vo_.FirstOrDefault();
                if (mit != null)
                {
                    return mit ;
                }
                else
                    return null;
            }
            //return userName + " hello";
        }
    }
}
