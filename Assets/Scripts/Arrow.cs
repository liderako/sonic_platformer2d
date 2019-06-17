using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speedFly;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(dest());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x - 2, transform.position.y, transform.position.z), speedFly * Time.deltaTime);
    }
    
    
    public IEnumerator dest()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}


