using Unity.Mathematics.Geometry;
using UnityEngine;

namespace RMC.Demos
{
    /// <summary>
    /// Demo of the <see cref="Cube"/>
    /// </summary>
    public class Demo : MonoBehaviour
    {
        //  Events ----------------------------------------


        //  Properties ------------------------------------

        
        //  Fields ----------------------------------------
        [SerializeField]
        private Cube _cube;


        //  Unity Methods ---------------------------------
        protected void Start()
        {

        }


        protected void Update()
        {
            _cube.transform.rotation *= Quaternion.Euler(0, 1, 0);

            _cube.transform.position += Vector3.up * Mathf.Sin(Time.timeSinceLevelLoad) * 0.003f;

        }


        //  Methods ---------------------------------------
        public string SamplePublicMethod(string message)
        {
            return message;
        }


        //  Event Handlers --------------------------------
        public void Target_OnCompleted(string message)
        {

        }
    }
}