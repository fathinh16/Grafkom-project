using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    private GameObject player;
    public Text scoreText;
    public Text pointsText;

    int score = 0;
    int final;
    int highscore = 0;

    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
     scoreText.text = score.ToString() + " Points"; 

    }

    public void AddPoint() {
        score+=10;
        scoreText.text = score.ToString() + " Points";
    }

    public void Setup()
    {
    	gameObject.SetActive(true);
    	pointsText.text  = score.ToString() + " Points";
    }
 
}
