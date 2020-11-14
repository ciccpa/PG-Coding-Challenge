using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG_Coding_Challenge
{
    public class Customer
    {
        // Member variables
        private string m_Name;
        int m_Age;
        private string m_Gender;
        private string m_Condition;

        //****************************************************
        // Method: Customer()
        //
        // Default constructor. Fills member variables with
        //                               default data.
        //****************************************************
        public Customer()
        {
            m_Name = "NO_NAME";
            m_Gender = "NO_GENDER";
            m_Condition = "NO_CONDITION";
            m_Age = 0;
        }

        //****************************************************
        // Method: toString()
        //
        // Purpose: Formats member variable data to be printed on screen.
        //****************************************************
        public override string ToString()
        {
            return m_Name + ", " + m_Age + ", " + m_Gender + ", " + m_Condition + "\r";
        }

        //****************************************************
        // Method: CalculateEstimate()
        //
        // Calculates estimate based on the given criteria.
        //****************************************************
        public double CalculateEstimate()
        {
            // Check age first
            if(m_Age < 18)
            {
                Console.WriteLine("Invalid input. Must be at least 18.");
                return 0;
            }

            // Base annual cost
            double cost = 100;

            // Check and keep track of age every 5 yrs
            int counter = 5, i = 0;
            while(m_Age > 18 + counter)
            {
                i++;
                counter += 5;
            }

            // Multiply # of occurrences of 5 yrs * $20 additional fee
            double baseIncrease = i * 20;
            cost += baseIncrease;
         
            // Cost increase percentage set to 0.
            // This is in case the user has no underlying conditions
            double costIncrease = 0.0;
            // Set string to all caps to avoid case sensitivity
            m_Condition = m_Condition.ToUpper();
            m_Gender = m_Gender.ToUpper();
          
            // Health conditions specified here, used if statement
            // for sake of time. Could have used switch also.
            if (m_Condition == "ALLERGIES")
            {
                costIncrease = 1.01;
                cost = cost * costIncrease;
            } 
            else if (m_Condition == "SLEEP APNEA")
            {
                costIncrease = 1.06;
                cost = cost * costIncrease;
            }
            else if (m_Condition == "HEART DISEASE")
            {
                costIncrease = 1.17;
                cost = cost * costIncrease;
            }
            
            // Check gender last
            if (m_Gender == "FEMALE")
            {
                cost -= 12;
            }
            return cost;
        }

        // Member variables get/set 
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public int Age
        {
            get { return m_Age; }
            set { m_Age = value; }
        }
        public string Gender
        {
            get { return m_Gender; }
            set { m_Gender = value; }
        }

        public string Condition
        {
            get { return m_Condition; }
            set { m_Condition = value; }
        }
    }
}
