using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        public dynamic carID { get; set; }
        public dynamic somethingID { get; set; }
        public dynamic title { get; set; }
        public dynamic somethingBoolean { get; set; }

        public Car(dynamic carID, dynamic somethingID, dynamic title, dynamic somethingBoolean)
        {
            this.carID = carID;
            this.somethingID = somethingID;
            this.title = title;
            this.somethingBoolean = somethingBoolean;
        }

    }
}
