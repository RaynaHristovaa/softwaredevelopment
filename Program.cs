using System.Globalization;

namespace StudentRegistration
{
    internal class Program
    {
        private static int nextId = 1;
        static void Main(string[] args)
        {




            int id = nextId++;
            Student student = null;

            while (true)
            {
                try
                {
                    Console.Write("Въведете име на ученика: ");
                    string nameInput = Console.ReadLine();
                    student = new Student(id, nameInput);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message} Въведете отново[cite: 1].");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Въведете възраст (6-20): ");
                    int ageInput = int.Parse(Console.ReadLine());
                    student.Age = ageInput;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешка: Невалиден формат на цяло число[cite: 1]. Въведете отново.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message} Въведете отново[cite: 1].");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Въведете клас (1-12): ");
                    int gradeInput = int.Parse(Console.ReadLine());
                    student.Grade = gradeInput;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешка: Невалиден формат на цяло число[cite: 1]. Въведете отново.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message} Въведете отново[cite: 1].");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Въведете среден успех (2.00-6.00): ");
                    double scoreInput = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    student.AverageScore = scoreInput;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешка: Невалиден формат на число[cite: 1]. Въведете отново.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message} Въведете отново[cite: 1].");
                }
            }


            while (true)
            {
                try
                {
                    Console.Write("Въведете такса: ");
                    decimal feeInput = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    student.Fee = feeInput;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешка: Невалиден формат на число[cite: 1]. Въведете отново.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message} Въведете отново[cite: 1].");
                }
            }


            while (true)
            {
                try
                {
                    Console.Write("Получава ли стипендия (true/false или Да/He): ");
                    string scholarshipInput = Console.ReadLine()?.Trim().ToLower();

                    if (scholarshipInput == "да" || scholarshipInput == "true" || scholarshipInput == "1")
                    {
                        student.HasScholarship = true;
                    }
                    else if (scholarshipInput == "he" || scholarshipInput == "не" || scholarshipInput == "false" || scholarshipInput == "0")
                    {
                        student.HasScholarship = false;
                    }
                    else
                    {
                        throw new FormatException("Моля, въведете true/false или Да/He.");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message} Въведете отново[cite: 1].");
                }
            }

           
            while (true)
            {
                try
                {
                    Console.Write("Въведете паралелка (буква): ");
                    string letterInput = Console.ReadLine();
                    if (string.IsNullOrEmpty(letterInput) || letterInput.Length != 1)
                    {
                        throw new ArgumentException("Паралелката трябва да бъде точно една буква.");
                    }
                    student.ClassLetter = letterInput[0];
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message} Въведете отново[cite: 1].");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Въведете дата на раждане (dd.MM.yyyy): ");
                    DateTime dateInput = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    student.BirthDate = dateInput;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешка: Невалиден формат на дата (използвайте dd.MM.yyyy)[cite: 1]. Въведете отново.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message} Въведете отново[cite: 1].");
                }
            }

            Console.WriteLine("\n=== ДАННИ ЗА УЧЕНИК ===\n");
            Console.WriteLine($"Id: {student.Id}");
            Console.WriteLine($"Име: {student.Name}");
            Console.WriteLine($"Възраст: {student.Age}");
            Console.WriteLine($"Клас: {student.Grade}");
            Console.WriteLine($"Среден успех: {student.AverageScore:F2}");
            Console.WriteLine($"Такса: {student.Fee:F2} лв.");
            Console.WriteLine($"Стипендия: {(student.HasScholarship ? "Да" : "He")}");
            Console.WriteLine($"Паралелка: {student.ClassLetter}");
            Console.WriteLine($"Дата на раждане: {student.BirthDate:dd.MM.yyyy}");











        }
    }
}
