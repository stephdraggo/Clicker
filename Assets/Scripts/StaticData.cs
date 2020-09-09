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

        public Idle[] idleButtons;

        public Text availableFundsText, totalEarningsText;

        public static float availableFunds, totalEarnings;

        public float winScore;

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
            for (int i = 0; i < idleButtons.Length; i++) //for all buttons
            {
                if (totalEarnings > idleButtons[i].upgradeCost && !idleButtons[i].gameObject.activeSelf) //if total score has reached their cost and the button is not active
                {
                    idleButtons[i].gameObject.SetActive(true); //activate the button
                }
            }
        }

        public void UpdateButtonColour()
        {
            for (int i = 0; i < idleButtons.Length; i++) //for all buttons
            {
                Image background = idleButtons[i].gameObject.GetComponentInChildren<Image>(); //get the background image (colour)
                if (availableFunds > idleButtons[i].upgradeCost) //if button is affordable with available funds
                {
                    background.color = affordable; //set colour to affordable colour (white)
                }
                else //if button is not affordable
                {
                    background.color = notAffordable; //set colour to not affordable (grey)
                }
            }
            {
                Image clickColour = click.gameObject.GetComponentInChildren<Image>(); //for the mouse click button
                if (availableFunds > click.upgradeCost) //if affordable
                {
                    clickColour.color = affordable; //colour white
                }
                else //if not affordable
                {
                    clickColour.color = notAffordable; //colour grey
                }
            }
        }

        public void EndGame()
        {
            Time.timeScale = 0; //stop time
            winPanel.SetActive(true); //enable the win panel

            for (int i = 0; i < endGameDisableUi.Length; i++) //for all gameobjects to disable on end game
            {
                endGameDisableUi[i].SetActive(false); //disable them
            }
            for (int i = 0; i < idleButtons.Length; i++) //for all idle upgrade buttons
            {
                idleButtons[i].gameObject.SetActive(false); //disable them
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