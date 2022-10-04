using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinEnter : MonoBehaviour
{
    public TextMeshProUGUI text;

    public CoinManager coinManager;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            coinManager.argent++;
            text.text = "Argent : " + coinManager.argent + "$";
            Destroy(this.gameObject);
        }
    }
}
