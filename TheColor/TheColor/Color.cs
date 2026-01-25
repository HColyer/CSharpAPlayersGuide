using System;
using System.Collections.Generic;
using System.Text;

namespace TheColor
{
    internal class Color
    {
        public byte RedValue { get; private set; }
        public byte GreenValue { get; private set; }
        public byte BlueValue { get; private set; }

        public Color(byte red, byte green, byte blue)
        {
            RedValue = red;
            GreenValue = green;
            BlueValue = blue;
        }

        public static Color Red
        {
            get
            {
                return new Color(255, 0, 0);
            }
        }

        public static Color Green
        {
            get
            {
                return new Color(0, 255, 0);
            }
        }

        public static Color Blue
        {
            get
            {
                return new Color(0, 0, 255);
            }
        }

        public static Color Purple
        {
            get
            {
                return new Color(128, 0 , 128);
            }
        }

        public static Color Yellow
        {
            get
            {
                return new Color(255, 255, 0);
            }
        }

        public static Color Orange
        {
            get
            {
                return new Color(255, 165, 0);
            }
        }

        public static Color Black
        {
            get
            {
                return new Color(0, 0, 0);
            }
        }

        public static Color White
        {
            get
            {
                return new Color(255, 255, 255);
            }
        }
    }
}
