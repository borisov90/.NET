namespace MobilePhoneDevice
{
    using System;
    class Battery
    {
        //01
        string model;
        int? hoursidle;
        int? hourstalk;

        //03
        public enum batterytype
        {
            Lilon, NiMH, NiCD
        }
        private batterytype type;

        //02
        public int HoursIdle
        {
            get { return this.hoursidle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The idle time can't be negative");
                }
                else
                {
                    this.hoursidle = value;
                }
            }
        }
        public int HoursTalk
        {
            get { return this.hourstalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The talk time can't be negative");
                }
                else
                {
                    this.hourstalk = value;
                }
            }
        }
        public batterytype Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
