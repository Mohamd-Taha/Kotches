using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotches.Data_Acess_Layer_Interfaces
{
    interface BillDao

    {
        void addBill(int bill_Id, int customer_Id, int user_Id, int product_Id, int qantity, float unitPrice, float SubTotal);
        void addBillTotal(int bill_Id, float bill_Total, float bill_discount, float bill_paid, int totalQuantity, DateTime bill_date, int customer_Id, int emp_Id);

    }
}
