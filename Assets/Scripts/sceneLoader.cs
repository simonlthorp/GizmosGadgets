using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneLoader : MonoBehaviour {
    // store scene
    public void LoadTheLevel(string theLevel) {
        SceneManager.LoadScene(theLevel);
    }
    //gameOver scene
    //public void onGameOver()
    //{
    //    SceneManager.LoadScene("gameover");
    //}
    ////mainMenu scene
    //public void onMainMenu()
    //{
    //    SceneManager.LoadScene("Menu");
    //}
    ////Ranking scene
    //public void onRanking()
    //{
    //    SceneManager.LoadScene("Ranking");
    //}
    public void QuitTheGame() {
        Application.Quit();
    }

}
