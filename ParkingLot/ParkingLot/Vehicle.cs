using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    class Vehicle // כלי תחבורה
    {
        private int _numberOfOwner; // יד של האוטו
        private int _km;
        private string _color;
        private double _price; //שווי כלי תחבורה
        private int _year; // שנת ייצור
        private string _manufacturer; // שם החברה- נגיד קיה 
        private string _model;// מודל - פיקנטו
        private string _engineCapacity; // נפח מנוע
        private int _numberwheel;// כמות גלגלים
        private string _gearBox; // תיבת הילוכים

    }

    /// <summary>
    /// ///////// רכב 
    /// </summary>

    class FourWheels : Vehicle //car - 4 גלגלים
    {
        private double _weight; // משקל הרכב
        private double _height;// גובה
        private int _propulsion;// הנעה- 4 על 4 
        private int _length;// אורך
    }
    class PrivateCar : FourWheels //רכב פרטי 
    {
        private int _door;// מספר דלתות
        private string _Extra; // רמת גימור - גג נפתח 
    }
    class Truck : FourWheels// משאית 
    {
        private double _storage;// אחסון
        private string _crane; // מנוף
        private string _type; // סוג המשאית
        private string _requrimentLicense; // רישיון נהיגה

    }


    /// <summary>
    /// דו גלגלי 
    /// </summary>
    class TwoWheels : Vehicle // דו גלגלי
    {
        private double _weight;
        private string _requrimentLicense; // רישיון נהיגה
        private int _motoSeat; // מוגבל ל2 מקומות 
        

    }
}
