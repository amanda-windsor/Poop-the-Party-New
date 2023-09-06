using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public GameObject soundEffectPrefab;

    private void PlaySoundEffect()
    {
        if (soundEffectPrefab != null)
        {
            GameObject soundEffect = Instantiate(soundEffectPrefab);
            Destroy(soundEffect, 2f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Bullet"))
        {
            PlaySoundEffect();
        }
    }
}
