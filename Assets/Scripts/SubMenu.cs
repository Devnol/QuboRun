﻿using UnityEngine;

public class SubMenu: MonoBehaviour
{  
    public GameObject MenuPanel;
    public void ShowMenu() {
        MenuPanel.SetActive(true); 
    }

    public void HideMenu() {
        MenuPanel.SetActive(false);
    }
}
