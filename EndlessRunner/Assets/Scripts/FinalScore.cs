using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    //public PlayerMovement PlayerScore;
    public Text Finalscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Finalscore.text= "Score: "+ PlayerMovement.finalScore;
    }
}
