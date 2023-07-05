using UnityEngine;

namespace Other
{
    public static class ScreenManager
    {
        public static void Init()
        {
            Screen.autorotateToLandscapeRight = true;
            Screen.autorotateToLandscapeLeft = true;
            Screen.autorotateToPortrait = false;
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
    }
}