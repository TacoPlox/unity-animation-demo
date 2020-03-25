using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    private float timeAlive = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * 1f);
        timeAlive += Time.deltaTime;

        if (timeAlive > 3f)
        {
            Destroy(gameObject);
        }
    }
}
