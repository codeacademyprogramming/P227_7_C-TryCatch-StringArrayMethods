using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Car car = new Car();
            car.Brand = "Mercedes";
            car.Model = "S500";
            car.FuelCapacity = 80;
            car.CurrentFuel = 10;

            car.AddFuel(40);
            car.AddFuel(20);
            car.AddFuel(40);
            car.AddFuel(40);


           

            Console.WriteLine("Isci sayini daxil edin:");
            string countStr = Console.ReadLine();



            int[] numbers = {};
            int count = 0;

            try
            {
                numbers[0] = 45;
                count = Convert.ToInt32(countStr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Employee[] employees = new Employee[count];


            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i+1}. iscinin adini daxil et");
                string name = Console.ReadLine();

                Console.WriteLine($"{i + 1}. iscinin soyadini daxil et");
                string surname = Console.ReadLine();

                Console.WriteLine($"{i + 1}. iscinin yasini daxil et");
                string ageStr = Console.ReadLine();
                byte age = Convert.ToByte(ageStr);

                Console.WriteLine($"{i + 1}. iscinin vezifesini daxil et");
                string position = Console.ReadLine();


                Console.WriteLine($"{i + 1}. iscinin maasini daxil et");
                string salaryStr = Console.ReadLine();
                double salary = Convert.ToDouble(salaryStr);

                employees[i] = new Employee(name, surname)
                {
                    Age = age,
                    Position = position,
                    Salary = salary
                };
            }

            string option;

            do
            {
                Console.WriteLine("Filtirlemek isteyirsinizmi? y/n");
                option = Console.ReadLine();

            } while (option!="y" && option!="n");


            if (option == "y")
            {
                Console.WriteLine("min salary:");
                string minSalaryStr = Console.ReadLine();
                double minSalary = Convert.ToDouble(minSalaryStr);

                Console.WriteLine("max salary:");
                string maxSalaryStr = Console.ReadLine();
                double maxSalary = Convert.ToDouble(maxSalaryStr);

                foreach (var item in employees)
                {
                    if(item.Salary>=minSalary && item.Salary<=maxSalary)
                        item.ShowInfo();
                }
            }
            else
            {
                foreach (var item in employees)
                {
                    item.ShowInfo();
                }
            }


            
        }

        static void TryParse(int num, string str)
        {
            try
            {
                num = Convert.ToInt32(str);
            }
            catch (Exception)
            {
                num = 0;
            }
        }

    }

  

}
