using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class FallRestore : MonoBehaviour
    {
        [SerializeField] private Ball playerBall;
        [SerializeField] private Stars.StarController starController;
        private Vector3 startPosition;

        private void Awake()
        {
            startPosition = playerBall.transform.position;

            playerBall.OnBallFall.AddListener(() =>
            {
                starController.FallReactStars();

                playerBall.transform.position = startPosition;

                if(starController.CollectedStars < 0)
                {
                    playerBall.enabled = false;
                    Debug.Log("Player is failed");
                }
            });
        }
    }
}
