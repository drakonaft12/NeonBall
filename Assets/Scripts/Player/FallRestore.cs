using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Ball))]
    public class FallRestore : MonoBehaviour
    {
        private Ball playerBall;
        private Rigidbody playerRigidbody;
        [SerializeField] private Stars.StarController starController;
        private Vector3 startPosition;

        private void Awake()
        {
            playerBall = GetComponent<Ball>();
            playerRigidbody = GetComponent<Rigidbody>();

            startPosition = playerBall.transform.position;

            playerBall.OnBallFall.AddListener(() =>
            {
                starController.FallReactStars();

                ResetState();

                if (starController.CollectedStars < 0)
                {
                    Debug.Log("End Game");
                }
            });

        }

        public void ResetState()
        {
            playerRigidbody.velocity = Vector3.zero;
            playerRigidbody.angularVelocity = Vector3.zero;
            playerRigidbody.ResetCenterOfMass();

            playerBall.transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        }
    }
}
