using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

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

        public float winScore; //50 million

        public GameObject winPanel;

        public GameObject[] endGameDisableUi;
        #endregion

        void Update()
        {
            availableFundsText.text = "Available Funds: " + Mathf.RoundToInt(availableFunds).ToString();
            totalEarningsText.text = "Score: " + Mathf.RoundToInt(totalEarnings).ToString();

            if (totalEarnings > winScore)
            {
                EndGame();
            }
        }

        public void EndGame()
        {
            Time.timeScale = 0;
            winPanel.SetActive(true);

            for (int i = 0; i < endGameDisableUi.Length; i++)
            {
                endGameDisableUi[i].SetActive(false);
            }
        }

        public void Quit()
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#endif
            Application.Quit();
        }
    }
}