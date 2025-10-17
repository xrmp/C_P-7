using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class EnemyFire : ABaseEnemy
    {
        public override void Attack()
        {
            StartCoroutine(Fire());
        }
        private IEnumerator Fire()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);
                animator.SetTrigger(AnimatorParametrContainer.FIRE_HASH);   
            }
        }
    }
}
