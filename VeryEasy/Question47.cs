using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.VeryEasy
{
    class Question47
    {
        public string MissingAngle(int a1, int a2)
        {
            string sz = "";
            if((a1+a2)>90) sz = "acute";
            if ((a1 + a2) < 90) sz = "obtuse";
            if ((a1 + a2) == 90) sz = "right";  
            return sz;
        }
        public string MissingAngle1(int a1, int a2)
        {
            string sz = "";
            if ((a1 + a2) > 90) sz = "acute";
            if ((a1 + a2) < 90) sz = "obtuse";
            if ((a1 + a2) == 90) sz = "right";
            return sz;
        }
        public string MissingAngle2(int a1, int a2)
        {
            string sz = "";
            if ((a1 + a2) > 90) sz = "acute";
            if ((a1 + a2) < 90) sz = "obtuse";
            if ((a1 + a2) == 90) sz = "right";
            return sz;
        }
    }
}
