
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string DoorDescription) : base(name, hot)
        {
        }

        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }
    }
}
