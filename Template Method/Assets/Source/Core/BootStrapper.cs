using Attack;
using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class BootStrapper : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        private List<IAttack> attackList;
        private IAttack _simple;
        private IAttack _super;
        private IAttack _ultra;
        private PlayerController _playerController;
        [SerializeField] private StrategySwitcher _changeStrategy;
        [SerializeField] private InputListener _inputListener;
        private AttackPerformer _attackPerformer;

        private void Awake()
        {
            _simple = new SimpleAttack();
            _super = new SuperAttack();
            _ultra = new UltraAttack();

            attackList = new List<IAttack>
        {
            _simple,
            _super,
            _ultra
        };
            _attackPerformer = new AttackPerformer(_simple,animator);
            _changeStrategy.Construct(attackList, _attackPerformer);
            _playerController = new PlayerController(_attackPerformer);
            _inputListener.Construct(_playerController);
        }
    }
}