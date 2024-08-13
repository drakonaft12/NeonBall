using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI
{
    public class RestartButton : MonoBehaviour
    {
        public UnityEvent Restart;

        private void Awake()
        {
            GetComponent<Button>().onClick.AddListener(Restart.Invoke);
        }

    }
}
