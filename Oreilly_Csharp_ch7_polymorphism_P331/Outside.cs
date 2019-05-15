
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    class Outside : Location
    {
        private string name;
        private bool hot { get; }
        
        public Outside(string name, bool hot)  : base(name)
        {
            this.name = name;
            this.hot = hot;
        }

        override public string Description 
        {
            get
            {
                string newDescription = base.Description;
                if (hot == true)
                    newDescription += "It's very hot here";
                return newDescription;
            }
        }
    }
}