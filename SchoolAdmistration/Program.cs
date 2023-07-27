using System;
using AdministrationAPI;
using System.Collections.Generic;

public enum WorkerType{
    Manager,
    HeadOfDepartment,
    DeputyHeadManager,
    HeadManager
}

namespace SchoolAdministration
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<Worker> workers = new List<Worker>();
            SeedData(workers);
            foreach (Worker worker in workers)
            {
                totalSalaries += worker.workerSalary;
            }
            Console.WriteLine($"Total Annual Salaries (including bonus): {workers.Sum(e => e.workerSalary)}");
            Console.ReadKey();

        }
        public static void SeedData(List<Worker> workers)
        {

            Worker worker1 = WorkerFactory.GetWorker(WorkerType.Manager, 1, "Sharjeel", 03123456789, 25, 40000);
            workers.Add(worker1);

            Worker worker2 = WorkerFactory.GetWorker(WorkerType.Manager, 2, "Tahir", 03123456789, 25, 40000);
            workers.Add(worker2);

            Worker headOfDepart = WorkerFactory.GetWorker(WorkerType.HeadOfDepartment, 3, "Shehryar", 03123456789, 25, 50000);
            workers.Add(headOfDepart);
            Worker duptyManager = WorkerFactory.GetWorker(WorkerType.DeputyHeadManager, 4, "Hassan", 03123456789, 25, 60000);
            workers.Add(duptyManager);

            Worker headManager = WorkerFactory.GetWorker(WorkerType.HeadManager, 5, "Zaggi", 03123456789, 25, 80000);
            workers.Add(headManager);
        }
    }

    public class Manager : WorkersBase
    {

        public override decimal workerSalary { get => base.workerSalary + (base.workerSalary * 0.02m); }


    }
    public class HeadOfDepartment : WorkersBase
    {
        public override decimal workerSalary { get => base.workerSalary + (base.workerSalary * 0.03m); }

    }
    public class DeputyHeadManager : WorkersBase
    {
        public override decimal workerSalary { get => base.workerSalary + (base.workerSalary * 0.04m); }

    }
    public class HeadManager : WorkersBase
    {
        public override decimal workerSalary { get => base.workerSalary + (base.workerSalary * 0.05m); }

    }

    public static class WorkerFactory
    {
        public static Worker GetWorker(WorkerType workerType,int id,string workerName,long workerPhone,int workerAge,decimal workerSalar)
        {
            Worker worker = null;

            switch (workerType)
            {
                case WorkerType.Manager:
                    worker = FactoryPattern<Worker, Manager>.GetAllWorker();
                    break;
                case WorkerType.HeadOfDepartment:
                    worker = FactoryPattern<Worker,HeadOfDepartment>.GetAllWorker();
                    break;
                case WorkerType.DeputyHeadManager:
                    worker = FactoryPattern<Worker, DeputyHeadManager>.GetAllWorker();
                    break;
                case WorkerType.HeadManager:
                    worker = FactoryPattern<Worker, HeadManager>.GetAllWorker();
                    break;
                default:
                    {
                        break;
                    }
                    if(worker != null)
                    {
                        worker.workerId = id;
                        worker.workerName = workerName;
                        worker.workerPhone = workerPhone;
                        worker.workerAge = workerAge;
                        worker.workerSalary = workerSalar;
                    }else
                    {
                        throw new NullReferenceException();
                    }
            }

            return worker;
        }
    }
}
