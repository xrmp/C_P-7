using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attack
{
    public class AttackPerformer
    {
        private Animator _animator;
        public IAttack AttackStrategy { get; set; }

        public AttackPerformer(IAttack attackStrategy, Animator animator)
        {
            _animator = animator;
            AttackStrategy = attackStrategy;
        }
        public void ExecuteAlgoritm()
        {
            AttackStrategy.Attack(_animator);
        }
        public void SetStrategy(IAttack attack)
        {
            AttackStrategy = attack;
        }
    }
}