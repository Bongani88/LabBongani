using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAppBongani
{
 
    interface MammalsInterface
    {
        void DisplayMammal()
        {

        }
    }
    class Mamals : MammalsInterface
    {
        public void DisplayMammalInfo()
        {
            Console.WriteLine("I am a mammal");
        }
    }

    interface MarineAnimalsInterface
    {
        public void DisplayMarineAnimal()
        {

        }
    }

    class MarineAnimals : MarineAnimalsInterface
    {
        public void DisplayMarineAnimalInfo()
        {
            Console.WriteLine("I am a marine animal");
        }
    }
    class BlueWhale : MammalsInterface, MarineAnimalsInterface
    {
        Mamals objMamals = new Mamals();
        MarineAnimals objMarineAnimals = new MarineAnimals();
        public void DisplayMammalInfo()
        {
            objMamals.DisplayMammalInfo();

        }
        public void DisplayMarineAnimalInfo()
        {
            objMarineAnimals.DisplayMarineAnimalInfo();
        }
        public void DisplayCombinedInfo()
        {
            Console.WriteLine("I belong to both the categories: Mammals as well as Marine Animals");
        }
    }

}
