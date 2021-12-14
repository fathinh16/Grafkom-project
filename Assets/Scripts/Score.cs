using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    private GameObject player;
    public Text scoreText;
    public Text pointsText;

    int score = 0;
    int currentScore;
    int final;
    int highscore = 0;

    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
     currentScore = score;
     scoreText.text = score.ToString() + " Points"; 

    }

    public void AddPoint() {
        currentScore+=10;
        scoreText.text = currentScore.ToString() + " Points";
                pointsText.text  = currentScore.ToString() + " Points";
    }

    public int GetPoint() {
        return currentScore;
    }

    public void Setup()
    {
    	gameObject.SetActive(true);
//    	pointsText.text  = currentScore.ToString() + " Points";
    }
 
}
