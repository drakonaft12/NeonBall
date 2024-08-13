using TMPro;
using UnityEngine;

namespace Stars
{
    public class StarController : MonoBehaviour
    {
        [SerializeField] private Star[] stars;
        [SerializeField] private TMP_Text viewCollectedStars;
        private int collectedStars = 0;

        public int CollectedStars
        {
            get
            {
                return collectedStars;
            }
        }

        private void Awake()
        {
            viewCollectedStars.text = collectedStars.ToString();
            foreach (var star in stars)
            {
                star.Collected.AddListener(() => { 
                    collectedStars++;
                    viewCollectedStars.text = collectedStars.ToString();
                    star.gameObject.SetActive(false); 
                });
            }
        }

        public void FallReactStars()
        {
            collectedStars--;
            viewCollectedStars.text = collectedStars.ToString();
        }

        public void ResetStars()
        {
            foreach (var star in stars)
            {
                star.gameObject.SetActive(true);
            }
            collectedStars = 0;
            viewCollectedStars.text = collectedStars.ToString();
        }
    }
}
