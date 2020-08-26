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
        public float earns, upgradeCost;

        public Text labelText, levelText, upgradeCostText;

        #endregion

        void Start()
        {
            labelText = Transform.Find("Label").gameObject.GetComponent<Text>();
            levelText = GetComponentInChildren<Text>();
            upgradeCostText = GetComponentInChildren<Text>();
            level = 1;
        }

        void Update()
        {
            StaticData.availableFunds += earns * Time.deltaTime;

        }
    }
}