
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }
    }
}