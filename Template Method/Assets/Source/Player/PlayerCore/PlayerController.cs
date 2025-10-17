using Attack;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerController
    {
        private AttackPerformer _attackPerformer;

        public PlayerController(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
        }

        public void Attack()
        {
            _attackPerformer.ExecuteAlgoritm();
        }
    }
}