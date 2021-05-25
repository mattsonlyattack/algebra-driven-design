module Domain

type Undefinied = exn

// types

type Challenge = Undefinied
type Clue = Undefinied
type Distance = Undefinied
type Input = Undefinied
type Photo = Undefinied
type Point = Undefinied
type Reward = Undefinied

// constructors

type getRewards = Challenge -> Input -> Reward

type pointOfInterest = Clue -> Point -> Distance -> Reward

type photo = Point -> Photo -> Input

type within = Point -> Point -> Distance -> bool

type clue = Clue -> Challenge -> Challenge

type reward = Reward -> Challenge

type photoWithin = Point -> Distance -> Challenge -> Challenge