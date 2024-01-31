using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    public class BulletSwitcher : MonoBehaviour
    {
        private PlayerController playerController;

        void Start()
        {
            // to find the PlayerController in the scene
            playerController = FindObjectOfType<PlayerController>();

            if (playerController == null)
            {
                Debug.LogError("PlayerController not found in the scene.");
                return;
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                playerController.SetCurrentBullet(0);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                playerController.SetCurrentBullet(1);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                playerController.SetCurrentBullet(2);
            }
        }
    }
}
