using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attack
{
    public class UltraAttack : IAttack
    {
        public void Attack(Animator animator)
        {
            Debug.Log("Use Ultra attack");
            animator.SetTrigger(AnimatorParametrContainer.ULTRA_ATTACK_HASH);
        }
    }
}