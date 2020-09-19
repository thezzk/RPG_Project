using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float health = 100f;
        bool death = false;
        public void TakeDamage(float damage)
        {
            health = Mathf.Max(health - damage, 0);
            print(health);
            if(health <= 0 && !death)
            {
                death = true;
                GetComponent<Animator>().SetTrigger("die");
            }
        }
    }
}
