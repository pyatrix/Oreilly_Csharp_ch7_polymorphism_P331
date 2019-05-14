
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    interface IHasExteriorDoor
    {
        string DoorDescription { get; } 
        Location  DoorLocation { get; set; }
    }
}