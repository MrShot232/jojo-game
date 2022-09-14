using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{

    int Click;
    Text ClickText;

    int TotalClick;
    GameObject ShopPanel;


    private void Update()
    {
        ClickText.text = Click + "";

        PlayerPrefs.GetInt("Click");
        PlayerPrefs.GetInt("TotalClick");

    }


    public void ButtonClick()
    {
        Click++;
        TotalClick++;

        PlayerPrefs.SetInt("Click", Click);
        PlayerPrefs.SetInt("TotalClick", TotalClick);
    }

    public void OnShopPanel()
    {
        ShopPanel.SetActive(!ShopPanel.activeSelf);
    }

    public void BuySkill()
    {
        if (Click >= 30)
        {
            Click *= 2;
        }
        else
        {
            Debug.Log("No click");
        }
    }



}
