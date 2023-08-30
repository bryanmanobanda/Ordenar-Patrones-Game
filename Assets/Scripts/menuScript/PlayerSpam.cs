using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpam : MonoBehaviour
{
    void Start()
    {
        Instantiate(PlayerStorage.playerPrefab, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
