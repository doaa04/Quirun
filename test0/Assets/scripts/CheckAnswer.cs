using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckAnswer : MonoBehaviour
{
    public GameObject questionPanel;
    public PlayerMvt movement;

    public void CorrectAnswer()
    {
        Time.timeScale = 1; 
        questionPanel.SetActive(false);
        movement.enabled = true;

    }

    public void WrongAnswer()
    {
        SceneManager.LoadScene(0);

    }
}
