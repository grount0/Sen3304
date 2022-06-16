using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneChange : MonoBehaviour
{

    public GameObject  OrderCanvas,RecipeCanvas,HowToCookCv,OrderCompletePanel;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void GoOrderPage()
    {
        OrderCanvas.SetActive(true);
        gameObject.SetActive(false);
    }
    public void BackSceneFromHowToCook()
    {
        RecipeCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

    public void BackSceneFromOrder()
    {
        gameObject.SetActive(false);
        HowToCookCv.SetActive(true);
    }

    public void OpenOrderCompletePanel()
    {
        OrderCompletePanel.SetActive(true);
    }
    public void CloseOrderCompletePanel()
    {
        OrderCompletePanel.SetActive(false);
    }

   
}
