using Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class EnemySpawn : ABaseEnemy
    {
        public override void Attack()
        {
            animator.SetTrigger(AnimatorParametrContainer.SPAWN_HASH);
        }
    }
}