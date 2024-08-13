using Finish;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EntryPoint
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private GameObject winPanel;
        [SerializeField] private FinishPanel finishPanel;  

        private void Awake()
        {
            winPanel.SetActive(false);
            finishPanel.FinishedEvent.AddListener(() => winPanel.SetActive(true));
        }
    }
}
