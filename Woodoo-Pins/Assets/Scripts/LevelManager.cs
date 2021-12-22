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
    AudioManager audioManager;

    [SerializeField] float restartWait = 2f;

    private void Start()
    {
        rotator = FindObjectOfType<Rotator>().GetComponent<Rotator>();
        spawner = FindObjectOfType<Spawner>().GetComponent<Spawner>();
        animator = GetComponent<Animator>();
        audioManager = FindObjectOfType<AudioManager>();
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

}
