
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }

        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration)
        {
            DoorDescription = doorDescription;
        }
    }
}