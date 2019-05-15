﻿
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    abstract class Location
    {
        public Location(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
        public Location[] Exits;

        virtual public string Description
        {
            get
            {
                string description = "You're standing in the " + Name + ". You see exits to the following places:";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                        description += ",";
                }
                description += ".";
                return description;
            }
        }
    }
}