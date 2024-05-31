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
        
        private int correctIndex;

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
                ans[(3-r)-correctIndex].SetText(QuestSystem.Instance.getBadAnswer(scene, problem, questTuple.Item2, badTuple.Item2).Item1);

            }
        }

        public void ExitQuiz()
        {
            ani.ScaleUIto0(quizMenu);
            Invoke("DeactivatePanel", 0.67f);
        }

        public void DeactivatePanel()
        {
            pannel.SetActive(false);
        }

        public GameObject getQuizMemu()
        {
            return quizMenu;
        }

        public int getCorrectIndex()
        {
            return correctIndex;
        }

        public bool isPanelActive()
        {
            return pannel.activeInHierarchy;
        }
    }
}
