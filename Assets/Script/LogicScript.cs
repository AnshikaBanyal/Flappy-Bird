using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text highScore;
    public GameObject gameOverScreen;
    public Text GO_Score;
    public Text GO_HighScore;
     public AudioSource scoreUp;

     void Start(){
        highScore.text = string.Format("Highest Score: {0:000}",PlayerPrefs.GetInt("HighScore",000).ToString() );
        GO_HighScore.text = string.Format("Highest Score: {0:000}",PlayerPrefs.GetInt("HighScore",000).ToString() );
        //highScore.text = ;
     }
    [ContextMenu("Increase Score")] //So that we can use it from unity it self
    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = string.Format("Score:{0:000}",playerScore);
        GO_Score.text = string.Format("Score:{0:000}",playerScore);
        //scoreText.text = playerScore.ToString();
        scoreUp.Play();
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", playerScore);
            
        }
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
       public void ExitGame() {
      SceneManager.LoadScene(0);
   }

    public void GameOver(){
        gameOverScreen.SetActive(true);
    }
}
