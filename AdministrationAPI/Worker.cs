using System;

namespace AdministrationAPI
{
    public class Worker
    {
        public int workerId { get; set; }
        public string workerName { get; set; }
        public long workerPhone { get; set; }
        public int workerAge { get; set; }

        public virtual decimal workerSalary { get; set; }
    }
}
