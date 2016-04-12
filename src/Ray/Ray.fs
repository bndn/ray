/// Copyright (C) 2016 The Authors.
module Ray

open Vector
open Point

type Ray = R of Point * Vector

/// <summary>
/// Create a ray; a normalized vector with a point of origin.
/// If the vector provided is not already normalized `make`
/// will normalize it.
/// </summary>
/// <param name=o>The point of origin of the ray.</param>
/// <param name=v>The vector of the ray, which will be normalized.</param>
/// <returns>The created ray.</returns>
let make o v =
    let d = Vector.normalise v
    R(o, d)

/// <summary>
/// Get the point of origin of a ray.
/// </summary>
/// <param name=r>The ray whose point of origin to get.</param>
/// <returns>The point of origin for a ray.</returns>
let getOrigin (R(o, _)) = o

/// <summary>
/// Get the normalized vector of a ray.
/// </summary>
/// <param name=r>The ray whose normalized vector to get.</param>
/// <returns>The normalized vector for a ray.</returns>
let getVector (R(_, d)) = d
