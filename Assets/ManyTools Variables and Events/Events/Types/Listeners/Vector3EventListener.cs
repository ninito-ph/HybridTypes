using UnityEngine;
using UnityEngine.Events;

namespace ManyTools.Events
{
    public class Vector3EventListener : EventListener<Vector3>
    {
        #region Private Fields

        [SerializeField] private Vector3Event _event;
        [SerializeField] private UnityEvent<Vector3> _unityEvent;
        
        #endregion

        #region EventListener Implementation

        public override UnityEvent<Vector3> UnityEvent => _unityEvent;
        public override GameEvent<Vector3> GameEvent
        {
            get => _event;
            set
            {
                if (_event != null)
                {
                    _event.RemoveListener(this);
                }
            
                _event = value as Vector3Event;
            
                if (_event != null)
                {
                    _event.AddListener(this);
                }
            }
        }

        #endregion
    }
}