using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Clinic_Doctor.BL
{
    class _DOCTOR: DAL.DB
    {
        //**************البحث*******************

        public static DataTable _SELECTE(string serch)
        {
            return EXUTETABLE("select_DOCTOR", CommandType.StoredProcedure,
                createparm("@SERCH", SqlDbType.NVarChar, serch));

        }
        public static DataTable selcet_docter_chose()
        {
            return EXUTETABLE("selcet_docter_chose", CommandType.StoredProcedure
                );

        }
        public static DataTable compo_docter()
        {
            return EXUTETABLE("combo_DOCTOR", CommandType.StoredProcedure);

        }
        public static DataTable compo_paiton()
        {
            return EXUTETABLE("combo_paiton", CommandType.StoredProcedure);

        }
        //***************************اضافة***************************
        public static void _insert(string fullname, DateTime birthdate,string gender ,string @QUALIFIDDOCTOR,string @DATEOFGRADUATION,string @DATEOFAPPOINTTED, string phone, string emile, string notes, DateTime date, string USERNAME)
        {
            EXUTENONEQUARY("edit_DOCTOR", CommandType.StoredProcedure,
           createparm("@ID", SqlDbType.Int, 0),
           createparm("@FULLNAME", SqlDbType.NVarChar, fullname),
           createparm("@BIRTHDATE", SqlDbType.Date, birthdate),
           createparm("@EMILE", SqlDbType.NVarChar, emile),
           createparm("@PHONENUMBER", SqlDbType.NVarChar, phone),
           createparm("@GENDER", SqlDbType.NVarChar, gender),
           createparm("@QUALIFIDDOCTOR", SqlDbType.NVarChar, @QUALIFIDDOCTOR),
           createparm("@DATE", SqlDbType.Date, date),
           createparm("@DATEOFGRADUATION", SqlDbType.NVarChar, @DATEOFGRADUATION),
           createparm("@DATEOFAPPOINTTED", SqlDbType.NVarChar, @DATEOFAPPOINTTED),
           createparm("@CHECK", SqlDbType.Char, 'I'),
           createparm("@USERNAME", SqlDbType.NVarChar, USERNAME),
           createparm("@NOTES", SqlDbType.NVarChar, notes));
           
        }
        //******************************التعديل*********************************
        public static void _update(int id,string fullname, DateTime birthdate,string gender ,string @QUALIFIDDOCTOR, string @DATEOFGRADUATION, string @DATEOFAPPOINTTED, string phone, string emile, string notes, DateTime date, string USERNAME)
        {
            EXUTENONEQUARY("edit_DOCTOR", CommandType.StoredProcedure,
           createparm("@ID", SqlDbType.Int, id),
           createparm("@FULLNAME", SqlDbType.NVarChar, fullname),
           createparm("@BIRTHDATE", SqlDbType.Date, birthdate),
           createparm("@EMILE", SqlDbType.NVarChar, emile),
           createparm("@PHONENUMBER", SqlDbType.NVarChar, phone),
           createparm("@GENDER", SqlDbType.NVarChar,gender ),
           createparm("@QUALIFIDDOCTOR", SqlDbType.NVarChar, @QUALIFIDDOCTOR),
           createparm("@DATE", SqlDbType.Date, date),
           createparm("@DATEOFGRADUATION", SqlDbType.NVarChar, @DATEOFGRADUATION),
           createparm("@DATEOFAPPOINTTED", SqlDbType.NVarChar, @DATEOFAPPOINTTED),
           createparm("@CHECK", SqlDbType.Char, 'U'),
           createparm("@USERNAME", SqlDbType.NVarChar, USERNAME),
           createparm("@NOTES", SqlDbType.NVarChar, notes));
           
        }
    }
}
