using UnityEngine.UI;
using Scenaries;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace Questions
{
    public class QuestController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI[] text;
        [SerializeField] private GameObject ansObj;
        [SerializeField] private Sprite correctImage;
        [SerializeField] private Sprite badImage;
        [SerializeField] private Animations.Animations ani;
        [SerializeField] private TextMeshProUGUI ansText;

        [SerializeField] private Click click;
        
        [SerializeField] private Sprite[] repair;
        [SerializeField] private GameObject nonRepair;
        [SerializeField] private GameObject allRestable;

        private Vector3 originalAnsObjPos;

        private void Start()
        {
            originalAnsObjPos = ansObj.transform.position;
            GameManager.Instance.setContCorrectAnsto0(SceneManager.GetActiveScene().buildIndex - 1);
        }
        
        private void IncorrectAns(int index)
        {
            //text[index].color = new Color32(132, 24, 24, 255);

            ansObj.GetComponent<Image>().sprite = badImage;
            Select.Instance.getQuizMemu().SetActive(false);
            ani.MoveUI(ansObj, new Vector3(0f, ansObj.transform.position.y, 0f));
            
            ansText.GetComponent<RectTransform>().transform.localScale = new Vector3(1f, 1f, 1f);
            ansText.SetText("QUE MAL!! \nRESPUESTA INCORRECTA");
            
            ani.ScaleUILoop(ansText.gameObject, new Vector3(0.7f, 0.7f, 0.7f));
        }
        private void CorrectAns(int index)
        {

            //text[index].color = new Color32(24, 132, 24, 255);

            ansObj.GetComponent<Image>().sprite = correctImage;
            Select.Instance.getQuizMemu().SetActive(false);
            ani.MoveUI(ansObj, new Vector3(0f, ansObj.transform.position.y, 0f));

            ansText.GetComponent<RectTransform>().transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
            ansText.SetText("ENHORABUENA!! \nRESPUESTA CORRECTA\nENCUENTRA EL OTRO PROBLEMA");

            GameObject obj = GameObject.FindWithTag(GameManager.Instance.getActualProblem());
            obj.SetActive(false);
            
            ani.ScaleUILoop(ansText.gameObject, new Vector3(1f, 1f, 1f));

            nonRepair.GetComponent<Image>().sprite = repair[GameManager.Instance.getContCorrectAns(SceneManager.GetActiveScene().buildIndex - 1)];

            GameManager.Instance.sumContCorrectAns(SceneManager.GetActiveScene().buildIndex - 1);

            if (GameManager.Instance.getContCorrectAns(SceneManager.GetActiveScene().buildIndex - 1) >= 2)
            {
                allRestable.GetComponent<Image>().sprite = repair[2];
                Invoke("LoadOtherScene", 3.9f);
                GameManager.Instance.setCorrectAnsGal(SceneManager.GetActiveScene().buildIndex - 1);
            }

        }

        private void LoadOtherScene()
        {
            int  r = Random.Range(1, 6);

            do
            {
                r = Random.Range(1, 6);
            } while (r == SceneManager.GetActiveScene().buildIndex);
            
            SceneManager.LoadScene(r);
        }

        public void Ans(int index)
        {
            if (index.Equals(Select.Instance.getCorrectIndex())) CorrectAns(index);
            else IncorrectAns(index);
        }

        public void ExitQuiz()
        {
            Select.Instance.ExitQuiz();
            //FindObjectOfType<Click>().gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
        public void ExitAns()
        {
            ani.MoveUI(ansObj, new Vector3(-1984, -8.0109e-05f, 0));
            ani.ScaleUIto0(Select.Instance.getQuizMemu());
            Select.Instance.DeactivatePanel();
            Select.Instance.getQuizMemu().SetActive(true);
            //FindObjectOfType<Click>().gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
        public void ExitScene()
        {
            SceneManager.LoadScene(0);
        }
        
    }
}
