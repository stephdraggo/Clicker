using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace my
{
    [AddComponentMenu("Game Systems/Individual Items/Idle")]
    public class Idle : IndividualItems
    {
        public bool bought = false;

        void Update()
        {
            if (bought)
            {
                StaticData.availableFunds += earns * Time.deltaTime;
                StaticData.totalEarnings += earns * Time.deltaTime;
            }
        }

        public void BuyOne()
        {
            if (StaticData.availableFunds >= upgradeCost)
            {
                bought = true;
            }
        }
    }
}