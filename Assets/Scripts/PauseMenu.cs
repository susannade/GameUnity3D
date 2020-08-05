using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

    public static bool paused=false;
    public GameObject UI;
        // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)){
            if(paused){
                ResumeTheGamePls();
            }
            else{
                StopTheGamePls();
            }
        }
    }
    public void ResumeTheGamePls(){
        UI.SetActive(false);
        Time.timeScale=1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible=false;
        paused=false;
    }
    void StopTheGamePls(){
        UI.SetActive(true);
        Time.timeScale=0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        paused=true;

    }
    public void Menu(){
        SceneManager.LoadScene(0);
        Time.timeScale=1f;
        paused=false;
    }
    public void Exit(){
        Application.Quit();
    }
}
