using System;
using System.Runtime.Intrinsics.X86;

namespace Collections1
{
    public class Country
    {
        public string Name { get; }
        public string Code { get; }
        public string Region { get; }
        public int Pop { get; }

        public Country(string name, string code, string region, int pop)
        {
            this.Name = name;
            this.Code = code;
            this.Region = region;
            this.Pop = pop;
        }

    }

}