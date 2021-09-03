using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public SpriteRenderer closedChest;

    public Sprite openChestSprite;

    public GameObject statue;

    public AudioSource audioOpenChest;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Stone"))
        {
            StartCoroutine(Open());
        }
    }

    IEnumerator Open() {
        // Desativa a estátua
        statue.SetActive(false);

        // Aguarda um segundo
        yield return new WaitForSeconds(1.5f);

        closedChest.sprite = openChestSprite;

        audioOpenChest.Play();
    }
}
