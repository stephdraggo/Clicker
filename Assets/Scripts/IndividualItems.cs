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
            levelText.text = "Lv:" + level.ToString(); //display level
            upgradeCostText.text = "$" + upgradeCost.ToString(); //display cost
        }

        public void Upgrade()
        {
            if (StaticData.availableFunds >= upgradeCost) //if have enough funds
            {
                StaticData.availableFunds -= upgradeCost; //take cost from funds
                level++; //increase level
                earns *= 2; //increase earnings
                upgradeCost *= costMultiplier; //increase cost
                levelText.text = "Lv:" + level.ToString(); //display new level
                upgradeCostText.text = "$" + upgradeCost.ToString(); //display new cost
            }
#if UNITY_EDITOR
            else
            {
                Debug.Log("Not enough funds.");
            }
#endif
        }
    }
}