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
        //用於記錄當前場所
        Location currentLocation;

        //表單使用這些參考變數紀錄每個場所
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
        }
        
        private void CreateObjects()
        {
            //....................name,....hot
            garden = new Outside("Garden", false);
            //..............................name,.......hot,....decoration
            backYard = new OutsideWithDoor("Back Yard", true, " a screen door ");
            //...............................name,........hot,.....decoration
            frontYard = new OutsideWithDoor("Front Yard", false, " an oak door with a brass knob");
            //.............................name,..........decoration,............Door Description
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet ", " an oak door with a brass knob");
            //.....................name,..........decoration
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            //..........................name,......decoration,..................Door Description
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliance", "a screen door");

            //6個objects都繼承抽象類別Location，因此對Exits填值
            //Exits是Location類別里的public字串陣列欄位，不應用這種方式封裝。
            //Location陣列+Exit欄位代表該區域的出口連接哪裡
            garden.Exits = new Location[] { frontYard, backYard };
            backYard.Exits = new Location[] { frontYard, garden };
            frontYard.Exits = new Location[] { backYard, garden };
            livingRoom.Exits = new Location[] { frontYard, diningRoom };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom, backYard };

            //對IHasExteriorDoor來說，必須為它們設定外門另一側的場所
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        //在表單中顯示新場所
        private void MoveToANewLocation (Location newLocation)
        {
            currentLocation = newLocation;

            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;

            description.Text = currentLocation.Description;

            //如果當前場所沒有實作IHasExteriorDoor，那會讓"Go through the door" 按鈕不可見
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}