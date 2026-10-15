using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rabota_v_klass
{
    internal class zadacha
    {
        private string tittle;

        public int ID { get; set; }
        public string title {  get; private set; }
        public string description { get; set; }
        public DateTime deadline {  get; set; }
        
        public bool isdone { get; set; }=false;
        

        public zadacha (int id, string Title, string Description, DateTime Deadline)
        {
            ID = id;
            title = Title;
            description = Description;
            deadline = Deadline;   
            

        }

        public zadacha(string tittle, string description, DateTime deadline)
        {
            this.tittle = tittle;
            this.description = description;
            this.deadline = deadline;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" Заглавие: {title}, описание: {description}, краен срок: {deadline}");
        }

        public string ToFileFormat()
        {
            return $" {title}, {description} , {deadline  }";
        }

        








    }
}
