using UnityEngine;
using UnityEngine.Events;

namespace Finish
{
    [RequireComponent(typeof(Collider))]
    public class FinishPanel : MonoBehaviour
    {
        public UnityEvent FinishedEvent = new();

        private void OnTriggerEnter(Collider other)
        {
            FinishedEvent.Invoke();
        }
    }
}
