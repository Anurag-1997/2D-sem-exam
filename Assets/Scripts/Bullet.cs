using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public AudioSource adsrc;
    public AudioClip enemyHitClip;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            adsrc.PlayOneShot(enemyHitClip);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }
    }
}
