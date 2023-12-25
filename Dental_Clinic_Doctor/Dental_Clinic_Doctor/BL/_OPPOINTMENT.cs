using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Clinic_Doctor.BL
{
    class _OPPOINTMENT : DAL.DB
    {
        
        //**************البحث*******************
        public static DataTable APPPASOIN_SELECTE(string serch)
        {
            return EXUTETABLE("select_OPPOINTMENT", CommandType.StoredProcedure,
                createparm("@SERCH", SqlDbType.NVarChar, serch));

        }
        public static DataTable show_name_paiton(int id)
        {
            return EXUTETABLE("SELECT FULLNAME FROM PATIENT WHERE(ID = @id)", CommandType.Text,
                createparm("@id", SqlDbType.Int, id));

        }
        //عرض الصورة
        public static DataTable show_photo(int id)
        {
            return EXUTETABLE("SELECT PHOTO FROM OPPOINTMENT WHERE(ID = @id)", CommandType.Text,
                createparm("@id", SqlDbType.Int, id));

        }

        //عرض بيانات المريض
        public static DataTable _SELECTE_paiton()
        {
            return EXUTETABLE("select * from OPPOINTMENT", CommandType.Text
                );

        }

        //***************************اضافة***************************
        public static void _insert(int id_paitons, int id_doters, string date_app, string time_app, string notes, string app_stuts, string bill, string bill_stuts, string prescription, DateTime date, string username, Byte[] PHOTO,string @chek)
        {
            EXUTENONEQUARY("Edite_OPPOINTMENT", CommandType.StoredProcedure,
           createparm("@ID", SqlDbType.Int, 0),
           createparm("@ID_DOCTOR", SqlDbType.Int, id_doters),
           createparm("@ID_PATIENT", SqlDbType.Int, id_paitons),
           createparm("@DATE_OF_APP", SqlDbType.NVarChar, date_app),
           createparm("@TIME_OF_APP", SqlDbType.NVarChar, time_app),
           createparm("@NOTES", SqlDbType.NVarChar, notes),
           createparm("@APP_STUTS", SqlDbType.NVarChar, app_stuts),
           createparm("@BILL_AMOUT", SqlDbType.NVarChar, bill),
           createparm("@BILL_STUTS", SqlDbType.NVarChar, bill_stuts),
           createparm("@PRESCRIPTION", SqlDbType.NVarChar, prescription),
           createparm("@DATE", SqlDbType.Date, date),
           createparm("@USERNAME", SqlDbType.NVarChar, username),
           createparm("@PHOTO", SqlDbType.Image, PHOTO),

           createparm("@CHECK", SqlDbType.NVarChar, @chek));

            //******************************التعديل*********************************
        }
        public static void _update(int id, int id_paitons, int id_doters, string date_app, string time_app, string notes, string app_stuts, string bill, string bill_stuts, string prescription, DateTime date, string username, Byte[] PHOTO,string @chek)
        {
            EXUTENONEQUARY("Edite_OPPOINTMENT_TT", CommandType.StoredProcedure,
           createparm("@ID", SqlDbType.Int, id),
           createparm("@ID_DOCTOR", SqlDbType.Int, id_doters),
           createparm("@ID_PATIENT", SqlDbType.Int, id_paitons),
           createparm("@DATE_OF_APP", SqlDbType.NVarChar, date_app),
           createparm("@TIME_OF_APP", SqlDbType.NVarChar, time_app),
           createparm("@NOTES", SqlDbType.NVarChar, notes),
           createparm("@APP_STUTS", SqlDbType.NVarChar, app_stuts),
           createparm("@BILL_AMOUT", SqlDbType.NVarChar, bill),
           createparm("@BILL_STUTS", SqlDbType.NVarChar, bill_stuts),
           createparm("@PRESCRIPTION", SqlDbType.NVarChar, prescription),
           createparm("@DATE", SqlDbType.Date, date),
           createparm("@USERNAME", SqlDbType.NVarChar, username),
           createparm("@PHOTO", SqlDbType.Image, PHOTO),
           createparm("@CHECK", SqlDbType.Char, @chek)
           );

        }

        public static void _delete(int id)
        {
            EXUTENONEQUARY("delete_OPPOINTMENT", CommandType.StoredProcedure,
           createparm("@ID", SqlDbType.Int, id),
           createparm("@ID_DOCTOR", SqlDbType.Int, 0),
           createparm("@ID_PATIENT", SqlDbType.Int, 0),
           createparm("@DATE_OF_APP", SqlDbType.NVarChar, ""),
           createparm("@TIME_OF_APP", SqlDbType.NVarChar, ""),
           createparm("@NOTES", SqlDbType.NVarChar, ""),
           createparm("@APP_STUTS", SqlDbType.NVarChar, ""),
           createparm("@BILL_AMOUT", SqlDbType.NVarChar, ""),
           createparm("@BILL_STUTS", SqlDbType.NVarChar, ""),
           createparm("@PRESCRIPTION", SqlDbType.NVarChar, ""),
           createparm("@DATE", SqlDbType.Date, Convert.ToDateTime("1/1/2001")),
           
           createparm("@USERNAME", SqlDbType.NVarChar, ""),
           createparm("@CHECK", SqlDbType.Char, 'D')
           );

        }

        public static void _update_bill(int id, string bill)
        {
            EXUTENONEQUARY("edite_update_bill", CommandType.StoredProcedure,
           createparm("@ID_PAITIENT", SqlDbType.Int, id),
           createparm("@BILS", SqlDbType.NVarChar, bill));
        }
    }
}