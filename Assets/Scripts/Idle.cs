using UnityEngine;

namespace my
{
    [AddComponentMenu("Game Systems/Individual Items/Idle")]
    public class Idle : IndividualItems
    {
        public bool bought = false;

        void Update()
        {
            if (bought) //if this button has been bought
            {
                StaticData.availableFunds += earns * Time.deltaTime; //increase funds according to earning level
                StaticData.totalEarnings += earns * Time.deltaTime; //increase total score
            }
        }

        public void BuyOne()
        {
            if (StaticData.availableFunds >= upgradeCost && bought == false) //if enough funds are available and the button has not been bought before
            {
                bought = true; //set button to bought
            }
        }
    }
}