using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class RecipeListChange : MonoBehaviour
{

    public GameObject[] RecipeList;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ChangeList(int id)
    {
        RecipeList[id].SetActive(true);
        for(int i =0; i<RecipeList.Length;i++)
        {
            if(i != id)
            {
                RecipeList[i].SetActive(false);
            }
        }
    }
    public void GetToTheRecipe(Image image,VideoClip videoClip,string explanation)
    {

    }

}
