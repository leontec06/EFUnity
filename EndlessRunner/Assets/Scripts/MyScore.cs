using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class MyScore : MonoBehaviour
{
    public PlayerMovement PlayerScore;
    public Score Script;
    public Text scoreText;
    public static int scorecount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text= "Score: " + PlayerScore.PlayerScore ;
    }
}
