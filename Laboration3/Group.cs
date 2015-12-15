using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Group : Artist
    {
        Member[] members;

        public Member this[int index]
        {
            get
            {
                if (index >= 0 && index < members.Length)
                    return members[index];
                throw new IndexOutOfRangeException();
            }
        }
        public int Length => members.Length;

        public Group(string name) : base(name)
        {
            members = new Member[0];
        }

        public void AddMember(Member memberToAdd)
        {
            if (GetMemberIndex(memberToAdd) < 0)
            {
                Member[] newMembers = new Member[members.Length + 1];
                for (int i = 0; i < members.Length; i++)
                {
                    newMembers[i] = members[i];
                }
                newMembers[members.Length] = memberToAdd;
                members = newMembers;
            }
        }
        public void RemoveMember(Member memberToRemove)
        {
            int removeIndex = GetMemberIndex(memberToRemove);
            Member[] newMembers = new Member[members.Length - 1];
            for (int i = 0, j = 0; i < members.Length; i++)
            {
                if (i == removeIndex)
                    continue;
                newMembers[j] = members[i];
                j++;
            }
            members = newMembers;
        }
        private int GetMemberIndex(Member member)
        {
            for (int i = 0; i < members.Length; i++)
            {
                if (members[i] == member)
                    return i;
            }
            return -1;
        }

        public override string ToString() => $"Name:{Name} Members[{members.Aggregate("", (current, member) => current + $"({member})")}]";
    }
}
