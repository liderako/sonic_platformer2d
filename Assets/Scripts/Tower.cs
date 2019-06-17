using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject _arrow;

    [SerializeField]public float speedFire;

    private float oldTime;
    
    // Start is called before the first frame update
    void Start()
    {
        oldTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - oldTime > speedFire)
        {
            GameObject go = Instantiate(_arrow, gameObject.transform.position, Quaternion.identity);
            go.GetComponent<Arrow>().enabled = true;
            oldTime = Time.time;
        }
    }
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && (other.gameObject.GetComponent<Sonic>().isJumpball ||
                                                 other.gameObject.GetComponent<Sonic>().isRolling))
        {
            GameManager.gm.scope2 += 500;
            other.gameObject.GetComponent<Sonic>().destroy();
            Destroy(gameObject);
        }
    }
}
