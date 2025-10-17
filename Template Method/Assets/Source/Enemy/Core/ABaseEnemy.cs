using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public abstract class ABaseEnemy : MonoBehaviour
    {
        [SerializeField] protected Animator animator;
        public abstract void Attack();

        protected virtual void Start()
        {
            Attack();
        }
    }
}