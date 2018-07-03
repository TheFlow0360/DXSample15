using System.Collections.Generic;

namespace DXSample15
{
    public class ViewModel
    {
        public ViewModel()
        {
            Items = new List<Dummy>();
            Items.Add(new Dummy("Normal Text"));
            Items.Add(new Dummy("problem"));
            Items.Add(new Dummy("cut off: g y p q j"));
        }

        public List<Dummy> Items { get; }
    }
}