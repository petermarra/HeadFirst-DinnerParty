using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner_Party
{
    public class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations=0;

        public void CalculateCostOfDecorations(bool calculateCostOfDecorations)
        {
            if (calculateCostOfDecorations)
            {
                CostOfDecorations = (15.00m * NumberOfPeople) + 50m;
            }
            else
            {
                CostOfDecorations = (7.50m * NumberOfPeople) + 30m;
            }

        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00m;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00m;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal total = (CostOfDecorations +
                            (CostOfFoodPerPerson * NumberOfPeople) +
                            (CostOfBeveragesPerPerson* NumberOfPeople));

            if (healthyOption)
            {
                return total* .95m;
            }
            else
            {
                return total;
            }
        }
    }

}
