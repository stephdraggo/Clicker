using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace my
{
    [AddComponentMenu("Game Systems/Individual Items/Click")]
    public class Clicker : IndividualItems
    {
        public void Click()
        {
            StaticData.availableFunds += earns;
            StaticData.totalEarnings += earns;
        }
    }
}