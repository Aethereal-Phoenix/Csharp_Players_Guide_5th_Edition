using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lvl18_C1_Vin_Fletcher_s_Arrows
{
    internal class Arrow
    {
        private Arrowhead _arrowhead;
        private int _shaft;
        private Fletching _fletching;
        private double _cost;

        public Arrowhead _Arrowhead { get { return _arrowhead; } set { _arrowhead = value; } }
        public int _Shaft { get { return _shaft; } set { _shaft = value; } }
        public Fletching _Fletching { get { return _fletching; } set { _fletching = value; } }
        public double _Cost { get { return CalculatePrice(); } set { _cost = value; }  }

        public void ChooseArrowhead()
        {
            while (true)
            {
                MethodCodex.Header();
                string[] options = Enum.GetValues<Arrowhead>()
                    .Select(x => x.ToString())
                    .Append("Exit")
                    .ToArray();
                int choice = MethodCodex.ArrowMenu(options);

                if (choice < Enum.GetValues<Arrowhead>().Length)
                {
                    _Arrowhead =  Enum.GetValues<Arrowhead>()[choice];
                    break;
                }
                else if (choice == Enum.GetValues<Arrowhead>().Length)
                {
                    break;
                }
            }
        }// End ChooseArrowhead

        public void ChooseFletching()
        {
            while (true)
            {
                MethodCodex.Header();
                string[] options = Enum.GetValues<Fletching>()
                    .Select(x => x.ToString())
                    .Append("Exit")
                    .ToArray();
                int choice = MethodCodex.ArrowMenu(options);

                if (choice < Enum.GetValues<Fletching>().Length)
                {
                    _Fletching = Enum.GetValues<Fletching>()[choice];
                    break;
                }
                else if (choice == Enum.GetValues<Fletching>().Length)
                {
                    break;
                }
            }
        }// End ChooseFletching

        public void ChooseShaftLength()
        {
            while (true)
            {
                MethodCodex.Header();
                Console.WriteLine("Please enter a number between 60 and 100");
                int.TryParse(Console.ReadLine(), out int shaftLength);
                
                if (shaftLength == 0)
                {
                    break;
                }
                else if (shaftLength >= 60 && shaftLength <= 100)
                {
                    if (MethodCodex.ConfirmInput($"You have entered {shaftLength} is this correct?", 'Y', 'N')) _Shaft = shaftLength;
                    break;
                }
                else
                {
                    MethodCodex.Header();
                    Console.WriteLine($"You have entered an invalid number. ({shaftLength}) \nMake sure the number is between 60 and 100.");
                    Console.ReadKey(true);
                }
            }
        }// End of ChooseShaftLength

        public double CalculatePrice()
        {
            double cost = 0;
            while (true)
            {
                cost += _shaft * .05;
                if (_Arrowhead == Arrowhead.Steel)
                {
                    cost += 10;
                }
                else if (_Arrowhead == Arrowhead.Wood)
                {
                    cost += 3;
                }
                else if (_Arrowhead == Arrowhead.Obsidian)
                {
                    cost += 5;
                }

                if (_Fletching == Fletching.Plastic)
                {
                    cost += 10;
                }
                else if (_Fletching == Fletching.Turkey_Feathers)
                {
                    cost += 5;
                }
                else if (_Fletching == Fletching.Goose_Feathers)
                {
                    cost += 3;
                }

                return cost;
            }
        }// End of CalculatePrice

        public Arrow()
        {
            ChooseArrowhead();
            ChooseFletching();
            ChooseShaftLength();
            CalculatePrice();
        }
    }
}
