
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    interface IHasExteriorDoor
    {
        //Door Description有screen door跟an oak door with a brass knob
        string DoorDescription { get; } 
        Location  DoorLocation { get; set; }
    }
}