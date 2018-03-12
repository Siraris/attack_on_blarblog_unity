using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	private AudioSource _splashAudio;
	// Use this for initialization

	void Awake() {
		DontDestroyOnLoad(this);
	}

	void Start () {
		_splashAudio = GetComponent<AudioSource>();
		_splashAudio.Play();
		Invoke("LoadFirstLevel", 8f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void LoadFirstLevel() {
		SceneManager.LoadScene("Level 1");
	}
}
