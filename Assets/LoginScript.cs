using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginScript : MonoBehaviour
{
    public string trueUserName, truePassword;
     
    public GameObject recipeCanvas;
    public TMP_InputField userNameInput, passwordInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Login()
    {
        if(userNameInput.text==trueUserName && passwordInput.text==truePassword)
        {
            recipeCanvas.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
