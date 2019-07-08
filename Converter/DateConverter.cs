using System;

namespace MVVMPraticle.Converter { 
    public class DateConverter : IValueConverter
{
	    public object Convert(object value)
	    {
         DateTime date = (DateTime)value;
            date = DateTime.Today;
             return date.ToString("dd/mmm/yyyy");
	    }

        public object ConvertBack(object value)
        {
            return value;
        }
    }
}