using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace EX_01_CycleRace.Model
{
	public class Cyclist
	{
		private int _width = Console.WindowWidth - 9;

		private ConsoleColor _color;

		public ConsoleColor Color
		{
			get { return _color; }
			set { _color = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private Random _rnd = new Random();

		private int _xPos;

		public int XPos
		{
			get { return _xPos; }
			set { _xPos = value; }
		}

		private char[] _WHEELCHARS = { '/', '-', '\\' ,'|' };

		public uint WheelState
		{
			get { return WheelState; }
			set { if (value > _WHEELCHARS.Length) { WheelState = 0; } }
		}

		public Cyclist(string name)
		{
			this.Name = name.ToUpper();
			RandomizeColor();
		}

		public Cyclist(string name, ConsoleColor color)
		{
			this.Name = name.ToUpper();
			this.Color = color;
		}

		public void RandomizeColor()
		{
			ConsoleColor color = ConsoleColor.Black;

			while(color != ConsoleColor.Black && color != ConsoleColor.White) 
			{
                int amount = Enum.GetValues(typeof(ConsoleColor)).Length;
                int index = _rnd.Next(amount + 1);

				color = (ConsoleColor)index;	
            }
        }

		public void Display()
		{

		}

		private void DisplayStreet()
		{
			for(int i = 0; i < _width; i++)
			{
				Console.Write('=');
			}
		}

		public bool Update()
		{
			Console.SetCursorPosition(0, 0);

			XPos += _rnd.Next(1, 6);

			WheelState++;

			if(XPos >= _width) { return true; }

			return false;
		}

	}
}
