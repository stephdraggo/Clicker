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

        public Color affordable, notAffordable;

        public Idle[] things;

        public Text availableFundsText, totalEarningsText;

        public static float availableFunds, totalEarnings;

        public float winScore; //50 million

        public GameObject winPanel;

        public GameObject[] endGameDisableUi;
        #endregion

        void Update()
        {
            #region score
            availableFundsText.text = "Available Funds: " + Mathf.RoundToInt(availableFunds).ToString(); //available funds ui
            totalEarningsText.text = "Score: " + Mathf.RoundToInt(totalEarnings).ToString(); //score ui

            if (totalEarnings > winScore) //win condition
            {
                EndGame();
            }
            #endregion
            EnableButtons();
            UpdateButtonColour();
        }
        #region Functions
        public void EnableButtons()
        {
            for (int i = 0; i < things.Length; i++) //for all 
            {
                if (totalEarnings > things[i].upgradeCost && !things[i].gameObject.activeSelf)
                {
                    things[i].gameObject.SetActive(true);
                }
            }
        }

        public void UpdateButtonColour()
        {
            for (int i = 0; i < things.Length; i++)
            {
                Image background = things[i].gameObject.GetComponentInChildren<Image>();
                if (availableFunds > things[i].upgradeCost)
                {
                    background.color = affordable;
                }
                else
                {
                    background.color = notAffordable;
                }
            }
            {
                Image clickColour = click.gameObject.GetComponentInChildren<Image>();
                if (availableFunds > click.upgradeCost)
                {
                    clickColour.color = affordable;
                }
                else
                {
                    clickColour.color = notAffordable;
                }
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
            for (int i = 0; i < things.Length; i++)
            {
                things[i].gameObject.SetActive(false);
            }
        }

        public void Quit()
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#endif
            Application.Quit();
        }
        #endregion
    }
}