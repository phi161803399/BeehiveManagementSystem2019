using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    public class Worker
    {
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public string CurrentJob { get; }
        public int ShiftsLeft { get; }

        public Worker(string[] jobs)
        {
            jobsICanDo = jobs;
        }

        public bool DoThisJob(string jobToDo)
        {
            if (String.IsNullOrEmpty(CurrentJob))
            {
                foreach (var job in jobsICanDo)
                {
                    if (job == jobToDo) return true;
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            // the worker works a shift

            // keep track of ShiftsLeft

            // if job is done, CurrentJob = "" 

            // return true when ShiftsLeft == 0 else return false
            return true;
        }
    }
}
