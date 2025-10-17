using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

namespace Attack
{
    public class StrategySwitcher : MonoBehaviour
    {
        //TODO рассмотреть компонент кнопки, которая хранит свою стратегию атаки + динамический спавн кнопок
        //TODO Рассмотреть более гибкую систему
        [SerializeField] private Button[] strategyButtons;
        private List<IAttack> _attackStrategies;
        [SerializeField] private GameObject[] prefabEnemies;
        private GameObject _currentEnemy; 
        public AttackPerformer AttackPerformer { get; private set; }

        public void Construct(List<IAttack> attackStrategies, AttackPerformer attackPerformer)
        {
            AttackPerformer = attackPerformer;
            _attackStrategies = attackStrategies;
        }

        void Start()
        {
            for (int i = 0; i < strategyButtons.Length; i++)
            {
                int index = i;
                strategyButtons[i].onClick.AddListener(() => SetStrategy(index));
                strategyButtons[i].onClick.AddListener(() => SetEnemy(index));
            }
        }

        private void SetStrategy(int index)
        {
            if (index >= 0 && index < _attackStrategies.Count)
            {
                AttackPerformer.SetStrategy(_attackStrategies[index]);
                Debug.Log($"Switched to {_attackStrategies[index].GetType().Name} Strategy");
            }
        }

        private void SetEnemy(int index)
        {
            if (_currentEnemy != null)
            {
                Destroy(_currentEnemy);
            }
            if (index >= 0 && index < prefabEnemies.Length)
            {
                _currentEnemy = Instantiate(prefabEnemies[index]);
            }
        }
    }
}