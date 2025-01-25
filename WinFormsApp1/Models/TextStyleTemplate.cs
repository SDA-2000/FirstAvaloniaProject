using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedProject.Models
{
    public class TextStyleTemplate
    {
        public string Name { get; set; }
        public Font Font { get; set; }
        public Color TextColor { get; set; }
        public Color BackgroundColor { get; set; }

        public TextStyleTemplate(string name, Font font, Color textColor, Color backgroundColor)
        {
            Name = name;
            Font = font;
            TextColor = textColor;
            BackgroundColor = backgroundColor;
        }
    }
}
