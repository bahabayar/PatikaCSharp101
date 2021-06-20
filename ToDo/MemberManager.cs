using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public static class MemberManager
    {
        public static List<Member> Members;

        static MemberManager()
        {
            Members = DefaultMembers();
        }

        public static List<Member> DefaultMembers()
        {
            return new List<Member>(){
            new Member(1,"Meriç Sert"),
            new Member(2,"Lütfü Sarık"),
            new Member(3,"Deniz Semizotu"),
            new Member(4,"Elif Kanca"),
            new Member(5,"Sude Cankurtaran"),
            };
        }
    }
}