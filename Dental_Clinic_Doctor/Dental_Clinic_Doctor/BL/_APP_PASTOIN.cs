using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Clinic_Doctor.BL
{
    class _APP_PASTOIN : DAL.DB
    {
        //**************البحث*******************

        public static DataTable opp_date_posteve_count(DateTime start,DateTime end)
        {
            return EXUTETABLE("opp_date_posteve_count", CommandType.StoredProcedure,
                createparm("@first", SqlDbType.Date, start),
                createparm("@end", SqlDbType.Date, end)
                );

        }

        public static DataTable APPPASOIN_SELECTE(string serch)
        {
            return EXUTETABLE("select_APP_PASTOIN", CommandType.StoredProcedure,
                createparm("@SERCH", SqlDbType.NVarChar, serch));

        }

        public static DataTable _SELECTE_ss(int id)
        {
            return EXUTETABLE("select * from APP_PASTOIN where ID_PAITIENT=@ID_PAITIENT", CommandType.Text,
                createparm("@ID_PAITIENT", SqlDbType.Int, id));
            
        }

        //////
        public static DataTable _SELECTE_calolater(int id,string bil)
        {
            return EXUTETABLE("edite_update_calclter", CommandType.StoredProcedure,
                createparm("@ID", SqlDbType.Int, id),
                createparm("@BILS", SqlDbType.Int, bil)
                );

        }
        //***************************اضافة***************************
        public static void APPPASOINr_insert(string BILS, DateTime DATE, string USERNAME, int ID_PAITIENT)
        {
            EXUTENONEQUARY("edit_APP_PASTOIN", CommandType.StoredProcedure,
           createparm("@ID", SqlDbType.Int, 0),
           createparm("@BILS", SqlDbType.NVarChar, BILS),
           createparm("@DATE", SqlDbType.Date, DATE),
           createparm("@USERNAME", SqlDbType.NVarChar, USERNAME),
           createparm("@ID_PAITIENT", SqlDbType.Int, ID_PAITIENT),
           createparm("@CHECK", SqlDbType.Char, 'I')
           );

        }
        //******************************التعديل*********************************
        public static void APPPASOINr_update(int ID, string BILS, DateTime DATE, string USERNAME, int ID_PAITIENT)
        {
            EXUTENONEQUARY("edit_APP_PASTOIN", CommandType.StoredProcedure,
          createparm("@ID", SqlDbType.Int, ID),
          createparm("@BILS", SqlDbType.NVarChar, BILS),
          createparm("@DATE", SqlDbType.Date, DATE),
          createparm("@USERNAME", SqlDbType.NVarChar, USERNAME),
          createparm("@ID_PAITIENT", SqlDbType.Int, ID_PAITIENT),
          createparm("@CHECK", SqlDbType.Char, 'U')
          );
        }
        //**********************************الحذف**************************************
        public static void APPPASOINr_DELETE(int ID, DateTime DATE)
        {
            EXUTENONEQUARY("edit_APP_PASTOIN", CommandType.StoredProcedure,
          createparm("@ID", SqlDbType.Int, ID),
          createparm("@BILS", SqlDbType.NVarChar, ""),
          createparm("@DATE", SqlDbType.Date, DATE),
          createparm("@USERNAME", SqlDbType.NVarChar, ""),
          createparm("@ID_PAITIENT", SqlDbType.Int, 0),
          createparm("@CHECK", SqlDbType.Char, 'D')
          );
        }
        ////////////اضافة كمية///////////////////
        public static DataTable zz_SELECTE(int serch)
        {
            return EXUTETABLE("show_Id_paiton", CommandType.StoredProcedure,
                createparm("@ID", SqlDbType.Int, serch));
        }

        //*****************************//
        public static DataTable qualty_SELECTE(int serch)
        {
            return EXUTETABLE("select_qualty", CommandType.StoredProcedure,
                createparm("@SERCH", SqlDbType.Int, serch));

        }

        //***************************اضافة***************************
        public static void qualty_insert(int @id_paiment, string @qualty, string @bayment, string @last, DateTime @date,string @user)
        {
            EXUTENONEQUARY("add_qualty", CommandType.StoredProcedure,
           createparm("@id_paiment", SqlDbType.Int, @id_paiment),
           createparm("@qualty", SqlDbType.NVarChar, @qualty),
           createparm("@bayment", SqlDbType.NVarChar, @bayment),
           createparm("@last", SqlDbType.NVarChar, @last),
           createparm("@date", SqlDbType.DateTime, @date),
           createparm("@user", SqlDbType.NVarChar, @user)
           );

        }

    }
}