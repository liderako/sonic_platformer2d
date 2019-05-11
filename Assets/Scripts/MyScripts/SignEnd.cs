using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SignEnd : MonoBehaviour
{
    public Animator animator;

    public AudioSource audioSource;

    private float oldTime;

    public GameObject _gameObject;
    public GameObject _panel;
    
    private bool music;

    public bool end;

    public int level;
    //
    
    void Update()
    {
        if (!end && music == true && Time.time - oldTime >= 6)
        {
            Debug.Log("SCOPE");
            music = false;
            end = true;
            animator.SetBool("End", false);
            _gameObject.SetActive(true);
            _panel.SetActive(true);
            _gameObject.GetComponent<Text>().text = "Scope :" + GameManager.gm.calcScope();
            oldTime = Time.time;
        }
        if (end && Time.time - oldTime > 2)
        {
            if (level == 1)
            {
                PlayerPrefs.SetInt("scope1", GameManager.gm.calcScope());
                PlayerPrefs.SetInt("level2", 1);
            }
            else if (level == 2)
            {
                PlayerPrefs.SetInt("scope2", GameManager.gm.calcScope());
                PlayerPrefs.SetInt("level3", 1);
            }
            else if (level == 3)
            {
                PlayerPrefs.SetInt("scope3", GameManager.gm.calcScope());
                PlayerPrefs.SetInt("level4", 1);
            }
            else if (level == 4)
            {
                PlayerPrefs.SetInt("scope4", GameManager.gm.calcScope());
            }
            PlayerPrefs.SetInt("rings", PlayerPrefs.GetInt("rings") + GameManager.gm.scope);
            PlayerPrefs.Save();
            SceneManager.LoadScene("DataSelect", LoadSceneMode.Single);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !music)
        {
            animator.SetBool("End", true);
            audioSource.GetComponent<AudioSource>();
            audioSource.Play(1);
            oldTime = Time.time;
            music = true;
        }
    }
}
