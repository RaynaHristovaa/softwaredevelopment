namespace rabota_v_klass
{
    internal class Program
    {
        static string filePath = "zadaci.txt";
       static List<zadacha> tasks= new List<zadacha>();
        private static int nextId = 1;

        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("1.Добави нова задача ");
                Console.WriteLine("2.Вижда всички въеедени задачи");
                Console.WriteLine("3. Маркира задачата като изпълнена ");
                Console.WriteLine("4. Изтрива задачата");
                Console.WriteLine("5. Прекратява работата на програмата");
                string choice = Console.ReadLine();






                static void SaveZadachiToFile()
                {

                    List<string> lines = new List<string>();
                    for (int i = 0; i < tasks.Count; i++)
                    {



                        lines.Add(tasks[i].ToFileFormat());
                    }
                    File.WriteAllLines(filePath, lines);





                }
                static void LoadZadachiFromFile()
                {
                    if (!File.Exists(filePath))
                    {
                        File.Create(filePath).Close();
                        return;
                    }



                    string[] lines = File.ReadAllLines(filePath);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (string.IsNullOrEmpty(lines[i])) continue;
                        string[] parts = lines[i].Split(',');
                        if (parts.Length == 6)
                        {
                            string tittle = parts[0];
                            string description = parts[1];
                            string deadline = parts[2];


                            zadacha z = new zadacha(nextId, tittle, description,DateTime.Parse( deadline));
                            tasks.Add(z);
                        }

                    }
                }

                switch (choice)
                {

                    case "1":

                        Console.WriteLine("Въведи заглавие");
                        string title = Console.ReadLine();

                        Console.WriteLine(" Въведи описание ");
                        string description = Console.ReadLine();

                        Console.WriteLine("Въведи краен срок");
                        string deadline = Console.ReadLine();


                        Console.WriteLine(" Задачата е въведена  успешно");
                        break;

                    case "2":

                        Console.WriteLine("Списък със задачи");
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Списъкът е празен");

                        }
                        else
                        {
                            foreach (zadacha z in tasks)
                            {
                                Console.WriteLine(z.title);
                            }
                        }
                        break;

                    case "3":

                        Console.WriteLine("Коя задача е маркирана правилно ");
                        string taskName = Console.ReadLine();
                        foreach (zadacha z in tasks)
                        {
                            if (z.title == taskName)
                            {
                                z.isdone = true;
                                Console.WriteLine("Маркирана е като правилна");
                            }



                        }
                        break;

                    case "4":
                        Console.WriteLine("Въведи заглавие на задачата за изтриване ");
                        string taskRemove = Console.ReadLine();
                        tasks.RemoveAll(z => z.title == taskRemove);
                        Console.WriteLine("Задачата е изтрита");
                        break;


                    case "5":
                        break;

                }



            }


        }
           private static void AddTodo()
        {
            Console.Clear();
            Console.WriteLine("=====  Добавяне на задача =======");
            Console.Write("Заглавие:");
            string title = Console.ReadLine();

            Console.Write("Описание:");
            string description = Console.ReadLine();

            Console.Write("Краен срок:");
            DateTime deadline = DateTime.Parse(Console.ReadLine());

            zadacha todoItem = new zadacha(nextId, title, description, deadline);

            tasks.Add(todoItem);
            nextId++;
            Console.WriteLine("Задачата е добавена.");
        }
    }
    }

