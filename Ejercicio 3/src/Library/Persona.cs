using System;
using System.Text;

namespace Library
{
    public class Persona
    {
        public string DatosPersona(string name, string id, string phoneNumber, StringBuilder stringBuilder, bool isValid)
        {
            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }
            return stringBuilder;
        }
    }
}