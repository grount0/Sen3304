using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class GetToRecipe : MonoBehaviour
{
    public Image recipeImage,materialPageImage;
    public VideoPlayer vp;

    public TextMeshProUGUI recipeText;
    
    public GameObject RecipeCanvas, HTCCanvas;
    public string[] RecipeMaterials;

    public Text[] materialTexts;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

       
    }
    public void OpenCanvas()
    {
        HTCCanvas.SetActive(true);
        RecipeCanvas.SetActive(false);
    }
    public void GetToTheRecipe(Sprite image)
    {
        
        recipeImage.sprite = image;
        materialPageImage.sprite = image;
        
        
       
    }
    public void GetVideoClip(VideoClip vc)
    {
       vp.clip = vc;
    }
    public void GetExplanation(string exp)
    {

        recipeText.text = exp;
    }
}
