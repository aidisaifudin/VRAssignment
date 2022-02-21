using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseBtn : MonoBehaviour
{

    
   
    public GameObject resumeBtn;
    public GameObject pauseButton;
    public AudioSource audio;
    public AudioSource audioTwo;




    public void PausedOnPress()
    {
        
        
        pauseButton.SetActive(false);
        resumeBtn.SetActive(true);
        Time.timeScale = 0;
        audio.Stop();
        audioTwo.Stop();
        
    }

    public void ResumeOnPress()
    {
        
        pauseButton.SetActive(true);
        resumeBtn.SetActive(false);
        Time.timeScale = 1;
        audio.Play();
        audioTwo.Play();
    }
}
