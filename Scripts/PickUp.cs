using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    GameObject gm;
    GameManager gameManager;
    private void Start() { // Assignar fyrir easy referencing
        gm = GameObject.Find("GameManager");
        gameManager = gm.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other) { // "Pickar up" objectið og bætir við lífi
        gameManager.AddHealth();
        Destroy(gameObject);
    }
}
