using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectManager : MonoBehaviour
{
    public GameObject gm1;

    public GameObject gm2;
    
    public GameObject gm3;

    public GameObject gm4;

    public GameObject text;

    private int _current;
    // Start is called before the first frame update
    void Start()
    {
        _current = 1;
        text.gameObject.GetComponent<Text>().text = "Best Scope : " + PlayerPrefs.GetInt("scope1").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (_current == 2)
        {
            text.gameObject.GetComponent<Text>().text = "Best Scope : " + PlayerPrefs.GetInt("scope2").ToString();
        }
        else if (_current == 1)
        {
            text.gameObject.GetComponent<Text>().text = "Best Scope : " + PlayerPrefs.GetInt("scope1").ToString();
        }
        else if (_current == 3)
        {
            text.gameObject.GetComponent<Text>().text = "Best Scope : " + PlayerPrefs.GetInt("scope3").ToString();
        }
        else if (_current == 4)
        {
            text.gameObject.GetComponent<Text>().text = "Best Scope : " + PlayerPrefs.GetInt("scope4").ToString();
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gm1.SetActive(false);
            gm2.SetActive(true);
            gm3.SetActive(false);
            gm4.SetActive(false);
            _current = 2;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gm1.SetActive(true);
            gm2.SetActive(false);
            gm3.SetActive(false);
            gm4.SetActive(false);
            _current = 1;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            _current = 3;
            gm1.SetActive(false);
            gm2.SetActive(false);
            gm3.SetActive(true);
            gm4.SetActive(false);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _current = 4;
            gm1.SetActive(false);
            gm2.SetActive(false);
            gm3.SetActive(false);
            gm4.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("current " + _current.ToString());
            if (_current == 2 && PlayerPrefs.GetInt("level2") == 1)
            {
                SceneManager.LoadScene("Level2", LoadSceneMode.Single);
            }
            else if (_current == 1 && PlayerPrefs.GetInt("level1") == 1)
            {
                SceneManager.LoadScene("Level1", LoadSceneMode.Single);
            }
            else if (_current == 3 && PlayerPrefs.GetInt("level3") == 1)
            {
                SceneManager.LoadScene("Level3", LoadSceneMode.Single);
            }
            else if (_current == 4 && PlayerPrefs.GetInt("level4") == 1)
            {
                SceneManager.LoadScene("Level4", LoadSceneMode.Single);
            }
        }
    }
}
