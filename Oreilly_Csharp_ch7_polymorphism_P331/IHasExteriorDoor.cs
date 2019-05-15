
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    interface IHasExteriorDoor
    {
        //Door Description有screen door(紗門)跟an oak door with a brass knob(有黃銅把手的橡木門)
        string DoorDescription { get; } 
        Location  DoorLocation { get; set; }
    }
}