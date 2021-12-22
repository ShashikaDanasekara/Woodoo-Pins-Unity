using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioManager))]
public class ScreenManager : MonoBehaviour
{
    AudioManager audioManager;

    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(KeyWords.startscreen);
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void GotoInstructionMenu()
    {
        audioManager.PlaySound(KeyWords.clicksound);
        SceneManager.LoadScene(KeyWords.instructionscreen);
    }

    public void GotoGamesScreen()
    {
        audioManager.PlaySound(KeyWords.clicksound);
        SceneManager.LoadScene(KeyWords.gamescreen);
    }

    public void QuitGame()
    {
        audioManager.PlaySound(KeyWords.clicksound);
        Application.Quit();
    }

}
