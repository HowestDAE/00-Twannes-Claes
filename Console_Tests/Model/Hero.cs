using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tests.Model
{
    public class Hero
    {
		private string _myNemesis;

		public string MyNemesis { get; set; } = "Default name";


		public string MyName { get; set; } = "Default name";

		public int Level { get; set; }

		public Hero(string name) : this(name, "Nemesis", 1)
		{
			this.MyName= name;
            
        }

		public Hero(string name, string myNemesis, int Level)
		{
			this.MyName= name;
			this._myNemesis= myNemesis;
			this.Level = Level;
		}

	}
}
