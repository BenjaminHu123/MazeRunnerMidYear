using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Touch : MonoBehaviour {
    private ScoreTracker score;
    public AudioSource audio;
    private Transform t;
    private Transform cam;
    private void Start()
    {
        score = GetComponent<ScoreTracker>();
        t = GameObject.Find("FPSController").transform;
        cam = GetComponent<Transform>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene("Maze");
        }
        cam = t;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("coin"))
        {
            audio.Play();
            collision.transform.gameObject.SetActive(false);
            score.addScore();
        }
    }
}
