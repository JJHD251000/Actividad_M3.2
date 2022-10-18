using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Health : NetworkBehaviour
{
    public const int maxHealth = 100;

    [SyncVar(hook = "OnChangeHealth")]
    public int currentHealth = maxHealth;

    public RectTransform healthBar;

    public void TakeDamage(int amount) {
        if(!isServer) {
            return;
        }
        
        currentHealth -= amount;
        if(currentHealth <= 0) {
            currentHealth = maxHealth;
            //called on the Server, but invoked on the Clients
            RpcResapwn();
        }

    }
    void OnChangeHealth(int currentHealth) {
        healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);
    }

    [ClientRpc]
    void RpcResapwn() {
        if(isLocalPlayer) {
            //move back to zero location
            transform.position = Vector3.zero;
        }
    }
}
