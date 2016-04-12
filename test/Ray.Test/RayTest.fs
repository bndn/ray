/// Copyright (C) 2016 The Authors.
module Ray.Test

open Xunit
open FsUnit.Xunit

[<Fact>]
let ``make constructs a ray given a point of origin and a vector`` () =
    let p = Point.make 0.0 4.0 4.0
    let v = Vector.make 0.0 -4.0 -4.0
    let r = Ray.make p v

    // Check that a ray was constructed
    r |> should be instanceOfType<Ray>

[<Fact>]
let ``getOrigin gets the point of origin for a ray`` () =
    let p = Point.make 0.0 4.0 4.0
    let v = Vector.make 0.0 -4.0 -4.0
    let r = Ray.make p v

    // Check that the point of origin for the ray is the same as the
    // one used for the construction of it
    Ray.getOrigin r |> should equal p

[<Fact>]
let ``getVector gets the (normalized) vector for a ray`` () =
    let p = Point.make 0.0 4.0 4.0
    let v = Vector.make 0.0 -4.0 -4.0
    let r = Ray.make p v

    // Check that the vector for the ray is the same as the one used
    // for the construction of it, but normalized
    Ray.getVector r |> should equal (Vector.normalise v)
