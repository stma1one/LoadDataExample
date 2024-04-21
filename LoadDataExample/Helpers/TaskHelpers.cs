using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataExample
{
    public static class TaskHelpers
    {
        public async static  void  Await(this Task task,Action completedCallback=null, Action<Exception> failedCallBack=null)
        {
            try
            {
                await task;
                completedCallback?.Invoke();
            }
            catch (Exception ex)
            {
                failedCallBack?.Invoke(ex);
            }
        }
    }
}
