using Enemy;
using Player;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class InputListener : MonoBehaviour
    {
        public event Action onAttack;
        private PlayerController _controller;
        public void Construct(PlayerController controller)
        {
            _controller = controller;
        }
        private void Update()
        {
            if (_controller != null)
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    onAttack?.Invoke();
                    _controller.Attack();
                }
            }
        }
    }
}