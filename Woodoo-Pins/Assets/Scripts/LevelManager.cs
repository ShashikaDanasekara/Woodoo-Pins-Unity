using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    bool isGameEnded = false;

    Rotator rotator;
    Spawner spawner;
    Animator animator;

    [SerializeField] float restartWait = 2f;

    private void Start()
    {
        rotator = FindObjectOfType<Rotator>().GetComponent<Rotator>();
        spawner = FindObjectOfType<Spawner>().GetComponent<Spawner>();
        animator = GetComponent<Animator>();
    }


    public void EndGame()
    {
        if (isGameEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger(KeyWords.endgame);

        isGameEnded = true;
        Debug.Log("End Game");
        
    }

    public void RestartGame()
    {
        Invoke("Restart", restartWait);
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(KeyWords.startscreen);
    }

    public void GotoInstructionMenu()
    {
        SceneManager.LoadScene(KeyWords.instructionscreen);
    }

    public void GotoGamesScreen()
    {
        SceneManager.LoadScene(KeyWords.gamescreen);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
