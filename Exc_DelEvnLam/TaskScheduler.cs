using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_DelEvnLam
{
    public class TaskScheduler
    {
        //string is the argument
        public event EventHandler<string>? TaskCompleted;
        
        /// <param name="task">Delegate (string is the returnvalue)</param>
        public void ExecuteTask(Func<string> task)
        {
            string result = task();
            OnTaskCompleted(result);
        }

        protected virtual void OnTaskCompleted(string result)
        {
            TaskCompleted?.Invoke(this, result);
        }
    }

}
