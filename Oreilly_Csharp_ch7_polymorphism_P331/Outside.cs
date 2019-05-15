
namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    class Outside : Location
    {
        private bool hot;

        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        override public string Description 
        {
            get
            {
                string newDescription = base.Description;
                if (hot)
                    newDescription += "It's very hot.";
                return newDescription;
            }
        }
    }
}