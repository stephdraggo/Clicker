using UnityEngine;

namespace my
{
    [AddComponentMenu("Game Systems/Individual Items/Click")]
    public class Clicker : IndividualItems
    {
        public void Click()
        {
            StaticData.availableFunds += earns; //add funds according to how much a click is worth
            StaticData.totalEarnings += earns; //add to total score
        }
    }
}