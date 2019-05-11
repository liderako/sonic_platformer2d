using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    
    public IEnumerator fadeDontTouch() {
        //isInvincible = true;
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        for (int i = 0; i < 10; i++) {
            sr.color = Color.clear;
            yield return new WaitForSeconds(0.1f);
            sr.color = Color.white;
            yield return new WaitForSeconds(0.1f);
        }
        gameObject.tag = "Ring";
        for (int i = 0; i < 10; i++) {
            sr.color = Color.clear;
            yield return new WaitForSeconds(0.1f);
            sr.color = Color.white;
            yield return new WaitForSeconds(0.1f);
        }
        Destroy(gameObject);
    }
}
