module Domain

type Undefinied = exn

// types

type Altitude = Undefinied
type Challenge = Undefinied
type Clue = Undefinied
type Distance = Undefinied
type Input = Undefinied
type InputFilter = Undefinied
type Photo = Undefinied
type Point = Undefinied
type Reward = Undefinied

// constructors

type getRewards = Challenge -> Input -> Reward

// semantics from pg104
// ∀ (c :: Clue) (p :: Point) (d :: Distance) (r :: ↪ Reward).
// pointOfInterest c p d r = clue c (gate (photoWithin p d) (reward r))
type pointOfInterest = Clue -> Point -> Distance -> Reward -> Challenge

type photo = Point -> Photo -> Input

type within = Point -> Point -> Distance -> bool

type clue = Clue -> Challenge -> Challenge

// experience suggests that this should be a terminal constructor — 
// one which builds a Challenge ex nihilo
type reward = Reward -> Challenge

type photoWithin = Point -> Distance -> InputFilter

type photoAbove = Altitude -> InputFilter

type matches = InputFilter -> Input -> bool

type gate = InputFilter -> Challenge -> Challenge

// we should expect all of the usual boolean values and operations to lift over input filters
type always = InputFilter
type never = InputFilter
type andF = InputFilter -> InputFilter -> InputFilter
type orF = InputFilter -> InputFilter -> InputFilter
type notF = InputFilter -> InputFilter
