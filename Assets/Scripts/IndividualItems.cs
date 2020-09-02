using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace my
{
    [AddComponentMenu("Game Systems/Individual Items")]
    public class IndividualItems : MonoBehaviour
    {
        #region Variables
        [Header("Reference Variables")]
        public string label;
        public int level;
        public float earns, upgradeCost, costMultiplier;
        public Text labelText, levelText, upgradeCostText;
        #endregion

        void Start()
        {
            labelText.text = label; //display label
            levelText.text = "Lv:" + level.ToString(); //display level 0
            upgradeCostText.text = "$" + upgradeCost.ToString(); //display starting cost, does not work
        }


        public void Upgrade()
        {
            if (StaticData.availableFunds >= upgradeCost) //if have enought funds
            {
                StaticData.availableFunds -= upgradeCost; //take cost from funds
                level++; //increase level
                earns *= 2; //increase earnings
                upgradeCost *= costMultiplier; //increase cost
                levelText.text = "Lv:" + level.ToString(); //display new level
                upgradeCostText.text = "$" + upgradeCost.ToString(); //display new cost
            }
            else
            {
                Debug.Log("Not enough funds.");
            }
        }
    }
}