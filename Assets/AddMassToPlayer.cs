using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMassToPlayer : MonoBehaviour
{
    GameObject player;

    Rigidbody2D rb;

    float initialMass;

    // Public faz com que a Unity exiba esse valor
    public float mass;

    public float duration;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        rb = player.GetComponent<Rigidbody2D>();

        initialMass = rb.mass;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    Detectar que o jogador passou pelo nosso trigger
    Pegar o Rigidbody do Jogador e adicionar uma massa
    */

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            rb.mass = mass;

            Invoke("ResetMass", duration);
        }
    }

    void ResetMass() {
        rb.mass = initialMass;
    }
}
