﻿using Content.Server._Citadel.Worldgen.Systems;

namespace Content.Server._Citadel.Worldgen.Components;

/// <summary>
/// This is used for allowing some objects to load the game world.
/// </summary>
[RegisterComponent, Access(typeof(WorldControllerSystem))]
public sealed class WorldLoaderComponent : Component
{
    /// <summary>
    /// The radius in which the loader loads the world.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("radius")]
    public int Radius = 128;
}
