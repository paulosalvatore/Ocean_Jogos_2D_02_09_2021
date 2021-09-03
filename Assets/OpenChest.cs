using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public SpriteRenderer closedChest;

    public Sprite openChestSprite;

    public GameObject statue;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Stone"))
        {
            statue.SetActive(false);

            closedChest.sprite = openChestSprite;
        }
    }
}
