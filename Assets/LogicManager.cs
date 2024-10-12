using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(){
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver(){
        GameOverScreen.SetActive(true);
    }
    public void ExitGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
