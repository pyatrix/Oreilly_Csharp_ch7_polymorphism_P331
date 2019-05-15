using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            currentLocation
        }
        
        private void CreateObjects()
        {
            //............................name,....hot
            Outside garden = new Outside("Garden", false);
            //..............................................name,.......hot,....decoration
            OutsideWithDoor backYard = new OutsideWithDoor("Back Yard", true, " a screen door ");
            //...............................................name,........hot,.....decoration
            OutsideWithDoor frontYard = new OutsideWithDoor("Front Yard", false, " an oak door with a brass knob");
            //..........................................name,..........decoration,............Door Description
            RoomWithDoor livingRoom = new RoomWithDoor("Living Room", "an antique carpet ", " an oak door with a brass knob");
            //..........................name,..........decoration
            Room diningRoom = new Room("Dining Room", "a crystal chandelier");
            //.......................................name,.......decoration,.....................Door Description
            RoomWithDoor kitchen = new RoomWithDoor("Kitchen", " a stainless steel appliance", " a screen door ");

            //6個objects都繼承抽象類別Location，因此對Exits填值
            //Exits是Location類別里的public字串陣列欄位，不應用這種方式封裝。
            //Location陣列+Exit欄位代表該區域的出口連接哪裡
            garden.Exits = new Location[] { frontYard, backYard };
            backYard.Exits = new Location[] { frontYard, garden };
            frontYard.Exits = new Location[] { backYard, garden };
            livingRoom.Exits = new Location[] { frontYard, diningRoom };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom, backYard };
        }
    }
}