using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{

    public int AttackDamage;

    private void OnTriggerEnter(Collider other)
    {
        EnemyStats enemystats = other.gameObject.GetComponent<EnemyStats>();

        if (enemystats != null)
        {
            enemystats.UpdateHealth(AttackDamage);

        }
    }
}
	
