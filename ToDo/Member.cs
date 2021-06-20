using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Member
    {
        public int ID { get; set; }
        public string NameSurname { get; set; }

        public Member(int id, string nameSurname)
        {
            this.ID = id;
            this.NameSurname = nameSurname;
        }
    }
}
