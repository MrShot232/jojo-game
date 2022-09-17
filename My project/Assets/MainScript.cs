using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{

    public int Click;
    public Text ClickText;

    public int TotalClick;
    public GameObject ShopPanel;

    private void Start()
    {
        ClickText.text = Click + "";
    }


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
