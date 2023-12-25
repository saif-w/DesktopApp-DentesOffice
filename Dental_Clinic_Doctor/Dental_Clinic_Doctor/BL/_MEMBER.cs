using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Clinic_Doctor.BL
{
    class _MEMBER:DAL.DB
    {



        public static DataTable member_login(string user,string pass)
        {
            return EXUTETABLE("select USERNAME,PASSWORD from MEMBER where USERNAME=@USERNAME and PASSWORD=@PASSWORD", CommandType.Text,
                createparm("@USERNAME", SqlDbType.NVarChar, user), createparm("@PASSWORD", SqlDbType.NVarChar, pass));

        }
        public static DataTable member_login_update(string user)
        {
            return EXUTETABLE("select USERNAME from MEMBER where USERNAME=@USERNAME", CommandType.Text,
                createparm("@USERNAME", SqlDbType.NVarChar, user));

        }


        //**************البحث*******************
        public static DataTable member_SELECTE(string serch)
        {
            return EXUTETABLE("select_MEMBER", CommandType.StoredProcedure,
                createparm("@SERCH", SqlDbType.NVarChar, serch));

        }
        public static DataTable member_update_00(string username,string pass)
        {
            return EXUTETABLE("UPDATE MEMBER SET  PASSWORD = @PASSWORD  WHERE USERNAME = @USERNAME", CommandType.Text,
                createparm("@USERNAME", SqlDbType.NVarChar, username), createparm("@PASSWORD", SqlDbType.NVarChar, pass));

        }

        


        //***************************اضافة***************************
        public static void member_insert(string USERNAME, string PASSWORD, string FULLNAME, DateTime BIRTHDATE, string PHONENUMBER, string GENDER,string emile ,string NOTES)
        {
            EXUTENONEQUARY("edit_MEMBER", CommandType.StoredProcedure,
           createparm("@USERNAME", SqlDbType.NVarChar, USERNAME),
           createparm("@PASSWORD", SqlDbType.NVarChar, PASSWORD),
           createparm("@FULLNAME", SqlDbType.NVarChar, FULLNAME), createparm("@EMAIL", SqlDbType.NVarChar,emile),
           createparm("@BIRTHDATE", SqlDbType.Date, BIRTHDATE),
           createparm("@PHONENUMBER", SqlDbType.NVarChar, PHONENUMBER),
           createparm("@CHECK", SqlDbType.Char, 'I'),
           createparm("@GENDER", SqlDbType.NVarChar, GENDER),
           createparm("@NOTES", SqlDbType.NVarChar, NOTES),
           createparm("@TYPE", SqlDbType.NVarChar, "USERS"));

        }
        //******************************التعديل*********************************
        public static void member_UPDATE(string USERNAME, string PASSWORD, string FULLNAME, DateTime BIRTHDATE, string PHONENUMBER, string GENDER, string NOTES,string emile ,string TYPE)
        {
            EXUTENONEQUARY("edit_MEMBER", CommandType.StoredProcedure,
           createparm("@USERNAME", SqlDbType.NVarChar, USERNAME),
           createparm("@PASSWORD", SqlDbType.NVarChar, PASSWORD),
           createparm("@FULLNAME", SqlDbType.NVarChar, FULLNAME), createparm("@EMAIL", SqlDbType.NVarChar, emile),
           createparm("@BIRTHDATE", SqlDbType.Date, BIRTHDATE),
           createparm("@PHONENUMBER", SqlDbType.NVarChar, PHONENUMBER),
           createparm("@CHECK", SqlDbType.Char, 'U'),
           createparm("@GENDER", SqlDbType.NVarChar, GENDER),
           createparm("@NOTES", SqlDbType.NVarChar, NOTES),
           createparm("@TYPE", SqlDbType.NVarChar, TYPE));

        }
        //**********************************الحذف**************************************
        public static void member_DELETE(string USERNAME, DateTime Date)
        {
            EXUTENONEQUARY("edit_MEMBER", CommandType.StoredProcedure,
           createparm("@USERNAME", SqlDbType.NVarChar, USERNAME),
           createparm("@PASSWORD", SqlDbType.NVarChar, ""),
           createparm("@FULLNAME", SqlDbType.NVarChar, ""),
           createparm("@BIRTHDATE", SqlDbType.Date, Date), createparm("@EMAIL", SqlDbType.NVarChar, ""),
           createparm("@PHONENUMBER", SqlDbType.NVarChar, ""),
           createparm("@CHECK", SqlDbType.Char, 'D'),
           createparm("@GENDER", SqlDbType.NVarChar, ""),
           createparm("@NOTES", SqlDbType.NVarChar, ""),
           createparm("@TYPE", SqlDbType.NVarChar, ""));

        }
    }
}
