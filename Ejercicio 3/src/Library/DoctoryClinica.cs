using System;
using System.Text;

namespace Library
{
    public class Doctoryclinica
    {
        public string Datos(string appointmentPlace,string name, StringBuilder stringBuilder, bool isValid)
        {
            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }
            return stringBuilder;
        }
    }
}