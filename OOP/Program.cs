using System;
using System.IO;
using System.Text;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string fileGirls = "girls.txt";
            int action = 0;
            do
            {
                Console.WriteLine("Оберіть операцію:");
                Console.WriteLine("0. Вихід");
                Console.WriteLine("1. Додати дівчину");
                Console.WriteLine("2. Показати всіх дівчат");
                Console.WriteLine("3. Пошук");
                Console.Write("->_");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            try
                            {
                                Girl girl = new Girl();
                                Console.WriteLine("Введіть ім'я:");
                                girl.Name = Console.ReadLine();
                                Console.WriteLine("Введіть вік:");
                                girl.Age = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введіть вагу:");
                                girl.Weight = int.Parse(Console.ReadLine());
                                using (StreamWriter sw = new StreamWriter(fileGirls, append: true, Encoding.UTF8))
                                {
                                    //StreamWriter sw = new StreamWriter(fileGirls, append: true, Encoding.UTF8);
                                    sw.WriteLine(girl.Name);
                                    sw.WriteLine(girl.Age);
                                    sw.WriteLine(girl.Weight);
                                    //sw.Close();
                                    //sw = null;
                                }
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine("Проблема при створені {0}", ex.Message);
                            }
                            break;
                        }
                    case 2:
                        {
                            using (StreamReader sw = new StreamReader(fileGirls))
                            {
                                Girl girl = new Girl();
                                while (true)
                                {
                                    try
                                    {
                                        girl.Name = sw.ReadLine();
                                        girl.Age = int.Parse(sw.ReadLine());
                                        girl.Weight = int.Parse(sw.ReadLine());
                                        Console.WriteLine($"{girl.Name} {girl.Age} - {girl.Weight}");
                                    }
                                    catch
                                    {
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            GirlSearch search = new GirlSearch();
                            Console.WriteLine("Введіть ім'я:");
                            search.Name = Console.ReadLine();
                            Console.WriteLine("Введіть вік:");
                            string temp = Console.ReadLine();
                            if(!string.IsNullOrEmpty(temp))
                                search.Age = int.Parse(temp);
                            using (StreamReader sw = new StreamReader(fileGirls))
                            {
                                Girl girl = new Girl();
                                while (true)
                                {
                                    try
                                    {
                                        girl.Name = sw.ReadLine();
                                        girl.Age = int.Parse(sw.ReadLine());
                                        girl.Weight = int.Parse(sw.ReadLine());
                                        bool isFind = false;
                                        if (!string.IsNullOrEmpty(search.Name))
                                        {
                                            if (search.Age != 0)
                                            {
                                                if (search.Name.Contains(girl.Name) && search.Age == girl.Age)
                                                    isFind = true;
                                            }
                                            else if(search.Name.Contains(girl.Name))
                                                isFind = true;
                                                
                                        }
                                        else if(search.Age!=0)
                                        {
                                            if (search.Age == girl.Age)
                                                isFind = true;
                                        }
                                        if(isFind)
                                        {
                                            Console.WriteLine($"{girl.Name} {girl.Age} - {girl.Weight}");
                                        }
                                    }
                                    catch
                                    {
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    default:
                        break;
                }

            } while (action!=0);
       

            //using (StreamWriter sw = new StreamWriter(fileGirls))
            //{ 
            //    girlStruct.name = "Світлана";
            //    girlStruct.age = 18;
            //    girlStruct.weight = 90;
            //    sw.WriteLine(girlStruct.name);
            //    sw.WriteLine(girlStruct.age);
            //    sw.WriteLine(girlStruct.weight);
            //}
            
            //Console.WriteLine($"{girlStruct.name} {girlStruct.age} - {girlStruct.weight}");
        }
    }
}
