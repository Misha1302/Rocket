using UnityEngine.SceneManagement;

namespace Rocket
{
    public static class RocketSceneManager
    {
        public static void Reload()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public static void LoadNext()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public static void LoadPrevious()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}