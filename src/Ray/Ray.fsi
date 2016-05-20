/// Copyright (C) 2016 The Authors.
module Ray

open Point
open Transform
open Vector

[<Sealed>]
[<NoComparison>]
type Ray =
    /// <summary>
    /// Transform a ray with a transformation.
    /// </summary>
    /// <param name=r>The ray to transform.</param>
    /// <param name=t>The transformation to apply to the ray.</param>
    /// <returns>The transformed ray.</returns>
    static member (*) : r:Ray * t:Transformation -> Ray

/// <summary>
/// Create a ray; a normalized vector with a point of origin.
/// If the vector provided is not already normalized `make`
/// will normalize it.
/// </summary>
/// <param name=o>The point of origin of the ray.</param>
/// <param name=v>The vector of the ray, which will be normalized.</param>
/// <returns>The created ray.</returns>
val make : o:Point -> v:Vector -> Ray

/// <summary>
/// Get the point of origin of a ray.
/// </summary>
/// <param name=r>The ray whose point of origin to get.</param>
/// <returns>The point of origin for a ray.</returns>
val getOrigin : r:Ray -> Point

/// <summary>
/// Get the normalized vector of a ray.
/// </summary>
/// <param name=r>The ray whose normalized vector to get.</param>
/// <returns>The normalized vector for a ray.</returns>
val getVector : r:Ray -> Vector

/// <summary>
/// Transform the ray with some transformation.
/// </summary>
/// <param name=r>The ray to transform.</param>
/// <param name=t>The transformation to apply to the ray.</param>
/// <returns>The transformed ray.</returns>
val transform : r:Ray -> t:Transformation -> Ray
