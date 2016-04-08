/// Copyright (C) 2016 The Authors.
module Ray

open Vector
open Point

type Ray = R of Point * Vector

let make p v =
    let d = Vector.normalise v
    R(p, d)

let getOrigin (R(p, _)) = p

let getVector (R(_, d)) = d
