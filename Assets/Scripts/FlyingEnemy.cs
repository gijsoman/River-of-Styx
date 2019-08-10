using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    [SerializeField]int health;
    private int currentHealth;

    private void Start() {
        currentHealth = health;
    }

    public void OnTapped() {
        //Do something on Tapped
        currentHealth--;
        if (currentHealth <= 0 ) {
            Die();
        }
    }

    private void Die() {
        Destroy( this.gameObject );
    }
}
