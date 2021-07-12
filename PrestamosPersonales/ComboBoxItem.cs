using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosPersonales
{
   public class ComboBoxItem
    {
        public string text { get; set; }
        public object value { get; set; }

        public override string ToString()
        {
            return text;
        }
    }
}
