using Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class MirrorEnemy : ABaseEnemy
    {
        private InputListener _inputListener;
        public override void Attack()
        {
            animator.SetTrigger(AnimatorParametrContainer.MIRROR_HASH);
        }

        protected override void Start()
        {
            _inputListener = FindObjectOfType<InputListener>();
            _inputListener.onAttack += Attack;
        }

        private void OnDestroy()
        {
            _inputListener.onAttack -= Attack;
        }
    }
}