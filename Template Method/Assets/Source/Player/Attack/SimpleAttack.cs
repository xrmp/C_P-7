using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attack
{
    public class SimpleAttack : IAttack
    {
        public void Attack(Animator animator)
        {
            Debug.Log("Use Simple attack");
            animator.SetTrigger(AnimatorParametrContainer.SIMPLE_ATTACK_HASH);
        }
    }
}