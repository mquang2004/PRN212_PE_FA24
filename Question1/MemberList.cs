using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class MemberList : ICustomList
    {
        public event Notify? OnFullOfMember;
        public int MaximumNumberOfMember {  get; set; }
        public MemberList() { }
        public MemberList(int maximumNumberOfMember)
        {
            MaximumNumberOfMember = maximumNumberOfMember;
        }

        List<IItem> memberLists = new List<IItem>();
        public void Add(IItem item)
        {
            memberLists.Add(item);                   
        }

        public void DisplayList()
        {
            foreach (var m in memberLists)
            {
                Console.WriteLine(m.ToString); 
            }
        }
    }
}
