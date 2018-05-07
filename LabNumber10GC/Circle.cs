using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber10GC
{
    class Circle
    {
        //data members
        #region DataMembers
        private double radius;
        #endregion


        //Properties
        #region Properties
        public double Radius
        {
            set
            {
                radius = value;
            }
            get
            {
                return radius;
            }
        }
        #endregion

        #region Methods
        public double CalculateCircumference()
        {
            
            double circum = (2 * (Math.PI * Radius));
            return circum;
        }
        public double CalculateArea()
        {
            double area = (Math.PI * (Radius * Radius));
            return area;
        }

        public string CalculateFormattedCircumference()
        {
            string formattedString = $"{CalculateCircumference(), 0:N2}";
            return formattedString;
        }

        public string CalculateFormattedArea()
        {
            string formattedArea = $"{CalculateArea(),0:N2}";

                return formattedArea;
        }

        #endregion
    }





}
