using Kotches.Data_Acess_Layer_Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Kotches.Data_Acess_Layer
{
    class BillDaoImp : BillDao
    {

        void BillDao.addBill(int bill_Id, int customer_Id, int user_Id, int product_Id, int qantity, float unitPrice, float SubTotal)
        {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@bill_Id", SqlDbType.Int);
            param[0].Value = bill_Id;

            param[1] = new SqlParameter("@customer_Id", SqlDbType.Int);
            param[1].Value = customer_Id;

            param[2] = new SqlParameter("@user_Id", SqlDbType.Int);
            param[2].Value = user_Id;


            param[3] = new SqlParameter("@product_Id", SqlDbType.Int);
            param[3].Value = product_Id;


            param[4] = new SqlParameter("@qantity", SqlDbType.Int);
            param[4].Value = qantity;

            param[5] = new SqlParameter("@unitPrice", SqlDbType.Float);
            param[5].Value = unitPrice;

            param[6] = new SqlParameter("@SubTotal", SqlDbType.Float);
            param[6].Value = SubTotal;


            dal.ExecuteComand("addSellingBillDetails", param);
            dal.close();

        }

        void BillDao.addBillTotal(int bill_Id, float bill_Total, float bill_discount, float bill_paid, int totalQuantity, DateTime bill_date, int customer_Id, int emp_Id)
        {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@bill_Id", SqlDbType.Int);
            param[0].Value = bill_Id;

            param[1] = new SqlParameter("@bill_Total", SqlDbType.Float);
            param[1].Value = bill_Total;

            param[2] = new SqlParameter("@bill_discount", SqlDbType.Float);
            param[2].Value = bill_discount;


            param[3] = new SqlParameter("@bill_paid", SqlDbType.Float);
            param[3].Value = bill_paid;


            param[4] = new SqlParameter("@totalQuantity", SqlDbType.Int);
            param[4].Value = totalQuantity;

            param[5] = new SqlParameter("@bill_date", SqlDbType.DateTime);
            param[5].Value = bill_date;

            param[6] = new SqlParameter("@customer_Id", SqlDbType.Int);
            param[6].Value = customer_Id;


            param[6] = new SqlParameter("@emp_Id", SqlDbType.Int);
            param[6].Value = emp_Id;

            dal.ExecuteComand("addBillTotal", param);
            dal.close();

        }
        //After Every SellignBill Will call this function 
        public void updateQuantityAfterSelling(int productId, int quantity)
        {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@productId", SqlDbType.Int);
            param[0].Value = productId;

            param[1] = new SqlParameter("@quantity", SqlDbType.NChar, 30);
            param[1].Value = quantity;
            dal.ExecuteComand("updateQuantityAfterSelling", param);
            dal.close();

        }
    }
}
