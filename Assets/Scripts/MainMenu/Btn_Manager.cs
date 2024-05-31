using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class Btn_Manager : MonoBehaviour
    {
        public void QuitGame()
        {
            Application.Quit();
        }

        public void NewGame(int idx)
        {
            SceneManager.LoadScene(Random.Range(1, 6));
        }
        
        public void Galery()
        {
            SceneManager.LoadScene(6);
        }
    }
}
    

