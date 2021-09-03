using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMassToPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            var rb = other.GetComponent<Rigidbody2D>();

            rb.mass = 50;

            Invoke("ResetMass", 15);
        }
    }

    void ResetMass() {
        var player = GameObject.FindGameObjectWithTag("Player");

        var rb = player.GetComponent<Rigidbody2D>();

        rb.mass = 1;
    }
}
