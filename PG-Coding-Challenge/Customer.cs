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
        private double cost;
        private double covgAmount;

        public Customer()
        {
            m_Name = "NO_NAME";
            m_Gender = "NO_GENDER";
            m_Condition = "NO_CONDITION";
            m_Age = 0;
            cost = 100;
            covgAmount = 500000.0;
        }

        public override string ToString()
        {
            return $"-------------------\nName: {m_Name}\nAge: {m_Age}\nGender: {m_Gender}\nCondition: {m_Condition}\nCoverage amount: {covgAmount}\n-------------------";
        }

        public void CalculateAge()
        {
            int ageDiff = m_Age - 18;
            int timesOver = ageDiff / 5;
            cost += timesOver * 20;
        }

        public void CalculateCovg()
        {
            // covgdiff = 1250000 - 500000 = 750000
            // covgIncrease = 750000 / 2500000 = 3 . 15
            // coverage amount = 45%

            double covgDiff = covgAmount - 500000; // 750000
            double covgIncrease = covgDiff / 250000 * .15; // 3
           // Console.WriteLine("Current cost: " + cost); // 220

            cost += cost * covgIncrease; // 880
        }

        public void CalculateCondition()
        {
            m_Condition = m_Condition.ToUpper();
            m_Gender = m_Gender.ToUpper();

            var conditionDictionary = new Dictionary<string, double>()
            {
                {"ALLERGIES", 1.01 },
                {"SLEEP APNEA", 1.06 },
                { "HEART DISEASE", 1.17 }
            };

            double costIncrease = 0.0;
            costIncrease = conditionDictionary[m_Condition];
            cost = cost * costIncrease;
        }

        public double CalculateEstimate()
        {
            // Check age first
            if(m_Age < 18)
            {
                Console.WriteLine("Invalid input. Must be at least 18.");
                return 0;
            }

            CalculateAge();
            CalculateCovg();
            CalculateCondition();
            
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
        public double CovgAmount
        {
            get { return covgAmount; }
            set { covgAmount = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
