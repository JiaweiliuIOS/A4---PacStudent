using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button myButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame(){
        DontDestroyOnLoad(this);
        SceneManager.LoadSceneAsync(1);
    }

     public void QuitGame()
    {
        SceneManager.LoadSceneAsync(0);
        Debug.Log("Quit is clicked");}
}
