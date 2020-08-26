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

        public Text availableFundsText, totalEarningsText;

        public static float availableFunds, totalEarnings;

        public IndividualItems click, thing1, thing2; //do need?

        #endregion

        void Start()
        {
            totalEarningsText = GameObject.Find("/Canvas/Score").GetComponent<Text>();
            availableFundsText = GetComponentInChildren<Text>();

            //do need?
            click = GameObject.Find("/Canvas/Upgrade Buttons/Upgrade Click").GetComponent<IndividualItems>();
            thing1 = GameObject.Find("/Canvas/Upgrade Buttons/Upgrade Thing1").GetComponent<IndividualItems>();
            thing2 = GameObject.Find("/Canvas/Upgrade Buttons/Upgrade Thing2").GetComponent<IndividualItems>();
        }

        void Update()
        {
            availableFundsText.text = "Available Funds: " + availableFunds.ToString();
            totalEarningsText.text = "Score: " + totalEarnings.ToString();
        }
    }
}