using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MyScore : MonoBehaviour
{
    public Text scoreText;
    [SerializeField] public string bruh;
    public static int scorecount;

    [SerializeField] private Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text= "Score" +0 ;
    }
}
