using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Perfumer
{
    class Functions
    {
        PerfumerEntities db = new PerfumerEntities();
        public bool Entry(string log, string pass)
        {
            var user = db.Clients.ToList().Find(x => x.Login == log && x.Password == pass);
            if (user != null)
            {
                new AccountWindow(user).Show();
                return true;
            }
            else
                MessageBox.Show("Логин или пароль введены неверно!");
            return false;
        }
    }
}
