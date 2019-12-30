using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerece_BAL.Implementation
{
    public class Notifications
    {
        private static Notifications notificationsObj = null;
        private static readonly object lockObj = new object();
        private Notifications()
        {

        }

        public static Notifications GetInstance()
        {
            lock (lockObj)
            {
                if (notificationsObj == null)
                    notificationsObj = new Notifications();

                return notificationsObj;
            }
        }
    }


}
