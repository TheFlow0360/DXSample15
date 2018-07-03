using System;

namespace DXSample15
{
    public class Dummy
    {
        private static int _idCounter = 0;

        public Dummy(String text)
        {
            Id = _idCounter++;
            _text = text;
        }

        public int Id { get; }

        private String _text;
        
        public String Text => _text;

        public String Link => _text;
    }
}