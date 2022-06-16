using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInfo : MonoBehaviour
{

    public string[] Materials;
    public GetToRecipe gtr;
    void Start()
    {
        gtr = GameObject.Find("RecipeData").GetComponent<GetToRecipe>();
    }

    
    void Update()
    {
        
    }

    public void MaterialsInfoSend()
    {
        gtr.RecipeMaterials = Materials;
        for(int i =0; i<Materials.Length;i++)
        {
            gtr.materialTexts[i].text = Materials[i];
        }
    }
}
