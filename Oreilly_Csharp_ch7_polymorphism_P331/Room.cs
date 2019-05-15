﻿
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    class Room : Location
    {
        private string decoration;

        public Room (string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description 
        {
            get { return base.Description + " You see " + decoration + ".";}
        }
    }
}