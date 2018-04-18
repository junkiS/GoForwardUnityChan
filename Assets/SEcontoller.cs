using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEcontoller : MonoBehaviour {

    public GameObject CubePrefab;

    public GameObject ground;

    public AudioClip audioClip;//

    AudioSource audioSource;

                            // Use this for initialization
    void Start () {

        audioSource = gameObject.GetComponent<AudioSource>();//AudioSourceコンポーネント取得
        audioSource.clip = audioClip;

    }
	
	// Update is called once per frame
	void Update () {

    }
    void OnCollisionEnter2D(Collision2D other)//衝突判定　if文でcubeTagとgroundTagで接触判定させる。
    {
        if (other.gameObject.tag == "ground ")
        {
            audioSource.PlayOneShot(audioClip);
        }
        if (other.gameObject.tag == "CubePrefab")
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}

