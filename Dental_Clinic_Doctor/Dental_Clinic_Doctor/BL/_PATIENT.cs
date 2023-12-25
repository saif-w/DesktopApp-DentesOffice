using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Clinic_Doctor.BL
{
    class _PATIENT:DAL.DB
    {
        public static DataTable compo_docter()
        {
            return EXUTETABLE("combo_DOCTOR", CommandType.StoredProcedure);

        }
        public static DataTable compo_paiton()
        {
            return EXUTETABLE("combo_paiton", CommandType.StoredProcedure);

        }

        //**************البحث*******************
        public static DataTable selcet_PATIENT_chose()
        {
            return EXUTETABLE("selcet_PATIENT_chose", CommandType.StoredProcedure
                );

        }


        public static DataTable _SELECTE(string serch)
        {
            return EXUTETABLE("selcet_PATIENT", CommandType.StoredProcedure,
                createparm("@SERCH", SqlDbType.NVarChar, serch));

        }

        //***************************اضافة***************************
        public static void _insert(string fullname,DateTime birthdate,string phone,string emile,string adress,string notes,DateTime date ,string USERNAME)
        {
            EXUTENONEQUARY("edit_PATIENT", CommandType.StoredProcedure,
           createparm("@ID", SqlDbType.Int, 0),
           createparm("@FULLNAME", SqlDbType.NVarChar, fullname),
           createparm("@BIRTHDATE", SqlDbType.Date, birthdate),
           createparm("@EMILE", SqlDbType.NVarChar, emile),
           createparm("@DATE", SqlDbType.Date, date),
           createparm("@PHONENUMBERS", SqlDbType.NVarChar, phone),
           createparm("@CHECK", SqlDbType.Char, 'I'),
           createparm("@USEERNAME", SqlDbType.NVarChar, USERNAME),
           createparm("@NOTES", SqlDbType.NVarChar, notes),
           createparm("@ADRESS", SqlDbType.NVarChar, adress));
        }
        //******************************التعديل*********************************
        public static void _update(int id,string fullname, DateTime birthdate, string phone, string emile, string adress, string notes, DateTime date, string USERNAME)
        {
            EXUTENONEQUARY("edit_PATIENT", CommandType.StoredProcedure,
           createparm("@ID", SqlDbType.Int, id),
           createparm("@FULLNAME", SqlDbType.NVarChar, fullname),
           createparm("@BIRTHDATE", SqlDbType.Date, birthdate),
           createparm("@EMILE", SqlDbType.NVarChar, emile),
           createparm("@DATE", SqlDbType.Date, date),
           createparm("@PHONENUMBERS", SqlDbType.NVarChar, phone),
           createparm("@CHECK", SqlDbType.Char, 'U'),
           createparm("@USEERNAME", SqlDbType.NVarChar, USERNAME),
           createparm("@NOTES", SqlDbType.NVarChar, notes),
           createparm("@ADRESS", SqlDbType.NVarChar, adress));
        }
        //**********************************الحذف**************************************
        public static void _delete(int id, DateTime birthdate, DateTime date)
        {
            EXUTENONEQUARY("edit_PATIENT", CommandType.StoredProcedure,
           createparm("@ID", SqlDbType.Int, id),
           createparm("@FULLNAME", SqlDbType.NVarChar, ""),
           createparm("@BIRTHDATE", SqlDbType.NVarChar, birthdate),
           createparm("@EMILE", SqlDbType.NVarChar, ""),
           createparm("@DATE", SqlDbType.Date, date),
           createparm("@PHONENUMBERS", SqlDbType.NVarChar, ""),
           createparm("@CHECK", SqlDbType.Char, 'd'),
           createparm("@USEERNAME", SqlDbType.NVarChar, ""),
           createparm("@NOTES", SqlDbType.NVarChar, ""),
           createparm("@ADRESS", SqlDbType.NVarChar, ""));
        }
    }
}
