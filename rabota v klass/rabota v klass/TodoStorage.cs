using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabota_v_klass
{
    internal class TodoStorage
    {
        public List<TodoItem> Todos { get; set; }
        public int NextId { get; set; }
        
    }
}
