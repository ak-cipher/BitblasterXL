using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public int currentScore;

    public Text scoreTecxt;

    private void FixedUpdate()
    {
        this.scoreTecxt.text = currentScore.ToString();
    }

    public void RaiseScore(int points)
    {
        this.currentScore += points;
    }

}
