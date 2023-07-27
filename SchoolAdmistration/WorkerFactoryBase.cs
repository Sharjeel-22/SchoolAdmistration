using AdministrationAPI;

namespace SchoolAdministration
{
    public static class WorkerFactoryBase
    {
        public static Worker GetWorker(WorkerType workerType, int id, string workerName, long workerPhone, int workerAge, decimal workerSalar)
        {
            Worker worker = null;

            switch (workerType)
            {
                case WorkerType.Manager:
                    worker = new Manager
                    {
                        Id = id,
                        workerName = workerName,
                        workerAge = workerAge,
                        workerPhone = workerPhone,
                        workerSalary = workerSalar
                    };
                    break;
                case WorkerType.HeadOfDepartment:
                    worker = new HeadOfDepartment
                    {
                        Id = id,
                        workerName = workerName,
                        workerAge = workerAge,
                        workerPhone = workerPhone,
                        workerSalary = workerSalar
                    };
                    break;
                case WorkerType.DeputyHeadManager:
                    worker = new DeputyHeadManager
                    {
                        Id = id,
                        workerName = workerName,
                        workerAge = workerAge,
                        workerPhone = workerPhone,
                        workerSalary = workerSalar
                    };
                    break;
                case WorkerType.HeadManager:
                    worker = new HeadManager
                    {
                        Id = id,
                        workerName = workerName,
                        workerAge = workerAge,
                        workerPhone = workerPhone,
                        workerSalary = workerSalar
                    };
                    break;
                default:
                    {
                        break;
                    }
            }
        }
    }
}