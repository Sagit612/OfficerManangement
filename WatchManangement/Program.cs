using System;

namespace OfficerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerOfficer managerOfficer = new ManagerOfficer();
            IO.PrintMenu();
            int input = 0;
            string inputOfficer = "";
            Officer engineer1 = new Engineer(192, "quoc", 18, "male", "17 dien bien phu", "software");
            managerOfficer.AddOfficer(engineer1);
            Officer engineer2 = new Engineer(193, "quoc", 18, "male", "17 dien bien phu", "software");
            managerOfficer.AddOfficer(engineer2);
            Officer engineer3 = new Engineer(194, "quoc", 18, "male", "17 dien bien phu", "software");
            managerOfficer.AddOfficer(engineer3);
            Officer engineer4 = new Engineer(195, "quoc", 18, "male", "17 dien bien phu", "software");
            managerOfficer.AddOfficer(engineer4);
            Officer engineer5 = new Engineer(196, "quoc", 18, "male", "17 dien bien phu", "software");
            managerOfficer.AddOfficer(engineer5);
            Officer engineer6 = new Engineer(197, "quoc", 18, "male", "17 dien bien phu", "software");
            managerOfficer.AddOfficer(engineer6);
            Officer engineer7 = new Engineer(198, "quoc", 18, "male", "17 dien bien phu", "software");
            managerOfficer.AddOfficer(engineer7);
            Officer engineer8 = new Engineer(199, "quoc", 18, "male", "17 dien bien phu", "software");
            managerOfficer.AddOfficer(engineer8);
            Officer engineer9 = new Engineer(200, "quoc", 18, "male", "17 dien bien phu", "software");
            managerOfficer.AddOfficer(engineer9);
            Officer engineer10 = new Engineer(201, "quoc", 18, "male", "17 dien bien phu", "software");
            managerOfficer.AddOfficer(engineer10);
            Officer engineer11 = new Engineer(202, "quoc", 18, "male", "17 dien bien phu", "software");
            managerOfficer.AddOfficer(engineer11);
            Officer Worker1 = new Worker(1, "quoc", 18, "male", "17 dien bien phu", 1);
            managerOfficer.AddOfficer(Worker1);
            Officer Worker2 = new Worker(2, "quoc", 18, "male", "17 dien bien phu", 2);
            managerOfficer.AddOfficer(Worker2);
            Officer Worker3 = new Worker(3, "quoc", 18, "male", "17 dien bien phu", 3);
            managerOfficer.AddOfficer(Worker3);
            Officer Worker4 = new Worker(4, "quoc", 18, "male", "17 dien bien phu", 4);
            managerOfficer.AddOfficer(Worker4);
            Officer Worker5 = new Worker(5, "quoc", 18, "male", "17 dien bien phu", 5);
            managerOfficer.AddOfficer(Worker5);
            Officer Worker6 = new Worker(6, "quoc", 18, "male", "17 dien bien phu", 6);
            managerOfficer.AddOfficer(Worker6);
            Officer Worker7 = new Worker(7, "quoc", 18, "male", "17 dien bien phu", 7);
            managerOfficer.AddOfficer(Worker7);
            Officer Worker8 = new Worker(8, "quoc", 18, "male", "17 dien bien phu", 8);
            managerOfficer.AddOfficer(Worker8);
            Officer Worker9 = new Worker(9, "quoc", 18, "male", "17 dien bien phu", 9);
            managerOfficer.AddOfficer(Worker9);


            while (true)
            {
                input = IO.EnterMenuOptions();
                switch (input)
                {
                    case MenuOption.ADD_OFFICERS:
                        //while (inputOfficer != MenuOption.EXIT_ENTER_OFFICER)
                        //{
                             inputOfficer = IO.EnterOfficer();
                            switch (inputOfficer)
                            {
                                case MenuOption.ADD_ENGINEER:
                                    Console.WriteLine("Enter the information of engineer:");
                                    Officer engineer = new Engineer
                                        (IO.EnterId(),
                                         IO.EnterName(),
                                         IO.EnterAge(),
                                         IO.EnterGender(),
                                         IO.EnterAddress(),
                                         IO.EnterBranch());
                                    managerOfficer.AddOfficer(engineer);
                                    Console.WriteLine("================");
                                    Console.WriteLine("\n" + engineer.ToString());
                                    Console.WriteLine("================");
                                    break;
                                case MenuOption.ADD_WORKER:
                                    Console.WriteLine("Enter the information of worker:");
                                    Officer worker = new Worker
                                        (IO.EnterId(),
                                         IO.EnterName(),
                                         IO.EnterAge(),
                                         IO.EnterGender(),
                                         IO.EnterAddress(),
                                         IO.EnterLevel());
                                    managerOfficer.AddOfficer(worker);
                                    Console.WriteLine("================");
                                    Console.WriteLine("\n" + worker.ToString());
                                    Console.WriteLine("================");
                                    break;
                                //case MenuOption.EXIT_ENTER_OFFICER:
                                //    inputOfficer = MenuOption.EXIT_ENTER_OFFICER;
                                //    break;
                                default:
                                    break;
                            }
                        //}
                        break;
                    case MenuOption.GET_ALL:
                        Console.WriteLine(managerOfficer.GetAllOfficerInfo());
                        break;
                    case MenuOption.REMOVE_STUDENT:
                        IO.ShowMessage(managerOfficer.RemoveOfficerById(IO.EnterId()));
                        break;
                    case MenuOption.SEARCH_BY_ID:
                        Console.WriteLine(managerOfficer.SearchOfficerById(IO.EnterId()));
                        break;
                    case MenuOption.UPDATE_ENGINEER:
                        IO.ShowMessage(managerOfficer.UpdateEngineerById
                            (IO.EnterId(),
                             IO.EnterName(),
                             IO.EnterAge(),
                             IO.EnterGender(),
                             IO.EnterAddress(),
                             IO.EnterBranch()
                            ));
                        break;
                    case MenuOption.UPDATE_WORKER:
                        IO.ShowMessage(managerOfficer.UpdateEngineerById
                            (IO.EnterId(),
                             IO.EnterName(),
                             IO.EnterAge(),
                             IO.EnterGender(),
                             IO.EnterAddress(),
                             IO.EnterBranch()
                            ));
                        break;
                    case MenuOption.EXIT:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
