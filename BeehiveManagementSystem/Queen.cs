using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    public class Queen
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int shifts)
        {
            bool isWorkerAvailable = false;
            foreach (Worker worker in workers)
            {
                if (worker.DoThisJob(job, shifts)) isWorkerAvailable = true;
            }
            return isWorkerAvailable;
        }

        internal string WorkTheNextShift()
        {
            shiftNumber++;
            int workerNumber = 1;
            string report = $"Report for shift #{shiftNumber}" + Environment.NewLine;
            foreach (Worker worker in workers)
            {
                if (worker.DidYouFinish())
                {
                    report += String.Join(
                        Environment.NewLine,
                        $"Worker #{workerNumber} finished the job",
                        $"Worker #{workerNumber} not working") + Environment.NewLine;
                }
                else
                {
                    if (worker.ShiftsLeft == 1)
                    {
                        report += $"Worker #{workerNumber} will be done with '{worker.CurrentJob}' after this shift" + Environment.NewLine;
                    }
                    else
                    {
                        report += $"Worker #{workerNumber} is doing '{worker.CurrentJob}' for {worker.ShiftsLeft} more shifts" + Environment.NewLine;
                    }
                }
                workerNumber++;
            }
            return report;
        }
    }
}
