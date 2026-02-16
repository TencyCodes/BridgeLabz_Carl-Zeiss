using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Events
{
    internal class ButtonClick
    {
        public delegate void ClickHandler(string buttonName);

        public event ClickHandler OnClick;
        public string Name { get; set; }

        public void Click()
        {
            Console.WriteLine($"{Name} was clicked");

            OnClick?.Invoke(Name);
        }
    }
    public class Vruh
    {
        public static void Main()
        {
            ButtonClick butt = new ButtonClick() { Name="Zestoneel"};
            butt.OnClick += Start;
            butt.OnClick += Stop;
            butt.Click();

        }
        public static void Start(string buttonName)
        {
            Console.WriteLine($"Start:{buttonName} done");
        }
        public static void Stop(string buttonName)
        {
            Console.WriteLine($"Stop: Validating Stopping ");
        }
    }
}
