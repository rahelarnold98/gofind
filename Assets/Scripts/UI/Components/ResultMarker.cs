﻿using Assets.Modules.CineastAPI;
using UnityEngine;

namespace Assets.Scripts.UI {
    public class ResultMarker : MonoBehaviour {

        public MultimediaObject result;

        public UIManager uiManager;

        public void HandleClicked() {
            Debug.Log("Clicked and showing"+ result.resultIndex);
            uiManager.ShowResultPanel(result);
        }
    }
}