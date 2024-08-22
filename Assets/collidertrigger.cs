using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidertrigger : MonoBehaviour
{
    private void OnCollusionEnter2D(Collider2D other)
    {

        if (other.CompareTag("Enemy"))
        {

            Destroy(other.gameObject);
        }
    }

}