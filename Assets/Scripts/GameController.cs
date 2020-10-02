using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject gameOver;
    // Start is called before the first frame update

    public static GameController instance;

    public int totalScore;
    public Text scoreText;

    public int totalbottle;
    public Text bottleText;

    public int totalMask;
    public Text maskText;

    public int totalDNA;
    public Text DNAText;

    void Start()
    {
        instance = this;
    }

    public void ShowGameOver(){
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName){
        SceneManager.LoadScene(lvlName);
    }

    public void UpdateScoreText(){
        scoreText.text = totalScore.ToString();
        bottleText.text = totalbottle.ToString();
        maskText.text = totalMask.ToString();
        DNAText.text = totalDNA.ToString();

    }
}
