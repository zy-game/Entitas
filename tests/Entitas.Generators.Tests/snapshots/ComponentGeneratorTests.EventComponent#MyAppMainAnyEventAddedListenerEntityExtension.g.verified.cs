﻿//HintName: MyAppMainAnyEventAddedListenerEntityExtension.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ComponentGenerator.EntityExtension
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using global::MyApp.Main;
using static global::MyAppMainAnyEventAddedListenerComponentIndex;

public static class MyAppMainAnyEventAddedListenerEntityExtension
{
    public static bool HasAnyEventAddedListener(this Entity entity)
    {
        return entity.HasComponent(Index.Value);
    }

    public static Entity AddAnyEventAddedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainAnyEventAddedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainAnyEventAddedListenerComponent)componentPool.Pop()
            : new MyAppMainAnyEventAddedListenerComponent();
        component.Value = value;
        entity.AddComponent(index, component);
        return entity;
    }

    public static Entity ReplaceAnyEventAddedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainAnyEventAddedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainAnyEventAddedListenerComponent)componentPool.Pop()
            : new MyAppMainAnyEventAddedListenerComponent();
        component.Value = value;
        entity.ReplaceComponent(index, component);
        return entity;
    }

    public static Entity RemoveAnyEventAddedListener(this Entity entity)
    {
        entity.RemoveComponent(Index.Value);
        return entity;
    }

    public static MyAppMainAnyEventAddedListenerComponent GetAnyEventAddedListener(this Entity entity)
    {
        return (MyAppMainAnyEventAddedListenerComponent)entity.GetComponent(Index.Value);
    }
}
