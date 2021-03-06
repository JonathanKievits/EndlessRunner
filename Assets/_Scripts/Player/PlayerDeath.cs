﻿using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour 
{
    [SerializeField]private AudioClip hurt;
    private PlayerAudio playerAudio;


    private void Start()
    {
        playerAudio = GameObject.FindObjectOfType<PlayerAudio>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            DeathAnimation.deathAnimation.Death();
            StartCoroutine(StopGame());
        }
    }

    IEnumerator StopGame()
    {
        playerAudio.PlayAudio(hurt, false);
        Score.score_script.enabled = false;
        PlayerMovement.player_movement.enabled = false;
        TrackBuilder.track_builder.enabled = false;
        yield return new WaitForSeconds(1f);
        SceneSwitcher.scene_switcher.Retry_Scene();
    }
}
