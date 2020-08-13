#define WRITELOG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameworkMariaDB
{
    class SignIn
    {
        private static SignIn _s;

        public static SignIn Instance
        {
            get
            {
                if (_s == null)
                {
                    _s = new SignIn();
                }

                return new SignIn();
            }
        }

        account account;

        public static bool OK
        {
            get
            {
                return _s != null && _s.account != null;
            }
        }

        public account Account
        {
            get
            {
                return _s.account;
            }
            private set
            {
                _s.account = value;

#if WRITELOG

                if (_s.account != null)
                    Console.WriteLine("Succesfully logged in as " + _s.account.DisplayName);
#endif

            }
        }

        private SignIn()
        {

        }

        public account LogIn(string mail, string pw)
        {
            if (OK)
            {
#if WRITELOG
                Console.WriteLine("Already Logged In!");
#endif
                return null;
            }
            using (creaturesEntities db = new creaturesEntities())
            {
                var output = new System.Data.Entity.Core.Objects.ObjectParameter("accid", 0);

                db.LoginProcedure(mail, pw,
                            output).FirstOrDefault();



               
                int a;
                
                if(Int32.TryParse(output.Value.ToString(), out a))
                Account = db.account.Find(a);
                else
                {
#if WRITELOG
                    Console.WriteLine("Invalid Login Credentials!");
#endif
                }
            }
            return Account;
        }
    }
}
