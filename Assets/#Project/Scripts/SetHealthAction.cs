using Core.Combat;
using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Set Health", story: "Set [Destructable] health to [Health]", category: "Action/Boss Fight", id: "ae3faf8bfb8fe30fa75032a10d6673ea")]
public partial class SetHealthAction : Action
{
    [SerializeReference] public BlackboardVariable<Destructable> Destructable;
    [SerializeReference] public BlackboardVariable<int> Health;

    protected override Status OnStart()
    {
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        Destructable.Value.CurrentHealth = Health.Value;
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

