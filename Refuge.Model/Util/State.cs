using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Model.Util
{
    public class State
    {

        public State()
        {
            Name = null;
            Abbreviations = null;
        }

        public State(string ab, string name)
        {
            Name = name;
            Abbreviations = ab;
        }

        public string Name { get; set; }

        public string Abbreviations { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Abbreviations, Name);
        }

    }
}
