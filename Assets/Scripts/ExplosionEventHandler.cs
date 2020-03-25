using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEventHandler : MonoBehaviour
{

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimationEnded() {
        Debug.Log("Animation ended!");
        
        Instantiate(projectile, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
