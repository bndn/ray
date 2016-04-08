/// Copyright (C) 2016 The Authors.
module Ray

open Vector
open Point

type Ray

val make : Point -> Vector -> Ray

val getOrigin : Ray -> Point

val getVector : Ray -> Vector
