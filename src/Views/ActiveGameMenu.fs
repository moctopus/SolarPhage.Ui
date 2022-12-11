module ActiveGameMenu

open App.Types
open Feliz

let render (dispatch: Msg -> unit) = 
    Html.div [
        Html.button [
            prop.onClick (fun _ -> dispatch <| ChangePage TownMenu)
            prop.text "Join"
        ]

        Html.button [
            prop.text "Delete"
        ]
        
        Html.button [
            prop.onClick (fun _ -> dispatch <| ChangePage MainMenu)
            prop.text "Back"
        ]
    ]