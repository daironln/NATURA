using Questions;
using UnityEngine;
using TMPro;

namespace Scenaries
{
    public class Select : GenericSingleton<Select>
    {
        [SerializeField] private TextMeshProUGUI question;
        [SerializeField] private TextMeshProUGUI[] ans;
        [SerializeField] private GameObject pannel;
        [SerializeField] private GameObject quizMenu;
        
        [HideInInspector] public int correctIndex;

        [SerializeField] private Animations.Animations ani; 

        protected override void Awake()
        {
            base.Awake();
            correctIndex = Random.Range(0, 3);
        }

        public void Quiz(int scene, int problem)
        {
            if (!pannel.activeInHierarchy)
            {
                
                int r;
                
                pannel.SetActive(true);
                
                ani.ScaleUI(quizMenu);
                
                var questTuple = QuestSystem.Instance.getQuestion(scene, problem);
                var badTuple = QuestSystem.Instance.getBadAnswer(scene, problem, questTuple.Item2, -1);
                
                question.SetText(questTuple.Item1);
                ans[correctIndex].SetText(QuestSystem.Instance.getCorrectAnswer(scene, problem, questTuple.Item2));
                
                //correctIndex = r;
                
                do
                {
                    r = Random.Range(0, 3);
                } 
                while (r == correctIndex);
                
                ans[r].SetText(badTuple.Item1);
                Debug.Log((3-r)-correctIndex);
                Debug.Log(r);
                Debug.Log("Correct "+correctIndex);
                ans[(3-r)-correctIndex].SetText(QuestSystem.Instance.getBadAnswer(scene, problem, questTuple.Item2, badTuple.Item2).Item1);

            }
        }
    }
}
