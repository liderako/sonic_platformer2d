using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Tv : MonoBehaviour
{
    public string _type;

    public bool _dead;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (_dead)
            return;
        if (other.gameObject.tag == "Player" && (other.gameObject.GetComponent<Sonic>().isJumpball ||
                                                 other.gameObject.GetComponent<Sonic>().isRolling))
        {
            other.gameObject.GetComponent<Sonic>().destroy();
            gameObject.GetComponent<Animator>().SetBool("Dead", true);
            _dead = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            if (_type.Equals("TvCoin"))
            {
                GameManager.gm.scope += 10;
            }
            else if (_type.Equals("TvShield"))
            {
                GameObject.Find("Shield").GetComponent<SpriteRenderer>().enabled = true;
                other.gameObject.GetComponent<Sonic>().currentShield = GameObject.Find("Shield");
                other.gameObject.GetComponent<Sonic>().isShielded = true;
            }
            else if (_type.Equals("TvBoots"))
            {
                other.gameObject.GetComponent<Sonic>().speed = 30;
                GameObject.Find("BackgroundMusic").GetComponent<AudioSource>().pitch = 1.20f;
                StartCoroutine(bonusTvBootsEnd());
            }
        }
    }

    public IEnumerator bonusTvBootsEnd()
    {
        yield return new WaitForSeconds(15);
        GameObject.Find("Sonic").GetComponent<Sonic>().speed = 20;
        GameObject.Find("BackgroundMusic").GetComponent<AudioSource>().pitch = 1f;
    }
}
