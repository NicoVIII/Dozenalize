namespace Dozenalize

[<AutoOpen>]
module Types =
    type Config = { decChar: string; elChar: string }

[<RequireQualifiedAccess>]
module Config =
    let create dec el = { decChar = dec; elChar = el }

    // Prepared default configs
    let ab = create "A" "B"
    let te = create "T" "E"
    let xe = create "X" "E"
    let xz = create "X" "Z"
    let greek1 = create "δ" "ε"
    let greek2 = create "τ" "ε"
    let andrews = create "X" "ℰ"
    let kramer = create "⚹" "#"
    // let dwiggins = // sadly no unicode characters for that :/
    let pitman = create "↊" "↋"
