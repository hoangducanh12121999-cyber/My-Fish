using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject optionPanel;
    public GameObject cF2;
    public Button optionBtn;
    public Button resumeBtn;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cF2.SetActive(true);
        optionPanel.SetActive(false);
        OnButtonClick();


        Invoke("StartDelay", 0.1f);
    }

    void StartDelay()
    {
        GameEvent.eventScoreComplete.AddListener(UpdateScoreText);
    }

    void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();  
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
   
}
