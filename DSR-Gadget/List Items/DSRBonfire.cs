﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DSR_Gadget
{
    class DSRBonfire : IDSRProperty
    {
        private static Regex bonfireEntryRx = new Regex(@"^(?<id>\S+) (?<name>.+)$");

        public string Name { get; set; }
        public int ID { get; set; }

        private DSRBonfire(string config)
        {
            Match bonfireEntry = bonfireEntryRx.Match(config);
            Name = bonfireEntry.Groups["name"].Value;
            ID = Convert.ToInt32(bonfireEntry.Groups["id"].Value);
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(IDSRProperty other)
        {
            return Name.CompareTo(other.Name);
        }

        public static List<DSRBonfire> All = new List<DSRBonfire>();

        public DSRBonfire()
        {
            Name = "";
            ID = -1;
        }

        static DSRBonfire()
        {
            foreach (string line in Regex.Split(Properties.Resources.Bonfires, "[\r\n]+"))
                All.Add(new DSRBonfire(line));
            All.Sort();
        }
    }
}
