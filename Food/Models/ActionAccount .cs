using Food.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Food.Models
{
    class ActionAccount
    {
        public bool AddDangki(Account item)
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance_Account();
            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            string sqlCommand = "insert into Account(username,password) values(?,?)";
            var stt = sQLiteConnection.Prepare(sqlCommand);
            stt.Bind(1, item.UserName);
            stt.Bind(2, item.Password);

            var result = stt.Step();
            return result == SQLiteResult.OK;
        }



        public List<Account> CheckLogin()
        {
            SQLiteConnection sQLiteConnection = SQLiteHelper.createInstance_Account().sQLiteConnection;
            string sqlCommand = "select * from Account;";
            var stt = sQLiteConnection.Prepare(sqlCommand);
            List<Account> list = new List<Account>();
            while (SQLiteResult.ROW == stt.Step())
            {

                string name = (string)stt[0];

                int pass = Convert.ToInt32(stt[1]);
                list.Add(new Models.Account(name, pass));
            }
            return list;
        }
    }
}
}
