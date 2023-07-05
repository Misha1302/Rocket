using UnityEngine;

namespace Rocket
{
    using Other;

    public class RocketUiMovement : MonoBehaviour
    {
        [SerializeField] private RButton upButton;
        [SerializeField] private RButton leftButton;
        [SerializeField] private RButton rightButton;

        public bool CanFlyUp => upButton.IsPressing;
        public bool CanRotateLeft => leftButton.IsPressing;
        public bool CanRotateRight => rightButton.IsPressing;
    }
}