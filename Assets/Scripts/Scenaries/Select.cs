using Questions;
using UnityEngine;
using TMPro;

namespace Scenaries
{
    public class Select : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI question;
        [SerializeField] private TextMeshProUGUI[] ans;
        [SerializeField] private GameObject pannel;
        [SerializeField] private GameObject quizMenu;
        [SerializeField] private int scenne;
        [SerializeField] private int problem;
        
        [HideInInspector] public int correctIndex = -1;

        private void OnMouseDown()
        {
            if (!pannel.activeInHierarchy)
            {
                Vector3 origScale = this.gameObject.transform.parent.localScale;
                LeanTween.scale(this.GetComponentInParent<SpriteRenderer>().gameObject, new Vector3(0.15f, 0.15f, 0.15f), 0.2f);
                LeanTween.scale(this.GetComponentInParent<SpriteRenderer>().gameObject, origScale, 0.3f)
                    .setEase(LeanTweenType.easeOutBounce).setDelay(0.2f);
                var r = Random.Range(0, 3);
                
                pannel.SetActive(true);
                LeanTween.scale(quizMenu.GetComponent<RectTransform>(), new Vector3(1, 1, 1), 0.8f).setEase(LeanTweenType.easeOutBounce);
                
                var questTuple = QuestSystem.Instance.getQuestion(scenne, problem);
                var badTuple = QuestSystem.Instance.getBadAnswer(scenne, problem, questTuple.Item2, -1);
                
                question.SetText(questTuple.Item1);
                ans[r].SetText(QuestSystem.Instance.getCorrectAnswer(scenne, problem, questTuple.Item2));
                
                correctIndex = r;
                
                do
                {
                    r = Random.Range(0, 3);
                } 
                while (r == correctIndex);
                
                ans[r].SetText(badTuple.Item1);
                Debug.Log((3-r)-correctIndex);
                Debug.Log(r);
                Debug.Log(correctIndex);
                ans[(3-r)-correctIndex].SetText(QuestSystem.Instance.getBadAnswer(scenne, problem, questTuple.Item2, badTuple.Item2).Item1);

            }
        }

        public int CorrectIdx()
        {
            var idx = correctIndex;

            return idx;
        }
    }
}
