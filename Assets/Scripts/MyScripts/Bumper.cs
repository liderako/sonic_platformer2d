using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public int x;

    public int y;

    public GameObject _child;

    public AudioSource audioSouce;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("Sonic").gameObject.GetComponent<Sonic>().bumper(x, y);
            audioSouce.Play(1);
            StartCoroutine(spriteChange());
        }
    }

    public IEnumerator spriteChange()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        _child.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        _child.SetActive(false);
    }
}
