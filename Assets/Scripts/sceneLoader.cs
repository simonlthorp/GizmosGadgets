using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneLoader : MonoBehaviour {

    public void LoadTheLevel(string theLevel) {
        SceneManager.LoadScene(theLevel);
    }

    public void QuitTheGame() {
        Application.Quit();
    }

}
