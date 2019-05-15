
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string DoorDescription) : base(name, hot)
        {
            this.DoorDescription = DoorDescription;
        }

        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        override public string Description { get { return base.Description + " You see " + DoorDescription + "."; } }
    }
}