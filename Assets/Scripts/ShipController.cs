using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    private Animator animator;
    public GameObject shootingParticles;
    public float movementSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Fire();
        }

        if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
        {
            transform.Translate(new Vector2(Input.GetAxis("Horizontal") * movementSpeed, Input.GetAxis("Vertical") * movementSpeed));
        }
    }

    public void Fire() {
        Debug.Log("Pew!");
        GameObject particles = Instantiate(shootingParticles, transform.position + new Vector3(0f, 1f, 0f), transform.rotation);
        particles.transform.parent = transform;
    }
}
