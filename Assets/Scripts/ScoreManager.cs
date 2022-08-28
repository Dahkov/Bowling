using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    private int score = 0;

    [SerializeField]
    private Text scoretext;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore() 
    {
        score++;
        scoretext.text = "Score: "+score.ToString();
    }

}
