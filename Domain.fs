module Domain

type Undefinied = exn

type Challenge = Undefinied
type Clue = Undefinied
type Distance = Undefinied
type Input = Undefinied
type Photo = Undefinied
type Point = Undefinied
type Reward = Undefinied

type getRewards = Challenge -> Input -> Reward

type pointOfInterest = Clue -> Point -> Distance -> Reward -> Challenge

type photo = Point -> Photo -> Input

type within = Point -> Point -> Distance -> bool