using UnityEngine;
using System.Collections;

public class TrackDestroyer : MonoBehaviour {

    private float destroyTime;

    void Start () {
        destroyTime = 8.0f;
        Destroyer();
	}
	
	void Destroyer()
    {
        StartCoroutine(Breaker());
    }

    IEnumerator Breaker()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }
}
