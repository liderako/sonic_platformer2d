using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastEnemy : MonoBehaviour
{
    public Vector3 vl;
    public Vector3 vr;

    public bool right;
    
    // Start is called before the first frame update
    void Start()
    {
        vl = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
        vr = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (!right)
        {
            transform.position = Vector3.MoveTowards(transform.position, vl, 3 * Time.deltaTime);
            if (Vector3.Distance(transform.position, vl) < 0.0001f)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                right = true;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, vr, 3 * Time.deltaTime);
            if (Vector3.Distance(transform.position, vr) < 0.00001f)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                right = false;
            }
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
