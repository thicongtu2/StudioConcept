﻿using System.Windows;
using System.Windows.Media;

namespace StudioConcept.MVVM
{
    public class IfShape : BaseShape
    {
        private double middleSpace;
        private double width;
        public string Draw()
        {
            string aboveTemplate = $"m 0,4 A 4,4 0 0,1 4,0 H 12 c 2,0 3,1 4,2 l 4,4 c 1,1 2,2 4,2 h 12 c 2,0 3,-1 4,-2 l 4,-4 c 1,-1 2,-2 4,-2 H {width} a 4,4 0 0,1 4,4 v 40  a 4,4 0 0,1 -4,4 H 64 c -2,0 -3,1 -4,2 l -4,4 c -1,1 -2,2 -4,2 h -12 c -2,0 -3,-1 -4,-2 l -4,-4 c -1,-1 -2,-2 -4,-2 h -8  a 4,4 0 0,0 -4,4 ";
            string middleSpaceTemplate = $"v {middleSpace} a 4,4 0 0,0 4,4 ";
            string belowTemplate = $"h 8 c 2,0 3,1 4,2 l 4,4 c 1,1 2,2 4,2 h 12 c 2,0 3,-1 4,-2 l 4,-4 c 1,-1 2,-2 4,-2 H {width} H {width} a 4,4 0 0,1 4,4 v 40  a 4,4 0 0,1 -4,4 H 48   c -2,0 -3,1 -4,2 l -4,4 c -1,1 -2,2 -4,2 h -12 c -2,0 -3,-1 -4,-2 l -4,-4 c -1,-1 -2,-2 -4,-2 H 4 a 4,4 0 0,1 -4,-4 z";

            return aboveTemplate + middleSpaceTemplate + belowTemplate;
        }

        public Color Color { get; set; }
        public Color TextColor { get; set; }
        private string data;
        public string Data
        {
            get => data;
            set
            {
                data = value;
                OnPropertyChanged("Data");
            }
        }

        public double FontSize { get; set; }

        private string text;
        public string Text
        {
            get => text;
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }

        public Thickness MarginText { get; set; }

        public IfShape(double width, double middleSpace, Color color, string text)
        {
            this.width = width;
            this.middleSpace = middleSpace;
            Color = color;
            this.text = text;
            data = Draw();
        }
    }
}
