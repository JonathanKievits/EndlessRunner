using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

    public void LoadStage()
    {
        SceneManager.LoadScene("main_Scene");
    }
}
