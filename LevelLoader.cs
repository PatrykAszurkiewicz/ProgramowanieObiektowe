using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int TimeToWait = 3;
    int CurrentSceneIndex;

    public float czas = 5;
    // Start is called before the first frame update
    void Start()
    {
        CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(CurrentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartScreen");
        }
    }
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(TimeToWait);
        LoadNextScene();
    }
    public void LoadMenu()
    {
        Time.timeScale = 1;
        Invoke("TimerMenu", czas);
    }
    void TimerMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        Invoke("TimerRestart", czas);
    }
    void TimerRestart()
    {
        SceneManager.LoadScene(CurrentSceneIndex);
    }

    public void LoadOptionsScreen()
    {
        Invoke("TimerOptions", czas);
    }
    void TimerOptions()
    {
        SceneManager.LoadScene("OptionsScreen");
    }

    public void LoadNextScene()
    {
        Invoke("TimerStartGame", czas);
    }
    void TimerStartGame()
    {
        SceneManager.LoadScene(CurrentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
