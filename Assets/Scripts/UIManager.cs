using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject optionPanel;
    public GameObject cF2;
    public Button optionBtn;
    public Button resumeBtn;
    public GameObject gameOverPanel;


    public static UIManager Instance;
    void Awake()
    {
        /*if (Instance == null)
         {
             Instance = this;
             DontDestroyOnLoad(gameObject);
         }
         else
         {
             Destroy(gameObject);
         }*/
        Time.timeScale = 1;
        AudioManager.Instance.HUDMusic();
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cF2.SetActive(true);
        optionPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        OnButtonClick();


        Invoke("StartDelay", 0.1f);
    }

    void StartDelay()
    {
        GameEvent.eventScoreComplete.AddListener(UpdateScoreText);

        GameEvent.eventHighScore.AddListener(UpdateHighScoreText);
    }

    void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();  
    }

    void UpdateHighScoreText(int highScore)
    {
        highScoreText.text = highScore.ToString();
    }

    public void OnButtonClick()
    {
        optionBtn.onClick.AddListener(OnClickOption);
        resumeBtn.onClick.AddListener(OnClickResume);
    }

    private void OnClickOption()
    {
        if (optionPanel.activeSelf == false && cF2.activeSelf == true)
        {
            AudioManager.Instance.OnButtonClickMusic();
            optionPanel.SetActive(true);
            cF2.SetActive(false);
            Time.timeScale = 0;
            Debug.Log("Option");
        }
    }

    private void OnClickResume()
    {
        if (optionPanel.activeSelf == true && cF2.activeSelf == false)
        {
            AudioManager.Instance.OnButtonClickMusic();
            optionPanel.SetActive(false);
            cF2.SetActive(true);
            Time.timeScale = 1;
            Debug.Log("Resume");
        }
    }

    public void GameOverUI()
    {
        gameOverPanel.SetActive(true);
        cF2.SetActive(false);
    }

    public void RestartGame()
    {
        AudioManager.Instance.OnButtonClickMusic();
        AudioManager.Instance.HUDMusic();
    }
}
