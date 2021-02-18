using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class LoginBL
    {
        LoginDAL dbLogin;
        public LoginBL(LoginDAL loginDAL)
        {
            dbLogin = loginDAL;
        }
        public static Personal_Information_voEntity Login()
        {
            return Personal_Information_voEntity.ConvertPersonal_Information_voTableToPersonal_Information_voEntity( DAL.LoginDAL.Login());
        }
    }
}