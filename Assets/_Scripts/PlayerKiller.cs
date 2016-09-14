using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerKiller : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            SceneManager.LoadScene("retry_Scene");
        }
    }
}
