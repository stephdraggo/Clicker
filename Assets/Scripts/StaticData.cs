using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace my
{
    [AddComponentMenu("Game Systems/Satic Data")]
    public class StaticData : MonoBehaviour
    {
        #region Variables
        [Header("Reference Variables")]
        public Clicker click;

        public Idle[] things; //do need?

        public Text availableFundsText, totalEarningsText;

        public static float availableFunds, totalEarnings;

        #endregion

        void Update()
        {
            availableFundsText.text = "Available Funds: " + Mathf.RoundToInt(availableFunds).ToString();
            totalEarningsText.text = "Score: " + Mathf.RoundToInt(totalEarnings).ToString();
        }
    }
}