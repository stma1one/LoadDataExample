using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataExample
{

    /*
     * מחלקת עזר המוסיפה ל
     * Task
     * פעולה המאפשרת לטפל בפעולה א-סינכרונית המופעלת מפעולות סינכרוניות    * 
     */


    public static class TaskHelpers
    {
        /// <summary>
        /// Extention 
        /// המאפשר להפעיל פעולה א-סינכרונית מתוך פעולה סינכרונית- (לשימוש בפעולות בונות)
        /// </summary>
        /// <param name="task">המשימה שיש להפעיל</param>
        /// <param name="completedCallback">הפעולה שיש להפעיל במקרה של הצלחה</param>
        /// <param name="failedCallBack">פעולה שיש להפעיל במקרה של כשלון</param>
        public async static void Awaiter( this Task task,Action successcallback=null,Action<Exception> failureCallback=null )
        {
            try
            {
                await task;
                successcallback?.Invoke();

            }
            catch (Exception ex) 
            {
                failureCallback?.Invoke( ex );
            }


        }
    }
}
