using Finish;
using Player;
using Stars;
using UI;
using UnityEngine;

namespace EntryPoint
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private GameObject winPanel;
        [SerializeField] private FinishPanel finishPanel;
        [SerializeField] private RestartButton restartButton;
        [SerializeField] private StarController starController;
        [SerializeField] private FallRestore fallRestore;

        private void Awake()
        {
            winPanel.SetActive(false);
            finishPanel.FinishedEvent.AddListener(() => winPanel.SetActive(true));
            restartButton.Restart.AddListener(() =>
            {
                winPanel.SetActive(false);
                starController.ResetStars();
                fallRestore.ResetState();
            });
        }


    }
}
