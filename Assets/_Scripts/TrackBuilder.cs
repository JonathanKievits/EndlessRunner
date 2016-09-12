﻿using UnityEngine;
using System.Collections;

public class TrackBuilder : MonoBehaviour {

    public GameObject[] Tracks;
    public Transform TrackSpawnerPos;
    public int TrackCount;
    public float NewPos;

    private int randomNum;
    private float waitTime;
    private GameObject track;

	void Start () {
        TrackCount = 0;
        NewPos = 20.0f;
        waitTime = 2.0f;
        Track();
	}

    public void Track()
    {
        track = Instantiate (Tracks [Random.Range(0,2)], TrackSpawnerPos.position, Quaternion.identity) as GameObject;
        Vector3 temp = TrackSpawnerPos.position;
        temp.y = 0;
        temp.x = 0;
        temp.z += 40;
        TrackSpawnerPos.position = temp;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        TrackCount += 1;
        Track();
    }
}
