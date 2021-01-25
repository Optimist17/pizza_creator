using System;
using System.Collections.Generic;
using System.Text;

namespace Lernen_3.Klassen
{
    public class Pizza
    {

        #region Attributes

        public Double Diameter { get; private set; }
        public Double Range { get; private set; }
        public String Name { get; private set; }

        #endregion


        #region Methods

        public void ChangeSize(Double diameter)
        {
            Diameter = diameter;
            Range = diameter * Math.PI;
        }

        #endregion

        #region Constructor

        public Pizza()
        {
            Diameter = 2;
        }

        public Pizza(String name, Double diameter)
        {
            ChangeSize(diameter);
            Name = name;
        }
        
        #endregion


    }
}
