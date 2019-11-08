#if PEGASUS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pegasus
{
    public class TriggerAnimationVariable : TriggerBase
    {
        public enum AnimationVariableType { Float, Int, Bool, Trigger }
        public AnimationVariableType m_variableType = AnimationVariableType.Trigger;
        public Animator m_animator;
        public string m_variableName;
        public float m_floatValue;
        public int m_intValue;
        public bool m_boolValue;

        //TODO: Create an editor that only shows the appropriate variable value field

        public override void OnStart(PegasusPoi poi)
        {
            // TODO: convert string name to an animation ID for performance reasons
            switch (m_variableType)
            {
                case AnimationVariableType.Float:
                    m_animator.SetFloat(m_variableName, m_floatValue);
                    break;
                case AnimationVariableType.Int:
                    m_animator.SetInteger(m_variableName, m_intValue);
                    break;
                case AnimationVariableType.Bool:
                    m_animator.SetBool(m_variableName, m_boolValue);
                    break;
                case AnimationVariableType.Trigger:
                    m_animator.SetTrigger(m_variableName);
                    break;
            }
        }
    }
}
#endif