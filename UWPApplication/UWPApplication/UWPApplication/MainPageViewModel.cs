using System;
using System.Collections.Generic;
using System.Text;

namespace UWPApplication
{
    public class MainPageViewModel : NotifyPropertyChangedHelper
    {
        public string MyProperty { get; set; }
        
        string xvalue;
        public string Xvalue
        {
            get { return xvalue; }
            set
            {
                SetProperty(ref xvalue, value);
                
            }
        }
        string yvalue;
        public string Yvalue
        {
            get { return yvalue; }
            set
            {
                SetProperty(ref yvalue, value);

            }
        }
        public MainPageViewModel()
        {            
            MyProperty="1.0.0";
        }

        public void SetXValue()
        {
            double value = (200 * Convert.ToDouble(Yvalue));
            value = value - 18675;
            Xvalue = (value / 32).ToString();
        }
        public void SetYValue()
        {
            double value = (32 * Convert.ToDouble(Xvalue));
            value = value + 18675;
            Yvalue = (value / 200).ToString();
        }
    }
}
