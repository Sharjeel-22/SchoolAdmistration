using System;

namespace AdministrationAPI
{
    public class WorkersBase : Worker
    {
        public int Id { get; set; }
        public string workerName { get; set; }
        public long workerPhone { get; set; }
        public int workerAge { get; set; }

    }
}
