
namespace MobilePhoneDevice
{
    using System;

    //01
    class Display
    {
        private int size;
        private int numberofcolors;
    //02    

        public int Size
        {
            get { return this.size; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display size cannot be a negative number");
                }
                else
                {
                    this.size = value;
                }
            }
        }
        public int NumberOfColors
        {
            get { return this.numberofcolors; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Enter positive number for the display colors");
                }
                else
                {
                    this.numberofcolors = value;
                }
            }
        }

        
    }
}
