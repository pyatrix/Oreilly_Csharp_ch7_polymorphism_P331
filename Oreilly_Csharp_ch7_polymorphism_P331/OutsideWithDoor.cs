
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }
    }
}
