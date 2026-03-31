using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            Time.timeScale = 1;
            AudioManager.Instance.MenuMusic();
        }
        
    }
   
    public void OnButtonClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        AudioManager.Instance.OnButtonClickMusic();
    }
    public void OnExit()
    {
        Application.Quit();
    }
}
