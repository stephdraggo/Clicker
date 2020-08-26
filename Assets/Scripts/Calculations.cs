using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace my
{
    [AddComponentMenu("Game Systems/Calculations")]
    public class Calculations : MonoBehaviour
    {
        #region Variables
        [Header("Reference Variables")]

        public Text avaliableFundsText;
        public Text totalEarningsText, nameText, descriptionText, levelText, earnsText, upgradeCostText;

        public static float availableFunds, totalEarnings;

        public string description;
        public int level;
        public float earns, upgradeCost;

        #endregion

        void Start()
        {

        }

        void Update()
        {

        }
    }
}