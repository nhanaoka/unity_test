using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    UnityEngine.UI.Text scoreText;
    // Start is called before the first frame update
    private int score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int scoreAdd){
        score += scoreAdd;
        scoreText.text = "Score : " + score;
    }
}
