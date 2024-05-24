using System;
using Descant.Components;
using Descant.Utilities;
using UnityEngine;

namespace Descant.Components
{
    [Serializable, MaxQuantity(1), NodeType(DescantNodeType.Any)]
    public class SetTypewriter : DescantComponent
    {
        [Inline] public bool Active;
        
        public override DescantNodeInvokeResult Invoke(DescantNodeInvokeResult result)
        {
            DescantComponentUtilities.InvokeFromObjectOrScript(
                this,
                "",
                "DescantDialogueController",
                "SetTypewriter",
                Active.ToString()
            );
            
            return result;
        }
    }
}